using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Control_Bibliotecario.UI
{
    public partial class ControlDePrestamos : Form
    {
        public ControlDePrestamos()
        {
            InitializeComponent();


        }

        private void ControlDePrestamos_Load(object sender, EventArgs e)
        {
            ActualizarPrestamos();
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.bibliotecaDataSet.Prestamos);


        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            if (tipoBusqueda_CB.SelectedIndex >= 0)
            {
                switch (tipoBusqueda_CB.SelectedIndex)
                {
                    case 0:
                        buscar_Tbx.Enabled = true;
                        prestamosTableAdapter.OrdenarPorISBNEspecifico(this.bibliotecaDataSet.Prestamos, buscar_Tbx.Text);
                        break;
                    case 1:
                        buscar_Tbx.Enabled = true;
                        prestamosTableAdapter.ObtenerHistorialPrestamos(this.bibliotecaDataSet.Prestamos, buscar_Tbx.Text);
                        break;

                }

            }
            else
            {
                MessageBox.Show("Favor de Seleccionar un Tipo de Busqueda");
            }

        }

        private void IdUsuario_Tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se suprime la tecla
                e.Handled = true;
            }
        }

        private void relizarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarPrestamoForm RealizarPrestamoForm = new RealizarPrestamoForm();
            if (RealizarPrestamoForm.ShowDialog() == DialogResult.OK)
            {
                this.prestamosTableAdapter.Fill(this.bibliotecaDataSet.Prestamos);
            }
        }

        private void devolverPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolverPrestamoForm DevolverPrestamoForm = new DevolverPrestamoForm();
            if (DevolverPrestamoForm.ShowDialog() == DialogResult.OK)
            {
                this.prestamosTableAdapter.Fill(this.bibliotecaDataSet.Prestamos);
            }
        }

        public void ActualizarPrestamos()
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";

            string consulta = "SELECT * FROM Prestamos WHERE Estatus = 'Activo'";
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = direccion;
            conexion.Open();
            OleDbDataAdapter ada = new OleDbDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            ada.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (DateTime.Parse(dt.Rows[i].ItemArray[6].ToString()) < DateTime.Today)
                    {

                        string actualizar = "UPDATE Prestamos SET Estatus = 'Vencido' WHERE Folio = " + dt.Rows[i].ItemArray[1];

                        OleDbCommand actualizarLibro = new OleDbCommand(actualizar, conexion);
                        conexion.ConnectionString = direccion;

                        actualizarLibro.ExecuteNonQuery();
                    }

                }
            }



        }

        private void tipoBusqueda_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tipoBusqueda_CB.SelectedIndex)
            {
                case 0:
                    buscar_Tbx.Enabled = true;
                    prestamosTableAdapter.OrdenarPorISBN(this.bibliotecaDataSet.Prestamos);
                    break;
                case 1:
                    buscar_Tbx.Enabled = true;
                    prestamosTableAdapter.OrdenarPorUsuario(this.bibliotecaDataSet.Prestamos);
                    break;

                case 2:
                    buscar_Tbx.Enabled = false;
                    prestamosTableAdapter.OrdenarPorActivo(this.bibliotecaDataSet.Prestamos);
                    break;
                case 3:
                    buscar_Tbx.Enabled = false;
                    prestamosTableAdapter.OrdenarPorVencido(this.bibliotecaDataSet.Prestamos);
                    break;
                case 4:
                    buscar_Tbx.Enabled = false;
                    prestamosTableAdapter.OrdenarPorDevuelto(this.bibliotecaDataSet.Prestamos);
                    break;
            }

        }
    }
}
