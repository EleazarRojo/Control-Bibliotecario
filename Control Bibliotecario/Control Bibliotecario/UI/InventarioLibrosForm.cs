using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Control_Bibliotecario.UI
{
    public partial class InventarioLibrosForm : Form
    {
        public InventarioLibrosForm()
        {
            InitializeComponent();
        }


        private void InventarioLibrosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);

        }

        private void tipoBusqueda_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tipoBusqueda_CB.SelectedIndex)
            {
                case 0:
                    librosTableAdapter.OrdenarPorISBN(bibliotecaDataSet.Libros);
                    disspawn();
                    break;
                case 1:
                    librosTableAdapter.OrdenarPorIdCopia(bibliotecaDataSet.Libros);
                    disspawn();
                    break;
                case 2:
                    librosTableAdapter.OrdenarPorTitulo(bibliotecaDataSet.Libros);
                    disspawn();
                    break;
                case 3:
                    librosTableAdapter.OrdenarPorAutor(bibliotecaDataSet.Libros);
                    disspawn();
                    break;
                case 4:
                    librosTableAdapter.OrdenarPorAño(bibliotecaDataSet.Libros);
                    disspawn();
                    break;
                case 5:
                    librosTableAdapter.OrdenarPorISBN(bibliotecaDataSet.Libros);
                    spawn();
                    break;
                case 6:
                    librosTableAdapter.OrdenarPorIdCopia(bibliotecaDataSet.Libros);
                    spawn();
                    buscar_Tbx.Enabled = true;
                    buscar_Btn.Enabled = true;
                    agregar_Btn.Enabled = false;
                    break;
                case 7:
                    librosTableAdapter.OrdenarPorIdCopia(bibliotecaDataSet.Libros);
                    disspawn();
                    break;
            }
        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            switch (tipoBusqueda_CB.SelectedIndex)
            {
                case 0:
                    librosTableAdapter.OrdenarPorISBNEspecifico(bibliotecaDataSet.Libros, "%" + buscar_Tbx.Text + "%");
                    break;
                case 1:
                    librosTableAdapter.OrdenarPorIdCopiaEspecifico(bibliotecaDataSet.Libros, int.Parse(buscar_Tbx.Text));
                    break;
                case 2:
                    librosTableAdapter.OrdenarPorTituloEspecifico(bibliotecaDataSet.Libros, "%" + buscar_Tbx.Text + "%");
                    break;
                case 3:
                    librosTableAdapter.OrdenarPorAutorEspecifico(bibliotecaDataSet.Libros, "%" + buscar_Tbx.Text + "%");
                    break;
                case 4:
                    librosTableAdapter.OrdenarPorAñoEspecifico(bibliotecaDataSet.Libros, "%" + buscar_Tbx.Text + "%");
                    break;
                case 5:
                    break;
                case 6://[Proceso de Modificación] Para modificar el libro se requerira de buscar el libro deseado y al presionar buscar se desplegara la información del libro y un boton de modificar//
                    busqueda();
                    break;
                case 7:
                    librosTableAdapter.OrdenarPorIdCopiaEspecifico(bibliotecaDataSet.Libros, int.Parse(buscar_Tbx.Text));
                    buscar_Tbx.Enabled = false;
                    eliminar_Btn.Enabled = true;
                    break;
            }
        }

        public void disspawn()
        {
            modificar_Btn.Visible = false;
            buscar_Tbx.Enabled = true;
            buscar_Btn.Enabled = true;
            buscar_Tbx.Clear();
            this.Size = new Size(941, 590);
            ISBN_Lbl.Visible = false;
            ISBN_Tbx.Visible = false;
            titulo_Lbl.Visible = false;
            titulo_Tbx.Visible = false;
            autor_Lbl.Visible = false;
            autor_Tbx.Visible = false;
            numEdicion_Lbl.Visible = false;
            numEdicion_Tbx.Visible = false;
            year_Lbl.Visible = false;
            year_Tbx.Visible = false;
            tema_Lbl.Visible = false;
            tema_Tbx.Visible = false;
            agregar_Btn.Visible = false;
            eliminar_Btn.Enabled = false;
        }

        public void spawn()
        {
            modificar_Btn.Visible = true;
            buscar_Tbx.Enabled = false;
            buscar_Btn.Enabled = false;
            this.Size = new Size(941, 710);
            ISBN_Lbl.Visible = true;
            ISBN_Tbx.Visible = true;
            titulo_Lbl.Visible = true;
            titulo_Tbx.Visible = true;
            autor_Lbl.Visible = true;
            autor_Tbx.Visible = true;
            numEdicion_Lbl.Visible = true;
            numEdicion_Tbx.Visible = true;
            year_Lbl.Visible = true;
            year_Tbx.Visible = true;
            tema_Lbl.Visible = true;
            tema_Tbx.Visible = true;
            agregar_Btn.Visible = true;
        }

        public void busqueda()
        {
            if(buscar_Tbx.TextLength != 0)
            {
                librosTableAdapter.OrdenarPorIdCopiaEspecifico(bibliotecaDataSet.Libros, int.Parse(buscar_Tbx.Text));
                string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
                string consulta = "SELECT * FROM Libros WHERE IdCopia = " +buscar_Tbx.Text;
                OleDbConnection conexion = new OleDbConnection();
                conexion.ConnectionString = direccion;
                conexion.Open();
                OleDbDataAdapter ada = new OleDbDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                if(dt.Rows.Count != 0)
                {
                    ISBN_Tbx.Text = dt.Rows[0].ItemArray[0].ToString();
                    titulo_Tbx.Text = dt.Rows[0].ItemArray[1].ToString();
                    autor_Tbx.Text = dt.Rows[0].ItemArray[2].ToString();
                    numEdicion_Tbx.Text = dt.Rows[0].ItemArray[3].ToString();
                    year_Tbx.Text = dt.Rows[0].ItemArray[4].ToString();
                    tema_Tbx.Text = dt.Rows[0].ItemArray[5].ToString();
                    modificar_Btn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el libro buscado", "Búsqueda de Libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar el cambo de Búsqueda", "Búsqueda de Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregar_Btn_Click(object sender, EventArgs e)
        {
            if(ISBN_Tbx.TextLength != 0 && titulo_Tbx.TextLength != 0 && autor_Tbx.TextLength != 0 && numEdicion_Tbx.TextLength != 0 && year_Tbx.TextLength != 0 && tema_Tbx.TextLength != 0)
            {
                string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
                string insertar = "INSERT INTO Libros (ISBN, Titulo, Autor, NumeroEdicion, Año, Tema, EstadoPrestamo) VALUES (?, ?, ?, ?, ?, ?, ?)";
                OleDbConnection conexion = new OleDbConnection();
                conexion.ConnectionString = direccion;
                conexion.Open();
                OleDbCommand ins = new OleDbCommand(insertar, conexion);

                ins.Parameters.AddWithValue("ISBN", long.Parse(ISBN_Tbx.Text));
                ins.Parameters.AddWithValue("Titulo", titulo_Tbx.Text);
                ins.Parameters.AddWithValue("Autor", autor_Tbx.Text);
                ins.Parameters.AddWithValue("NumeroEducion", numEdicion_Tbx.Text);
                ins.Parameters.AddWithValue("Año", year_Tbx.Text);
                ins.Parameters.AddWithValue("Tema", tema_Tbx.Text);
                ins.Parameters.AddWithValue("EstadoPrestamo", "Disponible");

                ins.ExecuteNonQuery();

                MessageBox.Show("El libro ha sido agregado exitosamente", "Libro Agregado");

                conexion.Close();
                this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);
            }
            else
            {
                MessageBox.Show("Complete todos los campos requeridos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminar_Btn_Click(object sender, EventArgs e)
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string consulta = "SELECT * FROM Libros WHERE IdCopia = " + buscar_Tbx.Text;
            string delete = "DELETE * FROM Libros WHERE IdCopia = " + buscar_Tbx.Text;
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = direccion;
            OleDbDataAdapter ada = new OleDbDataAdapter(consulta, conexion);
            conexion.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                OleDbCommand cmd = new OleDbCommand(delete, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el Libro Exitosamente", "Eliminación de Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);
                tipoBusqueda_CB.Text = "Tipo de Búsqueda";
            }
            else
            {
                MessageBox.Show("No se ha encontrado el Libro", "Eliminación de Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        private void modificar_Btn_Click(object sender, EventArgs e)
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string update = "UPDATE Libros SET ISBN = '" +ISBN_Tbx.Text +"', Titulo = '"+ titulo_Tbx.Text +"', Autor = '"+autor_Tbx.Text+"', NumeroEdicion = "+numEdicion_Tbx.Text+", Año = "+year_Tbx.Text+", Tema = '"+tema_Tbx.Text+"'  WHERE IdCopia = " + buscar_Tbx.Text;
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = direccion;
            conexion.Open();

            OleDbCommand cmd = new OleDbCommand(update, conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha modificado el libro con exito", "Modificación de Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);

            conexion.Close();
        }
    }
}
