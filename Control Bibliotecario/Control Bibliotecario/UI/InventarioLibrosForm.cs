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
    public partial class InventarioLibrosForm : Form
    {
        public InventarioLibrosForm()
        {
            InitializeComponent();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

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
                    break;
                case 1:
                    librosTableAdapter.OrdenarPorIdCopia(bibliotecaDataSet.Libros);
                    break;
                case 2:
                    librosTableAdapter.OrdenarPorTitulo(bibliotecaDataSet.Libros);
                    break;
                case 3:
                    librosTableAdapter.OrdenarPorAutor(bibliotecaDataSet.Libros);
                    break;
                case 4:
                    librosTableAdapter.OrdenarPorAño(bibliotecaDataSet.Libros);
                    break;
            }
        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            switch (tipoBusqueda_CB.SelectedIndex)
            {
                case 0:
                    librosTableAdapter.OrdenarPorISBNEspecifico(bibliotecaDataSet.Libros, buscar_Tbx.Text);
                    break;
                case 1:
                    librosTableAdapter.OrdenarPorIdCopiaEspecifico(bibliotecaDataSet.Libros, int.Parse(buscar_Tbx.Text));
                    break;
                case 2:
                    librosTableAdapter.OrdenarPorTituloEspecifico(bibliotecaDataSet.Libros, buscar_Tbx.Text);
                    break;
                case 3:
                    librosTableAdapter.OrdenarPorAutorEspecifico(bibliotecaDataSet.Libros, buscar_Tbx.Text);
                    break;
                case 4:
                    librosTableAdapter.OrdenarPorAñoEspecifico(bibliotecaDataSet.Libros, buscar_Tbx.Text);
                    break;
            }
        }
    }
}
