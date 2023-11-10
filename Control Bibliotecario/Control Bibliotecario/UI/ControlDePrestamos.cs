using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Bibliotecario.UI
{
    public partial class ControlDePrestamos : Form
    {
        public ControlDePrestamos()
        {
            InitializeComponent();
            

        }

        private void ControlDePrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.bibliotecaDataSet.Prestamos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipoBusqueda_CB.Text == "")
            {
                MessageBox.Show("Ingrese un tipo de vusqueda antes de realizar una busqueda");
                return;
            }
            if (IdUsuario_Tbx.Text ==""||Convert.ToInt32(IdUsuario_Tbx.Text)==0)
            {
                MessageBox.Show("Favor de ingres un id deusario Valido");
                return;
            }
           
        }

        private void IdUsuario_Tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se suprime la tecla
                e.Handled = true;
            }
        }

        private void relizarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarPrestamoForm RealizarPrestamoForm = new RealizarPrestamoForm();
            RealizarPrestamoForm.Show();
        }

        private void devolverPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolverPrestamoForm DevolverPrestamoForm = new DevolverPrestamoForm();
            DevolverPrestamoForm.Show();
        }
    }
}
