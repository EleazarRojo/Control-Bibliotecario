 
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

            Nombre = nombre_tbx.Text;
            IdUsuario = idUsuario_tbx.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
