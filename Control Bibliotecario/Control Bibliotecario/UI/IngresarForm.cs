using System.Windows.Forms;
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
        public IngresarForm()
        {
            InitializeComponent();
        }
    }
}
