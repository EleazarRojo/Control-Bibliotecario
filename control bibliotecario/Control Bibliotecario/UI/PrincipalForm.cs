using System;
using System.Windows.Forms;
using System.Drawing;

namespace Control_Bibliotecario
{
    public partial class PrincipalForm : Form
    {
        public string IdUsuario { get; set; }

        IngresarForm FormaIngreso;

        public PrincipalForm()
        {
            InitializeComponent();
            usuarioToolStripMenuItem.Visible = false;
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm formaRegistro = new RegistroForm();

            formaRegistro.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        FormaIngreso = new IngresarForm();

            if(FormaIngreso.ShowDialog() == DialogResult.OK)
            {
                Label bienvenido_Lbl = new Label();
                bienvenido_Lbl.AutoSize = true;
                bienvenido_Lbl.Location = new Point(557, 49);
                bienvenido_Lbl.Text = "Bienvenido " + FormaIngreso.Nombre;
                usuarioToolStripMenuItem.Text = FormaIngreso.Nombre;
                usuarioToolStripMenuItem.Visible = true;
                ingresoToolStripMenuItem.Visible = false;
                registrarseToolStripMenuItem.Visible = false;

                IdUsuario = FormaIngreso.IdUsuario;

                    
                this.Controls.Add(bienvenido_Lbl);
            }
        }

        private void tipoBusqueda_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tipoBusqueda_CB.SelectedIndex)
            {
                case 0:
                    librosTableAdapter.OrdenarPorISBN(bibliotecaDataSet.Libros);
                    break;
                case 1:
                    librosTableAdapter.OrdenarPorTitulo(bibliotecaDataSet.Libros);
                    break;
                case 2:
                    librosTableAdapter.OrdenarPorAutor(bibliotecaDataSet.Libros);
                    break;
                case 3:
                    librosTableAdapter.OrdenarPorTema(bibliotecaDataSet.Libros);
               
                    break;
                case 4:
                    librosTableAdapter.OrdenarPorAño(bibliotecaDataSet.Libros);
                    break;
            }
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Libros' table. You can move, or remove it, as needed.
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);

        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            if(tipoBusqueda_CB.SelectedIndex >= 0)
            {
                switch (tipoBusqueda_CB.SelectedIndex)
                {
                    case 0:
                        librosTableAdapter.OrdenarPorISBNEspecifico(bibliotecaDataSet.Libros, "%" + busqueda_Tbx.Text + "%");
                        break;
                    case 1:
                        librosTableAdapter.OrdenarPorTituloEspecifico(bibliotecaDataSet.Libros, "%" + busqueda_Tbx.Text + "%");
                        break;
                    case 2:
                        librosTableAdapter.OrdenarPorAutorEspecifico(bibliotecaDataSet.Libros, "%" + busqueda_Tbx.Text + "%");
                        break;
                    case 3:
                        librosTableAdapter.OrdenarPorTemaEspecifico(bibliotecaDataSet.Libros, "%" + busqueda_Tbx.Text + "%");
                        break;
                    case 4:
                        librosTableAdapter.OrdenarPorAñoEspecifico(bibliotecaDataSet.Libros, "%" + busqueda_Tbx.Text + "%");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Favor de Seleccionar un Tipo de Busqueda");
            }
        }

        /*
         * El sistema de busqueda esta organizado por palabras clave, mas bien este puede estar distribuido de tal manera
         * que se controle el tipo de busqueda a travez de un comboBox. El cambio se puede generar de manera automatica o
         * de manera secuencial al presionar el boton de realizar Busqueda.
         */


    }
}
