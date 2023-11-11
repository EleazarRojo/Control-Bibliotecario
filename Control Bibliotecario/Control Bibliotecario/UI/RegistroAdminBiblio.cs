using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Bibliotecario.Modelos;
using System.Data.OleDb;

namespace Control_Bibliotecario.UI
{
    public partial class RegistroAdminBiblio : Form
    {
        public RegistroAdminBiblio()
        {
            InitializeComponent();
        }

        private void registrar_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombre_Tbx.Text) && !string.IsNullOrEmpty(apellidoPaterno_Tbx.Text) && !string.IsNullOrEmpty(ApellidoMaterno_Tbx.Text) && genero_Cbx.SelectedIndex >= 0 &&
              !string.IsNullOrEmpty(direccion_Tbx.Text) && !string.IsNullOrEmpty(nombre_Tbx.Text) && fechaDeNacimiento_Calendar.SelectionStart != DateTime.Today && !string.IsNullOrEmpty(contrasenia_tbx.Text))
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = nombre_Tbx.Text.ToUpper();
                usuario.ApellidoPaterno = apellidoPaterno_Tbx.Text.ToUpper();
                usuario.ApellidoMaterno = ApellidoMaterno_Tbx.Text.ToUpper();
                usuario.Genero = genero_Cbx.SelectedItem.ToString().ToUpper();
                usuario.DireccionParticular = direccion_Tbx.Text.ToUpper();
                usuario.FechaDeNacimiento = fechaDeNacimiento_Calendar.SelectionStart;

                switch (tipoUsuario_Cbx.SelectedIndex)
                {
                    case 0:
                        usuario.IdDeNivel = "010";
                        break;

                    case 1:
                        usuario.IdDeNivel = "020";
                        break;

                    default:
                        MessageBox.Show("Seleccione el tipo de usuario");
                        break;
                }

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
                    string lineComando = "INSERT INTO Usuarios (RFC, IdDeNivel, Nombre, ApellidoPaterno, ApellidoMaterno, FechaDeNacimiento, Edad, Genero, DireccionParticular, Contrasenia, Prestamo) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
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
                    cmd.Parameters.AddWithValue("Contrasenia", contrasenia_tbx.Text);
                    cmd.Parameters.AddWithValue("Prestamo", 0);
                    cmd.ExecuteNonQuery();

                    string consultaUsuario = "SELECT IdUsuario FROM Usuarios WHERE RFC = " + "'" + usuario.RFC + "'";
                    OleDbDataAdapter ada = new OleDbDataAdapter(consultaUsuario, conexion);
                    DataTable usuarioTabla = new DataTable();

                    ada.Fill(usuarioTabla);

                    MessageBox.Show("Usuario registrado exitosamente\n" + "ID de Usuario: " + usuarioTabla.Rows[0].ItemArray[0].ToString(), "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;



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
