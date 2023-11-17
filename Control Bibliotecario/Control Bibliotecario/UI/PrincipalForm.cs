using System;
using System.Windows.Forms;
using System.Drawing;
using Control_Bibliotecario.UI;
using System.Data;
using System.Data.OleDb;


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

            if (FormaIngreso.ShowDialog() == DialogResult.OK)
            {
                if (FormaIngreso.IdNivel == "003") //Usuario
                {
                   
                    usuarioToolStripMenuItem.Text = FormaIngreso.Nombre;
                    usuarioToolStripMenuItem.Visible = true;
                    ingresoToolStripMenuItem.Visible = false;
                    registrarseToolStripMenuItem.Visible = false;
            
                }
                else
                {
                    if (FormaIngreso.IdNivel == "010") // Administración
                    {
                        ingresoToolStripMenuItem.Visible = false;
                        registrarseToolStripMenuItem.Visible = false;
                 
                        usuarioToolStripMenuItem.Text = FormaIngreso.Nombre;
                        usuarioToolStripMenuItem.Visible = true;
                        controlDeUsuariosToolStripMenuItem.Visible = true;
                        controlDePrestamosToolStripMenuItem.Visible = true;
                        inventarioDeLibrosToolStripMenuItem.Visible = true;
                        prestamosToolStripMenuItem.Visible = true;

                    }
                    else
                    {
                        if (FormaIngreso.IdNivel == "020") // Bibliotecarios
                        {
                            ingresoToolStripMenuItem.Visible = false;
                            registrarseToolStripMenuItem.Visible = false;
                       
                            usuarioToolStripMenuItem.Text = FormaIngreso.Nombre;
                            usuarioToolStripMenuItem.Visible = true;
                            controlDePrestamosToolStripMenuItem.Visible = true;
                            inventarioDeLibrosToolStripMenuItem.Visible = true;
                        }
                    }

                }



                IdUsuario = FormaIngreso.IdUsuario;



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
            ActualizarPrestamos();

        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            if (tipoBusqueda_CB.SelectedIndex >= 0)
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
                MessageBox.Show("Favor de Seleccionar un Tipo de Búsqueda");
            }
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlDeUsuariosForm formControlDeUsuarios = new ControlDeUsuariosForm();
            formControlDeUsuarios.Show();
        }

        private void controlDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlDePrestamos formControlDePrestamos = new ControlDePrestamos();

            formControlDePrestamos.Show();
        }

        private void inventarioDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioLibrosForm formInventarioLibros = new InventarioLibrosForm();
            formInventarioLibros.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialDePrestamosForm formHistorialPrestamos = new HistorialDePrestamosForm(IdUsuario);
            formHistorialPrestamos.Show();

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoToolStripMenuItem.Visible = true;
            registrarseToolStripMenuItem.Visible = true;

            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.Visible = false;
            controlDePrestamosToolStripMenuItem.Visible = false;
            inventarioDeLibrosToolStripMenuItem.Visible = false;
            controlDeUsuariosToolStripMenuItem.Visible = false;

            IdUsuario = "";


        }

        public void ActualizarPrestamos()
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";

            string consulta = "SELECT * FROM Prestamos WHERE Estatus = 'Activo'";
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = direccion;
            conexion.Open();
            OleDbDataAdapter ada = new OleDbDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            ada.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (DateTime.Parse(dt.Rows[i].ItemArray[6].ToString()) < DateTime.Today)
                    {

                        string actualizar = "UPDATE Prestamos SET Estatus = 'Vencido' WHERE Folio = " + dt.Rows[i].ItemArray[1];

                        OleDbCommand actualizarLibro = new OleDbCommand(actualizar, conexion);
                       

                        actualizarLibro.ExecuteNonQuery();
                    }

                }
            }

            conexion.Close();

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaForm ayuda = new AyudaForm();
            ayuda.Show();
        }

        /*
         * El sistema de busqueda esta organizado por palabras clave, mas bien este puede estar distribuido de tal manera
         * que se controle el tipo de busqueda a travez de un comboBox. El cambio se puede generar de manera automatica o
         * de manera secuencial al presionar el boton de realizar Busqueda.
         */


    }
}
