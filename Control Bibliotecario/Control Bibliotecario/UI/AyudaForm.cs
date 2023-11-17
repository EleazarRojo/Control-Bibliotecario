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
    public partial class AyudaForm : Form
    {
        public AyudaForm()
        {
            InitializeComponent();
        }

        private void siguiente_Btn_Click(object sender, EventArgs e)
        {
            Ayuda2Form ayuda2 = new Ayuda2Form();
            ayuda2.Show();
        }
    }
}
