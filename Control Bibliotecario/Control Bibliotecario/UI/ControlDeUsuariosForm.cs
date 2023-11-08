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
    public partial class ControlDeUsuariosForm : Form
    {
        public ControlDeUsuariosForm()
        {
            InitializeComponent();
        }

        private void VistaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bibliotecaDataSet.Usuarios);

        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            switch (tipoDeBusqueda_Cbx.SelectedIndex)
            {
                case 0:
                    usuariosTableAdapter.OrdenarPorIdUsuarioEspecifico(bibliotecaDataSet.Usuarios, int.Parse(buscar_Tbx.Text));
                    break;
                case 1:
                    usuariosTableAdapter.OrdenarPorRFCEspecifico(bibliotecaDataSet.Usuarios, buscar_Tbx.Text);
                    break;
                case 2:
                    usuariosTableAdapter.OrdenarPorIdUsuarioEspecifico(bibliotecaDataSet.Usuarios, int.Parse(buscar_Tbx.Text));
                    eliminar_Btn.Enabled = true;
                    break;
            }
        }

        private void tipoDeBusqueda_Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tipoDeBusqueda_Cbx.SelectedIndex)
            {
                case 0:
                    usuariosTableAdapter.OrdenarPorIdUsuario(bibliotecaDataSet.Usuarios);
                    break;
                case 1:
                    usuariosTableAdapter.OrdenarPorRFC(bibliotecaDataSet.Usuarios);
                    break;
                case 2:
                    usuariosTableAdapter.OrdenarPorIdUsuario(bibliotecaDataSet.Usuarios);
                    break;
            }
        }

        private void eliminar_Btn_Click(object sender, EventArgs e)
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string consulta = "SELECT * FROM Usuarios WHERE IdUsuario = " +buscar_Tbx.Text;
            string delete = "DELET * FROM Usuarios WHERE Id Usuario = " +buscar_Tbx.Text;
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = direccion;
            OleDbDataAdapter ada = new OleDbDataAdapter(consulta, conexion);
            conexion.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            if(dt.Rows.Count != 0)
            {
                OleDbCommand cmd = new OleDbCommand(delete, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado al Usuario", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha encontrado al Usuario", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
