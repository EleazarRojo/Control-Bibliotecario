
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Control_Bibliotecario.UI;

/*
 * Añadir un campo donde se muestren los datos del usuario al ingresar la
 * ID de usuario, evitando de esta manera un nuevo Form y manejarlo al estilo
 * del control de la biblioteca del ITH.
 * 
 * Añadir tambien botones de prestamo o mas detalles con el campo Enable = false
 * para de esta manera que el usuario no puedo presionarlos hazta que se introduzca
 * un UserID valido.
 */

namespace Control_Bibliotecario
{
    public partial class IngresarForm : Form
    {
        public string Nombre { get; set; }
        public string IdUsuario { get; set; }

        public string IdNivel { get; set; }

        public bool acceso = false;

        public IngresarForm()
        {
            InitializeComponent();
        }

        private void IngresarForm_Load(object sender, System.EventArgs e)
        {

        }

        private void acceder_btn_Click(object sender, System.EventArgs e)
        {
            /*
             * Agregar verificación previa del usario con su ID en el primer click
             *Mostrar los datos del usuario
             *Segundo click Realizar el ingreso
             *Cerrar ventana Automaticamente
             */
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0.;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string consulta = "SELECT * FROM Usuarios WHERE IdUsuario LIKE " + idUsuario_tbx.Text;
            
            System.Data.OleDb.OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = direccion;
            conexion.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
            adaptador.Fill(ds);
            DataTable tablaDatos = ds.Tables[0];
            if (tablaDatos.Rows.Count > 0)
            {
                if (tablaDatos.Rows[0].ItemArray[2].ToString() == "003")
                {
                    nombre_tbx.Text = tablaDatos.Rows[0].ItemArray[3].ToString(); 
                    apellidoPaterno_tbx.Text  = tablaDatos.Rows[0].ItemArray[4].ToString();
                    apellidoMaterno_tbx.Text = tablaDatos.Rows[0].ItemArray[5].ToString();
                    Nombre = nombre_tbx.Text;
                    IdUsuario = idUsuario_tbx.Text;
                    IdNivel = "003";

                    nombre_lbl.Visible = true;
                    nombre_tbx.Visible = true;
                    apellidoPaterno_lbl.Visible = true;
                    apellidoPaterno_tbx.Visible = true;
                    apellidoMaterno_tbx.Visible = true;
                    apellidoMaterno_lbl.Visible = true;
                    apellidoMaterno_tbx.Visible = true;



                      
                    if (acceso)
                    {
                    IdUsuario = idUsuario_tbx.Text;
                    DialogResult = DialogResult.OK;

                        nombre_lbl.Visible = false;
                        nombre_tbx.Visible = false;
                        apellidoPaterno_lbl.Visible = false;
                        apellidoMaterno_tbx.Visible = false;
                        apellidoMaterno_lbl.Visible = false;
                        apellidoMaterno_tbx.Visible = false;
                        this.Close();
                    }

                    acceso = true;
                    
                }
                else
                {
                    if (tablaDatos.Rows[0].ItemArray[2].ToString() == "010")
                    {
                        Nombre = tablaDatos.Rows[0].ItemArray[3].ToString();
                        IdUsuario = idUsuario_tbx.Text;
                        IdNivel = "010";
                        IngresoAdmin adminForma = new IngresoAdmin(IdUsuario,Nombre);
                        adminForma.Show();

                    }
                    else
                    {
                        if (tablaDatos.Rows[0].ItemArray[2].ToString() == "020")
                        {
                            Nombre = tablaDatos.Rows[0].ItemArray[3].ToString();
                            IdUsuario = idUsuario_tbx.Text;
                            IdNivel = "020";
                            IngresoAdmin adminForma = new IngresoAdmin(IdUsuario,Nombre);
                            adminForma.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario No registrado");
            }

            conexion.Close();


            
        }
    }
}
