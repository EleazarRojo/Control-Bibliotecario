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
    public partial class RealizarPrestamoForm : Form
    {
        public RealizarPrestamoForm()
        {
            InitializeComponent();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void RealizarPrestamoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.OrdenarPorDisponible(this.bibliotecaDataSet.Libros);

        }

        private void buscarLibro_btn_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void realizarPresatamo_btn_Click(object sender, EventArgs e)
        {
            RealizarPrestamo();
            this.librosTableAdapter.OrdenarPorDisponible(this.bibliotecaDataSet.Libros);

        }

        public void busqueda()
        {
            if (iSBN_tbx.TextLength != 0)
            {
                librosTableAdapter.OrdenarPorISBNEspecifico(bibliotecaDataSet.Libros, iSBN_tbx.Text);
                string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
                string consulta = "SELECT * FROM Libros WHERE ISBN = " + "'" + iSBN_tbx.Text + "'" + " AND EstadoPrestamo = " + "'Disponible'";
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
                        idCopia_Cbx.Items.Add(dt.Rows[i].ItemArray[6].ToString());
                    }

                    autor_tbx.Text = dt.Rows[0].ItemArray[2].ToString();
                    nombreLibro_tbx.Text = dt.Rows[0].ItemArray[1].ToString();


                    realizarPresatamo_btn.Enabled = true;
                    realizarPresatamo_btn.Visible = true;
                    spawn();
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el libro solicitado", "Búsqueda de Libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar el campo de ISBN Para buscar un libro", "Búsqueda de Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void spawn()
        {
            this.Size = new Size(880, 530);
            idUsario_lbl.Visible = true;
            idUsuario_tbx.Visible = true;
            idUsuario_tbx.Enabled = true;
            idCopia_lbl.Visible = true;
            idCopia_Cbx.Visible = true;
            nombreLibro_lbl.Visible = true;
            nombreLibro_tbx.Visible = true;
            autor_lbl.Visible = true;
            autor_tbx.Visible = true;


        }

        public void dispawn()
        {
            this.Size = new Size(880, 350);
            idUsario_lbl.Visible = false;
            idUsuario_tbx.Clear();
            idUsuario_tbx.Visible = false;
            idUsuario_tbx.Enabled = false;
            idCopia_lbl.Visible = false;
            idCopia_Cbx.Visible = false;
            idCopia_Cbx.Items.Clear();
            nombreLibro_lbl.Visible = false;
            nombreLibro_tbx.Visible = false;
            nombreLibro_tbx.Clear();
            autor_lbl.Visible = false;
            autor_tbx.Visible = false;
            autor_tbx.Clear();
            iSBN_tbx.Clear();

        }



        public void ActualizarLibro()
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string actualizar = "UPDATE Libros SET EstadoPrestamo = 'Prestado' WHERE IdCopia = " + idCopia_Cbx.Text;
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand actualizarLibro = new OleDbCommand(actualizar, conexion);
            conexion.ConnectionString = direccion;
            conexion.Open();
            actualizarLibro.ExecuteNonQuery();
            conexion.Close();

        }

        public void ActulizarUsuario()
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string actualizar = "UPDATE Usuarios SET Prestamo = " + 1 + " WHERE IdUsuario = " + idUsuario_tbx.Text;
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand actualizarLibro = new OleDbCommand(actualizar, conexion);
            conexion.ConnectionString = direccion;
            conexion.Open();
            actualizarLibro.ExecuteNonQuery();
            conexion.Close();
        }

        public void RealizarPrestamo()
        {
            if (idCopia_Cbx.SelectedIndex >= 0)
            {
                if (!string.IsNullOrWhiteSpace(idUsuario_tbx.Text))
                {
                    string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
                    string consulta = "SELECT * FROM Usuarios WHERE IdUsuario = " + idUsuario_tbx.Text;
                    OleDbConnection conexion = new OleDbConnection();
                    conexion.ConnectionString = direccion;
                    conexion.Open();
                    OleDbDataAdapter ada = new OleDbDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        if (int.Parse(dt.Rows[0].ItemArray[10].ToString())  == 0)
                        {
                            string insertarPrestamo = "INSERT INTO Prestamos (IdUsuario, ISBN, Titulo, Autor, FechaInicial, FechaDevolucion, Estatus, IdCopia) VALUES (?,?,?,?,?,?,?,?)";
                            OleDbCommand cmd = new OleDbCommand(insertarPrestamo, conexion);
                            cmd.Parameters.AddWithValue("IdUsuario", idUsuario_tbx.Text);
                            cmd.Parameters.AddWithValue("ISBN", iSBN_tbx.Text);
                            cmd.Parameters.AddWithValue("Titulo", nombreLibro_tbx.Text);
                            cmd.Parameters.AddWithValue("Autor", autor_tbx.Text);
                            cmd.Parameters.AddWithValue("FechaInicial", DateTime.Today);
                            cmd.Parameters.AddWithValue("FechaDevolucion", DateTime.Today.AddDays(7));
                            cmd.Parameters.AddWithValue("Estatus", "Activo");
                            cmd.Parameters.AddWithValue("IdCopia", idCopia_Cbx.Text);

                            cmd.ExecuteNonQuery();

                            ActualizarLibro();
                            ActulizarUsuario();
                            dispawn();
                            conexion.Close();
                            this.DialogResult = DialogResult.OK;

                            MessageBox.Show("Prestamo realizado con éxito", "Prestamo exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El Usuario cuenta con un prestamo Activo", "Prestamo Activo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dispawn();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Usuario válido", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else

                { 
                    MessageBox.Show("Favor de ingresar un Id de Usuario", "Id de Usuario Faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Favor de seleccionar una copia del libro libro", "Prestamo de libros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }



}
