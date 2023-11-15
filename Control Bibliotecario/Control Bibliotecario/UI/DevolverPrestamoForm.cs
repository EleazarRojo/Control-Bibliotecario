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
    public partial class DevolverPrestamoForm : Form
    {
        int folioPrestamo;
        public DevolverPrestamoForm()
        {
            InitializeComponent();
        }

            

        private void DevolverPrestamoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.OrdenarPorActivo(this.bibliotecaDataSet.Prestamos);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Libros' Puede moverla o quitarla según sea necesario.
      

        }

        public void BuscarPrestamo()
        {
            if (idUsuario_tbx.TextLength != 0)
            {
                prestamosTableAdapter.OrdenarPrestamoEspecifico(this.bibliotecaDataSet.Prestamos, idUsuario_tbx.Text);
                string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
                string consulta = "SELECT * FROM Prestamos WHERE IdUsuario = " + "'" + idUsuario_tbx.Text + "'" + " AND (Estatus = 'Activo' OR Estatus = 'Vencido')";
                OleDbConnection conexion = new OleDbConnection();
                conexion.ConnectionString = direccion;
                conexion.Open();
                OleDbDataAdapter ada = new OleDbDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    

                    autor_tbx.Text = dt.Rows[0].ItemArray[4].ToString();
                    nombreLibro_tbx.Text = dt.Rows[0].ItemArray[3].ToString();
                    iSBN_tbx.Text = dt.Rows[0].ItemArray[2].ToString();
                    idCopia_tbx.Text = dt.Rows[0].ItemArray[8].ToString();
                    folioPrestamo = int.Parse(dt.Rows[0].ItemArray[1].ToString());

                    devolver_btn.Enabled = true;
                    devolver_btn.Visible = true;
                    spawn();
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("El Usuario no tiene prestamos para devolver", "Prestamo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar el campo de ISBN Para buscar un libro", "Campo Faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void spawn()
        {
            this.Size = new Size(847, 611);
          
            idCopia_lbl.Visible = true;
            idCopia_tbx.Visible = true;
            nombreLibro_lbl.Visible = true;
            nombreLibro_tbx.Visible = true;
            autor_lbl.Visible = true;
            autor_tbx.Visible = true;
            iSBN_lbl.Visible = true;
            iSBN_tbx.Visible = true;
            
        }

        public void dispawn()
        {
            this.Size = new Size(847, 397);
      
            idUsuario_tbx.Clear();
            idCopia_lbl.Visible = false;
            idCopia_tbx.Visible = false;
            idCopia_tbx.Clear();
            nombreLibro_lbl.Visible = false;
            nombreLibro_tbx.Visible = false;
            nombreLibro_tbx.Clear();
            autor_lbl.Visible = false;
            autor_tbx.Visible = false;
            autor_tbx.Clear();
            iSBN_lbl.Visible = false;
            iSBN_tbx.Visible = false;
            iSBN_tbx.Clear();

        }

        private void buscarPrestamo_btn_Click(object sender, EventArgs e)
        {
            BuscarPrestamo();
          
        }

        private void devolver_btn_Click(object sender, EventArgs e)
        {
            DevolverPrestamo();  
            devolver_btn.Enabled = false;
        }

        public void DevolverPrestamo()
        {

            if (!string.IsNullOrWhiteSpace(idUsuario_tbx.Text))
            {
                ActualizarLibro();
                ActualizarPrestamo();
                ActulizarUsuario();
                this.DialogResult = DialogResult.OK;
                this.Close();
               
            }
            else

            {
                MessageBox.Show("Favor de ingresar un Id de Usuario", "IdUsuario Faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            }

        public void ActualizarLibro()
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string actualizar = "UPDATE Libros SET EstadoPrestamo = 'Disponible' WHERE IdCopia = " + idCopia_tbx.Text;
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
            string actualizar = "UPDATE Usuarios SET Prestamo = " + 0 + " WHERE IdUsuario = " + idUsuario_tbx.Text;
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand actualizarLibro = new OleDbCommand(actualizar, conexion);
            conexion.ConnectionString = direccion;
            conexion.Open();
            actualizarLibro.ExecuteNonQuery();
            conexion.Close();
        }

        public void ActualizarPrestamo()
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string actualizar = "UPDATE Prestamos SET Estatus = 'Devuelto' WHERE Folio = " + folioPrestamo;
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand actualizarPrestamo = new OleDbCommand(actualizar, conexion);
            conexion.ConnectionString = direccion;
            conexion.Open();
            actualizarPrestamo.ExecuteNonQuery();
            conexion.Close();
        }

    }


    }





