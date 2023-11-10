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
    public partial class IngresoAdmin : Form
    {
        public string IdUsuario { get; set; }

        public string Nombre { get; set; }
        public IngresoAdmin(string idUsuario, string nombre)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
            Nombre = nombre;

            usuario_Tbx.Text = idUsuario;
            bienvenido_Lbl.Text += " " + Nombre;



        }

        private void ingresar_Btn_Click(object sender, EventArgs e)
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0.;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string consulta = "SELECT * FROM Usuarios WHERE IdUsuario = " + usuario_Tbx.Text;

            System.Data.OleDb.OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = direccion;
            conexion.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
            adaptador.Fill(ds);
            DataTable tablaDatos = ds.Tables[0];

            if (contrasenia_tbx.Text == tablaDatos.Rows[0].ItemArray[11].ToString())
            {
                DialogResult = DialogResult.OK;
                usuario_Tbx.Clear();
                contrasenia_tbx.Clear();
                this.Close();


            }
            else
            {
                MessageBox.Show("Ingrese una contraseña correcta", "Contraseña Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
