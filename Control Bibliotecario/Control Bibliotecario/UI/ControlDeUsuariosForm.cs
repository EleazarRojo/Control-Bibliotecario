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
            if(tipoDeBusqueda_Cbx.SelectedIndex >= 0)
            {
                if (tipoDeBusqueda_Cbx.Text == "IdUsuario") 
                {
                    string direccion = "Provider=Microsoft.Jet.OLEDB.4.0.;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
                    string consulta = "SELECT * FROM Usuarios WHERE IdUsuario LIKE " + buscar_Tbx.Text;

                    System.Data.OleDb.OleDbConnection conexion = new OleDbConnection();
                    conexion.ConnectionString = direccion;
                    conexion.Open();
                    DataSet ds = new DataSet();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    adaptador.Fill(ds);
                    DataTable tablaDatos = ds.Tables[0];
                   
                    dataGridView1.DataSource = tablaDatos;
                    conexion.Close();
                }
            }
        }
    }
}
