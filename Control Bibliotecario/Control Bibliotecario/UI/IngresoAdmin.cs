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
            string consulta = "SELECT Contrasenia FROM Usuarios WHERE IdUsuario = " + usuario_Tbx.Text;

            System.Data.OleDb.OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = direccion;
            conexion.Open();
            DataTable tablaDatos = new DataTable();
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
            adaptador.Fill(tablaDatos);
            

            if (contrasenia_tbx.Text == tablaDatos.Rows[0].ItemArray[0].ToString())
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

        private void mostrar_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(mostrar_checkBox.Checked == true)
            {
                contrasenia_tbx.PasswordChar = '\u0000';
            }
            else
            {
                contrasenia_tbx.PasswordChar = '*';
            }
        }
    }
}
