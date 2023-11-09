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
            if (!string.IsNullOrEmpty(nombre_Tbx.Text) && !string.IsNullOrEmpty(apellidoPaterno_Tbx.Text) && !string.IsNullOrEmpty(ApellidoMaterno_Tbx.Text) && genero_Cbx.SelectedIndex >= 0 &&
                 !string.IsNullOrEmpty(direccion_Tbx.Text) && !string.IsNullOrEmpty(nombre_Tbx.Text) && fechaDeNacimiento_Calendar.SelectionStart != DateTime.Today)
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = nombre_Tbx.Text.ToUpper();
                usuario.ApellidoPaterno = apellidoPaterno_Tbx.Text.ToUpper();
                usuario.ApellidoMaterno = ApellidoMaterno_Tbx.Text.ToUpper();
                usuario.Genero = genero_Cbx.SelectedItem.ToString().ToUpper();
                usuario.DireccionParticular = direccion_Tbx.Text.ToUpper();
                usuario.FechaDeNacimiento = fechaDeNacimiento_Calendar.SelectionStart;
                usuario.IdDeNivel = "003"; //Todo usuario Común tiene este nivel de acceso.
                usuario.Permisos = "Usuario".ToUpper();
                usuario.Edad = fechaDeNacimiento_Calendar.TodayDate.Year - usuario.FechaDeNacimiento.Year;
                usuario.CrearRFC();


                System.Data.OleDb.OleDbConnection conexion = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0.;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb");
             

                conexion.Open();

                string consulta = "SELECT RFC FROM Usuarios WHERE RFC = " + "'" + usuario.RFC + "'";
                OleDbDataAdapter adapator = new OleDbDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adapator.Fill(dt);


                if (!(dt.Rows.Count > 0))
                {
                    string lineComando = "insert into Usuarios (RFC, IdDeNivel, Nombre, ApellidoPaterno, ApellidoMaterno, FechaDeNacimiento, Edad, Genero, DireccionParticular) values (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(lineComando, conexion);

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

                    MessageBox.Show("Usuario registrado exitosamente", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();


                }
                else
                {
                    MessageBox.Show("Usuario previamnte registrado", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                conexion.Close();

            }
            else
            {
                MessageBox.Show("LLene todos los campos correspondientes", "Informacion faltante", MessageBoxButtons.OK);
            }







        }


    }
}
