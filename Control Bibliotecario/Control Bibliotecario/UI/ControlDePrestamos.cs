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
    }
}
