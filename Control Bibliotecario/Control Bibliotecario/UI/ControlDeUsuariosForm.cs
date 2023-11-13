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
    public partial class ControlDeUsuariosForm : Form
    {

        public ControlDeUsuariosForm()
        {
            InitializeComponent();
            disspawn();

        }

        private void VistaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bibliotecaDataSet.Usuarios);

        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            if (buscar_Tbx.Text == "" || tipoDeBusqueda_Cbx.Text == "Seleccione tipo de búsqueda")
            {
                MessageBox.Show("Favor de llenar todos los partados correctamente", "Busqueda de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (tipoDeBusqueda_Cbx.SelectedIndex)
            {
                case 0:
                    if (buscar_Tbx.Text == "")
                    {
                        MessageBox.Show("Favor de llenar todos los partados correctamente", "Busqueda de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    usuariosTableAdapter.OrdenarPorIdUsuarioEspecifico(bibliotecaDataSet.Usuarios, int.Parse(buscar_Tbx.Text));


                    break;
                case 1:
                    if (buscar_Tbx.Text == "")
                    {
                        MessageBox.Show("Favor de llenar todos los partados correctamente", "Busqueda de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    usuariosTableAdapter.OrdenarPorRFCEspecifico(bibliotecaDataSet.Usuarios, buscar_Tbx.Text);


                    break;
                case 2:
                    if (buscar_Tbx.Text == "")
                    {
                        MessageBox.Show("Favor de llenar todos los partados correctamente", "Busqueda de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    usuariosTableAdapter.OrdenarPorIdUsuarioEspecifico(bibliotecaDataSet.Usuarios, int.Parse(buscar_Tbx.Text));
                    eliminar_Btn.Enabled = true;

                    break;

                case 3:
                    if (buscar_Tbx.Text == "" || tipoDeBusqueda_Cbx.Text == "Seleccione tipo de búsqueda")
                    {
                        MessageBox.Show("Favor de llenar todos los partados correctamente", "Busqueda de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
                    string consulta = "SELECT * FROM Usuarios WHERE IdUsuario = " + buscar_Tbx.Text;
                    OleDbConnection conexion = new OleDbConnection();
                    conexion.ConnectionString = direccion;
                    OleDbDataAdapter ada = new OleDbDataAdapter(consulta, conexion);
                    conexion.Open();
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    spawn();
                   

                    if (dt.Rows.Count != 0)
                    {
                        idUsuario_tbx.Text = dt.Rows[0].ItemArray[0].ToString();
                        rFC_tbx.Text = dt.Rows[0].ItemArray[1].ToString();
                        idNivel_Cbx.Text = dt.Rows[0].ItemArray[2].ToString();
                        nombre_tbx.Text = dt.Rows[0].ItemArray[3].ToString();
                        apellidoPaterno_tbx.Text = dt.Rows[0].ItemArray[4].ToString();
                        apellidoMaterno_tbx.Text = dt.Rows[0].ItemArray[5].ToString();
                        fechaDeNacimiento_tbx.Text = DateTime.Parse(dt.Rows[0].ItemArray[6].ToString()).ToShortDateString();
                        edad_tbx.Text = dt.Rows[0].ItemArray[7].ToString();
                        genero_tbx.Text = dt.Rows[0].ItemArray[8].ToString();
                        direccion_tbx.Text = dt.Rows[0].ItemArray[9].ToString();
                        contraseña_tbx.Text = dt.Rows[0].ItemArray[11].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No se a encontrado el usuario buscado", "Busqueda de Libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;
            }
        }

        private void tipoDeBusqueda_Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tipoDeBusqueda_Cbx.SelectedIndex)
            {
                case 0:
                    disspawn();
                    usuariosTableAdapter.OrdenarPorIdUsuario(bibliotecaDataSet.Usuarios);
                    break;
                case 1:
                    disspawn();
                    usuariosTableAdapter.OrdenarPorRFC(bibliotecaDataSet.Usuarios);
                    break;
                case 2:
                    disspawn();
                    usuariosTableAdapter.OrdenarPorIdUsuario(bibliotecaDataSet.Usuarios);
                    break;
                case 3:

                    usuariosTableAdapter.OrdenarPorIdUsuario(bibliotecaDataSet.Usuarios);
                    break;
            }
        }

        public void disspawn()
        {
            this.Size = new Size(999, 710);
            IdUsuario_lbl.Visible = false;
            idUsuario_tbx.Visible = false;
            rFC_lbl.Visible = false;
            rFC_tbx.Visible = false;
            idNivel_lbl.Visible = false;
            nombre_lbl.Visible = false;
            nombre_tbx.Visible = false;
            apellidoPaterno_lbl.Visible = false;
            apellidoPaterno_tbx.Visible = false;
            apellidoMaterno_lbl.Visible = false;
            apellidoMaterno_tbx.Visible = false;
            fechaDeNacimiento_lbl.Visible = false;
            fechaDeNacimiento_tbx.Visible = false;
            edad_lbl.Visible = false;
            edad_tbx.Visible = false;
            genero_lbl.Visible = false;
            genero_tbx.Visible = false;
            aceptarModificacion_btn.Visible = false;

            regresar_btn.Visible = false;


        }
        public void spawn()
        {
            this.Size = new Size(999, 850);
            IdUsuario_lbl.Visible = true;
            idUsuario_tbx.Visible = true;
            rFC_lbl.Visible = true;
            rFC_tbx.Visible = true;
            idNivel_lbl.Visible = true;
            nombre_lbl.Visible = true;
            nombre_tbx.Visible = true;
            apellidoPaterno_lbl.Visible = true;
            apellidoPaterno_tbx.Visible = true;
            apellidoMaterno_lbl.Visible = true;
            apellidoMaterno_tbx.Visible = true;
            fechaDeNacimiento_lbl.Visible = true;
            fechaDeNacimiento_tbx.Visible = true;
            edad_lbl.Visible = true;
            edad_tbx.Visible = true;
            genero_lbl.Visible = true;
            genero_tbx.Visible = true;
            aceptarModificacion_btn.Visible = true;

            regresar_btn.Visible = true;
        }

        public void borrarDatosDeLosTextBox()
        {
            idUsuario_tbx.Text = "";
            rFC_tbx.Text = "";
            nombre_tbx.Text = "";
            apellidoPaterno_tbx.Text = "";
            apellidoMaterno_tbx.Text = "";
            fechaDeNacimiento_tbx.Text = "";
            edad_tbx.Text = "";
            genero_tbx.Text = "";

        }

        private void eliminar_Btn_Click(object sender, EventArgs e)
        {
            string direccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Biblioteca.mdb";
            string consulta = "SELECT * FROM Usuarios WHERE IdUsuario = " + buscar_Tbx.Text;
            string delete = "DELETE * FROM Usuarios WHERE IdUsuario = " + buscar_Tbx.Text; //Correción de string [DELET --> DELETE] e [Id Usuario --> IdUsuario]
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
                MessageBox.Show("Se ha eliminado al Usuario", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.usuariosTableAdapter.OrdenarPorIdUsuario(bibliotecaDataSet.Usuarios);
                buscar_Tbx.Clear();
                tipoDeBusqueda_Cbx.Text = "Seleccione tipo de búsqueda";
            }
            else
            {
                MessageBox.Show("No se ha encontrado al Usuario", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm registrarForm = new RegistroForm();

            if (registrarForm.ShowDialog() == DialogResult.OK)
            {
                this.usuariosTableAdapter.Fill(this.bibliotecaDataSet.Usuarios);
            }


        }

        private void registrarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAdminBiblio registrarColabForm = new RegistroAdminBiblio();

            if (registrarColabForm.ShowDialog() == DialogResult.OK)
            {
                this.usuariosTableAdapter.Fill(this.bibliotecaDataSet.Usuarios);
            }




        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            spawn();

        }

        private void aceptarModificacion_btn_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.modificarUsuario(rFC_tbx.Text, idNivel_Cbx.Text, nombre_tbx.Text, apellidoPaterno_tbx.Text,
                apellidoMaterno_tbx.Text, Convert.ToDateTime(fechaDeNacimiento_tbx.Text.ToString()), Convert.ToInt32(edad_tbx.Text), genero_tbx.Text,
                direccion_tbx.Text,contraseña_tbx.Text, Convert.ToInt32(idUsuario_tbx.Text));
            this.usuariosTableAdapter.Fill(bibliotecaDataSet.Usuarios);
            MessageBox.Show("¡Modificacion exitosa!", "Control de usuraios", MessageBoxButtons.OK);
            disspawn();
        }

        private void regresar_btn_Click(object sender, EventArgs e)
        {
            disspawn();
            borrarDatosDeLosTextBox();
        }

        private void idNivel_Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (idNivel_Cbx.SelectedIndex)
            {
                case 0:
                    contraseña_lbl.Visible = true;
                    contraseña_tbx.Visible = true;
                    break;
                case 1:
                    contraseña_lbl.Visible = true;
                    contraseña_tbx.Visible = true;
                    break;
                case 2:
                    contraseña_lbl.Visible = false;
                    contraseña_tbx.Visible = false;
                    break;
            }
        }
    }
}
