﻿using System;
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
    public partial class IngresoAdmin : Form
    {
        public string IdUsuario { get; set; }

        public string Nombre { get; set; }
        public IngresoAdmin(string idUsuario, string nombre)
        {
            InitializeComponent();


        }
    }
}
