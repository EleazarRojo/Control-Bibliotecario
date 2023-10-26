
namespace Control_Bibliotecario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busqueda_DataGridView = new System.Windows.Forms.DataGridView();
            this.titulo_Lbl = new System.Windows.Forms.Label();
            this.descripcion_Lbl = new System.Windows.Forms.Label();
            this.imagen_Lbl = new System.Windows.Forms.Label();
            this.tipoBusqueda_Lbl = new System.Windows.Forms.Label();
            this.busqueda_Tbx = new System.Windows.Forms.TextBox();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.detalles_Btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.registrarseToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ingresoToolStripMenuItem.Text = "&Ingresar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.registrarseToolStripMenuItem.Text = "&Registrarse";
            // 
            // busqueda_DataGridView
            // 
            this.busqueda_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busqueda_DataGridView.Location = new System.Drawing.Point(73, 155);
            this.busqueda_DataGridView.Name = "busqueda_DataGridView";
            this.busqueda_DataGridView.Size = new System.Drawing.Size(654, 317);
            this.busqueda_DataGridView.TabIndex = 1;
            // 
            // titulo_Lbl
            // 
            this.titulo_Lbl.AutoSize = true;
            this.titulo_Lbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_Lbl.Location = new System.Drawing.Point(275, 55);
            this.titulo_Lbl.Name = "titulo_Lbl";
            this.titulo_Lbl.Size = new System.Drawing.Size(248, 31);
            this.titulo_Lbl.TabIndex = 2;
            this.titulo_Lbl.Text = "Busqueda de Libros";
            // 
            // descripcion_Lbl
            // 
            this.descripcion_Lbl.AutoSize = true;
            this.descripcion_Lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_Lbl.Location = new System.Drawing.Point(277, 105);
            this.descripcion_Lbl.Name = "descripcion_Lbl";
            this.descripcion_Lbl.Size = new System.Drawing.Size(108, 19);
            this.descripcion_Lbl.TabIndex = 3;
            this.descripcion_Lbl.Text = "Texto de prueba";
            // 
            // imagen_Lbl
            // 
            this.imagen_Lbl.AutoSize = true;
            this.imagen_Lbl.Location = new System.Drawing.Point(121, 88);
            this.imagen_Lbl.Name = "imagen_Lbl";
            this.imagen_Lbl.Size = new System.Drawing.Size(80, 13);
            this.imagen_Lbl.TabIndex = 4;
            this.imagen_Lbl.Text = "Insertar Imagen";
            // 
            // tipoBusqueda_Lbl
            // 
            this.tipoBusqueda_Lbl.AutoSize = true;
            this.tipoBusqueda_Lbl.Location = new System.Drawing.Point(70, 502);
            this.tipoBusqueda_Lbl.Name = "tipoBusqueda_Lbl";
            this.tipoBusqueda_Lbl.Size = new System.Drawing.Size(97, 13);
            this.tipoBusqueda_Lbl.TabIndex = 5;
            this.tipoBusqueda_Lbl.Text = "Tipo de Busqueda:";
            // 
            // busqueda_Tbx
            // 
            this.busqueda_Tbx.Location = new System.Drawing.Point(73, 535);
            this.busqueda_Tbx.Name = "busqueda_Tbx";
            this.busqueda_Tbx.Size = new System.Drawing.Size(208, 20);
            this.busqueda_Tbx.TabIndex = 9;
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(312, 532);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(75, 23);
            this.buscar_Btn.TabIndex = 13;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Titulo",
            "Autor",
            "Tema"});
            this.comboBox1.Location = new System.Drawing.Point(173, 499);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // detalles_Btn
            // 
            this.detalles_Btn.Enabled = false;
            this.detalles_Btn.Location = new System.Drawing.Point(410, 532);
            this.detalles_Btn.Name = "detalles_Btn";
            this.detalles_Btn.Size = new System.Drawing.Size(75, 23);
            this.detalles_Btn.TabIndex = 15;
            this.detalles_Btn.Text = "Detalles";
            this.detalles_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.detalles_Btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.busqueda_Tbx);
            this.Controls.Add(this.tipoBusqueda_Lbl);
            this.Controls.Add(this.imagen_Lbl);
            this.Controls.Add(this.descripcion_Lbl);
            this.Controls.Add(this.titulo_Lbl);
            this.Controls.Add(this.busqueda_DataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Busqueda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.DataGridView busqueda_DataGridView;
        private System.Windows.Forms.Label titulo_Lbl;
        private System.Windows.Forms.Label descripcion_Lbl;
        private System.Windows.Forms.Label imagen_Lbl;
        private System.Windows.Forms.Label tipoBusqueda_Lbl;
        private System.Windows.Forms.TextBox busqueda_Tbx;
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button detalles_Btn;
    }
}

