using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Control_Bibliotecario.Modelos;
using Control_Bibliotecario.UI;


namespace Control_Bibliotecario
{
    public partial class RegistroForm : Form
    {


        public RegistroForm()
        {
            InitializeComponent();
        }

        private void registrar_Btn_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.Nombre = nombre_Tbx.Text.ToUpper();
            usuario.ApellidoPaterno = apellidoPaterno_Tbx.Text.ToUpper();
            usuario.ApellidoMaterno = ApellidoMaterno_Tbx.Text.ToUpper();
            usuario.Genero = genero_Cbx.SelectedItem.ToString().ToUpper();
            usuario.DireccionParticular = direccion_Tbx.Text.ToUpper();
            usuario.FechaDeNacimiento = fechaDeNacimiento_Calendar.SelectionStart;
            usuario.IdDeNivel = "003";
            usuario.Permisos = "Usuario".ToUpper();
            usuario.Edad = fechaDeNacimiento_Calendar.TodayDate.Year - usuario.FechaDeNacimiento.Year;
            usuario.CrearRFC();


            System.Data.OleDb.OleDbConnection oleDbConnection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0.;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb");
            /*
             * @"Data Source= C:\Users\user\source\repos\Control-Bibliotecario\Control Bibliotecario\Control Bibliotecario\BD\Biblioteca.mdb"
             * Podemos obtener la ruta completa de acceso del Archivo .mdb para hacer modificaciones directas
             * PROBLEMA: LA RUTA DE ACCESO AL ARCHIVO PUEDE DIFERIR DE A MAQUINA A MAQUINA 
             * BUSCAR POSIBLE SOLUCION ?
            */

            oleDbConnection.Open();

            /*
             * TO DO: Valiadcion de Registro de Usuario ya existentes
             * Utilizar acción SELECT para obtener lo datos
             */

            string lineComando = "insert into Usuarios (RFC, IdDeNivel, Nombre, ApellidoPaterno, ApellidoMaterno, FechaDeNacimiento, Edad, Genero, DireccionParticular) values (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(lineComando, oleDbConnection);

            cmd.Parameters.AddWithValue("RFC", usuario.RFC);
            cmd.Parameters.AddWithValue("IdDeNivel", usuario.IdDeNivel);
            cmd.Parameters.AddWithValue("Nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("ApellidoPaterno", usuario.ApellidoPaterno);
            cmd.Parameters.AddWithValue("ApellidoMaterno", usuario.ApellidoMaterno);
            cmd.Parameters.AddWithValue("FechaDeNacimiento", usuario.FechaDeNacimiento);
            cmd.Parameters.AddWithValue("Edad", usuario.Edad);
            cmd.Parameters.AddWithValue("Genero", usuario.Genero);
            cmd.Parameters.AddWithValue("DireccionParticular", usuario.DireccionParticular);

            cmd.ExecuteNonQuery();
            oleDbConnection.Close();



        }

  
    }
}
