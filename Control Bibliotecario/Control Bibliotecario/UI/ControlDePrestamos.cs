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
            if (tipoBusqueda_CB.Text == "")
            {
                MessageBox.Show("Ingrese un tipo de vusqueda antes de realizar una busqueda");
                return;
            }
            if (IdUsuario_Tbx.Text ==""||Convert.ToInt32(IdUsuario_Tbx.Text)==0)
            {
                MessageBox.Show("Favor de ingres un id de usuario Valido");
                return;
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
            if(RealizarPrestamoForm.ShowDialog() == DialogResult.OK)
            {
                this.prestamosTableAdapter.Fill(this.bibliotecaDataSet.Prestamos);
            }
        }

        private void devolverPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolverPrestamoForm DevolverPrestamoForm = new DevolverPrestamoForm();
            DevolverPrestamoForm.Show();
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
    }
}
