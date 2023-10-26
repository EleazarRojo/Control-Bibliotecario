
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
            this.libre_Lbl = new System.Windows.Forms.Label();
            this.bTitulo_Lbl = new System.Windows.Forms.Label();
            this.bAutor_Lbl = new System.Windows.Forms.Label();
            this.bTema_Lbl = new System.Windows.Forms.Label();
            this.bLibre_Tbx = new System.Windows.Forms.TextBox();
            this.bTitulo_Tbx = new System.Windows.Forms.TextBox();
            this.bAutor_Tbx = new System.Windows.Forms.TextBox();
            this.bTema_Tbx = new System.Windows.Forms.TextBox();
            this.buscar_Btn = new System.Windows.Forms.Button();
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
            this.busqueda_DataGridView.Location = new System.Drawing.Point(114, 155);
            this.busqueda_DataGridView.Name = "busqueda_DataGridView";
            this.busqueda_DataGridView.Size = new System.Drawing.Size(545, 193);
            this.busqueda_DataGridView.TabIndex = 1;
            // 
            // titulo_Lbl
            // 
            this.titulo_Lbl.AutoSize = true;
            this.titulo_Lbl.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_Lbl.Location = new System.Drawing.Point(275, 55);
            this.titulo_Lbl.Name = "titulo_Lbl";
            this.titulo_Lbl.Size = new System.Drawing.Size(271, 33);
            this.titulo_Lbl.TabIndex = 2;
            this.titulo_Lbl.Text = "Busqueda de Libros";
            // 
            // descripcion_Lbl
            // 
            this.descripcion_Lbl.AutoSize = true;
            this.descripcion_Lbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_Lbl.Location = new System.Drawing.Point(277, 105);
            this.descripcion_Lbl.Name = "descripcion_Lbl";
            this.descripcion_Lbl.Size = new System.Drawing.Size(122, 19);
            this.descripcion_Lbl.TabIndex = 3;
            this.descripcion_Lbl.Text = "Texto de prueba";
            // 
            // imagen_Lbl
            // 
            this.imagen_Lbl.AutoSize = true;
            this.imagen_Lbl.Location = new System.Drawing.Point(70, 91);
            this.imagen_Lbl.Name = "imagen_Lbl";
            this.imagen_Lbl.Size = new System.Drawing.Size(80, 13);
            this.imagen_Lbl.TabIndex = 4;
            this.imagen_Lbl.Text = "Insertar Imagen";
            // 
            // libre_Lbl
            // 
            this.libre_Lbl.AutoSize = true;
            this.libre_Lbl.Location = new System.Drawing.Point(111, 371);
            this.libre_Lbl.Name = "libre_Lbl";
            this.libre_Lbl.Size = new System.Drawing.Size(84, 13);
            this.libre_Lbl.TabIndex = 5;
            this.libre_Lbl.Text = "Busqueda Libre:";
            // 
            // bTitulo_Lbl
            // 
            this.bTitulo_Lbl.AutoSize = true;
            this.bTitulo_Lbl.Location = new System.Drawing.Point(111, 411);
            this.bTitulo_Lbl.Name = "bTitulo_Lbl";
            this.bTitulo_Lbl.Size = new System.Drawing.Size(105, 13);
            this.bTitulo_Lbl.TabIndex = 6;
            this.bTitulo_Lbl.Text = "Busqueda por Titulo:";
            // 
            // bAutor_Lbl
            // 
            this.bAutor_Lbl.AutoSize = true;
            this.bAutor_Lbl.Location = new System.Drawing.Point(111, 449);
            this.bAutor_Lbl.Name = "bAutor_Lbl";
            this.bAutor_Lbl.Size = new System.Drawing.Size(104, 13);
            this.bAutor_Lbl.TabIndex = 7;
            this.bAutor_Lbl.Text = "Busqueda por Autor:";
            // 
            // bTema_Lbl
            // 
            this.bTema_Lbl.AutoSize = true;
            this.bTema_Lbl.Location = new System.Drawing.Point(111, 490);
            this.bTema_Lbl.Name = "bTema_Lbl";
            this.bTema_Lbl.Size = new System.Drawing.Size(106, 13);
            this.bTema_Lbl.TabIndex = 8;
            this.bTema_Lbl.Text = "Busqueda por Tema:";
            // 
            // bLibre_Tbx
            // 
            this.bLibre_Tbx.Location = new System.Drawing.Point(114, 388);
            this.bLibre_Tbx.Name = "bLibre_Tbx";
            this.bLibre_Tbx.Size = new System.Drawing.Size(545, 20);
            this.bLibre_Tbx.TabIndex = 9;
            // 
            // bTitulo_Tbx
            // 
            this.bTitulo_Tbx.Location = new System.Drawing.Point(114, 427);
            this.bTitulo_Tbx.Name = "bTitulo_Tbx";
            this.bTitulo_Tbx.Size = new System.Drawing.Size(545, 20);
            this.bTitulo_Tbx.TabIndex = 10;
            // 
            // bAutor_Tbx
            // 
            this.bAutor_Tbx.Location = new System.Drawing.Point(114, 467);
            this.bAutor_Tbx.Name = "bAutor_Tbx";
            this.bAutor_Tbx.Size = new System.Drawing.Size(545, 20);
            this.bAutor_Tbx.TabIndex = 11;
            // 
            // bTema_Tbx
            // 
            this.bTema_Tbx.Location = new System.Drawing.Point(114, 506);
            this.bTema_Tbx.Name = "bTema_Tbx";
            this.bTema_Tbx.Size = new System.Drawing.Size(545, 20);
            this.bTema_Tbx.TabIndex = 12;
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(584, 543);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(75, 23);
            this.buscar_Btn.TabIndex = 13;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.bTema_Tbx);
            this.Controls.Add(this.bAutor_Tbx);
            this.Controls.Add(this.bTitulo_Tbx);
            this.Controls.Add(this.bLibre_Tbx);
            this.Controls.Add(this.bTema_Lbl);
            this.Controls.Add(this.bAutor_Lbl);
            this.Controls.Add(this.bTitulo_Lbl);
            this.Controls.Add(this.libre_Lbl);
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
        private System.Windows.Forms.Label libre_Lbl;
        private System.Windows.Forms.Label bTitulo_Lbl;
        private System.Windows.Forms.Label bAutor_Lbl;
        private System.Windows.Forms.Label bTema_Lbl;
        private System.Windows.Forms.TextBox bLibre_Tbx;
        private System.Windows.Forms.TextBox bTitulo_Tbx;
        private System.Windows.Forms.TextBox bAutor_Tbx;
        private System.Windows.Forms.TextBox bTema_Tbx;
        private System.Windows.Forms.Button buscar_Btn;
    }
}

