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
    public partial class VistaUsuariosForm : Form
    {
        public VistaUsuariosForm()
        {
            InitializeComponent();
        }

        private void VistaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bibliotecaDataSet.Usuarios);

        }
    }
}
