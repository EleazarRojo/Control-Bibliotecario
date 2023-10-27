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

        private void tipoBusqueda_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tipoBusqueda_CB.SelectedIndex)
            {
                case 0:
                    
                    break;
                case 1:
                    break;
                case 2:
               
                    break;
            }
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Libros' table. You can move, or remove it, as needed.
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);

        }

        /*
         * El sistema de busqueda esta organizado por palabras clave, mas bien este puede estar distribuido de tal manera
         * que se controle el tipo de busqueda a travez de un comboBox. El cambio se puede generar de manera automatica o
         * de manera secuencial al presionar el boton de realizar Busqueda.
         */


    }
}
