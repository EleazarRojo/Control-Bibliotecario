using System;
using System.Windows.Forms;

namespace Control_Bibliotecario
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm formaRegistro = new RegistroForm();

            formaRegistro.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarForm formaIngreso = new IngresarForm();

            formaIngreso.Show();
        }

        /*
         * El sistema de busqueda esta organizado por palabras clave, mas bien este puede estar distribuido de tal manera
         * que se controle el tipo de busqueda a travez de un comboBox. El cambio se puede generar de manera automatica o
         * de manera secuencial al presionar el boton de realizar Busqueda.
         */
    }
}
