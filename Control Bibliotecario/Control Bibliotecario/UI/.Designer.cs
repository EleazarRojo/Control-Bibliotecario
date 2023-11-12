
namespace Control_Bibliotecario
{
    partial class PrincipalForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titulo_Lbl = new System.Windows.Forms.Label();
            this.tipoBusqueda_Lbl = new System.Windows.Forms.Label();
            this.busqueda_Tbx = new System.Windows.Forms.TextBox();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.tipoBusqueda_CB = new System.Windows.Forms.ComboBox();
            this.detalles_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEdicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.librosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.LibrosTableAdapter();
            this.tableAdapterManager = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.registrarseToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.controlDeUsuariosToolStripMenuItem,
            this.controlDePrestamosToolStripMenuItem,
            this.inventarioDeLibrosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1851, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.ingresoToolStripMenuItem.Text = "&Ingresar";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.registrarseToolStripMenuItem.Text = "&Registrarse";
            this.registrarseToolStripMenuItem.Click += new System.EventHandler(this.registrarseToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.prestamosToolStripMenuItem.Text = "Historial de Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión ";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // controlDeUsuariosToolStripMenuItem
            // 
            this.controlDeUsuariosToolStripMenuItem.Name = "controlDeUsuariosToolStripMenuItem";
            this.controlDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(185, 29);
            this.controlDeUsuariosToolStripMenuItem.Text = "Control de Usuarios";
            this.controlDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.controlDeUsuariosToolStripMenuItem_Click);
            // 
            // controlDePrestamosToolStripMenuItem
            // 
            this.controlDePrestamosToolStripMenuItem.Name = "controlDePrestamosToolStripMenuItem";
            this.controlDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(200, 29);
            this.controlDePrestamosToolStripMenuItem.Text = "Control de Prestamos";
            this.controlDePrestamosToolStripMenuItem.Click += new System.EventHandler(this.controlDePrestamosToolStripMenuItem_Click);
            // 
            // inventarioDeLibrosToolStripMenuItem
            // 
            this.inventarioDeLibrosToolStripMenuItem.Name = "inventarioDeLibrosToolStripMenuItem";
            this.inventarioDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(185, 29);
            this.inventarioDeLibrosToolStripMenuItem.Text = "Inventario de Libros";
            this.inventarioDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.inventarioDeLibrosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // titulo_Lbl
            // 
            this.titulo_Lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo_Lbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_Lbl.Location = new System.Drawing.Point(0, 33);
            this.titulo_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo_Lbl.Name = "titulo_Lbl";
            this.titulo_Lbl.Size = new System.Drawing.Size(1851, 122);
            this.titulo_Lbl.TabIndex = 2;
            this.titulo_Lbl.Text = "Busqueda de Libros";
            this.titulo_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoBusqueda_Lbl
            // 
            this.tipoBusqueda_Lbl.AutoSize = true;
            this.tipoBusqueda_Lbl.Location = new System.Drawing.Point(4, 17);
            this.tipoBusqueda_Lbl.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.tipoBusqueda_Lbl.Name = "tipoBusqueda_Lbl";
            this.tipoBusqueda_Lbl.Size = new System.Drawing.Size(142, 20);
            this.tipoBusqueda_Lbl.TabIndex = 5;
            this.tipoBusqueda_Lbl.Text = "Tipo de Busqueda:";
            // 
            // busqueda_Tbx
            // 
            this.busqueda_Tbx.Location = new System.Drawing.Point(468, 13);
            this.busqueda_Tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.busqueda_Tbx.Name = "busqueda_Tbx";
            this.busqueda_Tbx.Size = new System.Drawing.Size(922, 26);
            this.busqueda_Tbx.TabIndex = 9;
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(1398, 13);
            this.buscar_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(112, 35);
            this.buscar_Btn.TabIndex = 13;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
            // 
            // tipoBusqueda_CB
            // 
            this.tipoBusqueda_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoBusqueda_CB.FormattingEnabled = true;
            this.tipoBusqueda_CB.Items.AddRange(new object[] {
            "ISBN",
            "Titulo",
            "Autor",
            "Tema",
            "Año"});
            this.tipoBusqueda_CB.Location = new System.Drawing.Point(154, 13);
            this.tipoBusqueda_CB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipoBusqueda_CB.Name = "tipoBusqueda_CB";
            this.tipoBusqueda_CB.Size = new System.Drawing.Size(306, 28);
            this.tipoBusqueda_CB.TabIndex = 14;
            this.tipoBusqueda_CB.SelectedIndexChanged += new System.EventHandler(this.tipoBusqueda_CB_SelectedIndexChanged);
            // 
            // detalles_Btn
            // 
            this.detalles_Btn.Enabled = false;
            this.detalles_Btn.Location = new System.Drawing.Point(1518, 13);
            this.detalles_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detalles_Btn.Name = "detalles_Btn";
            this.detalles_Btn.Size = new System.Drawing.Size(112, 35);
            this.detalles_Btn.TabIndex = 15;
            this.detalles_Btn.Text = "Detalles";
            this.detalles_Btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.Autor,
            this.tituloDataGridViewTextBoxColumn,
            this.numeroEdicionDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.temaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.librosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(92, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1671, 735);
            this.dataGridView1.TabIndex = 16;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 150;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 8;
            this.Autor.Name = "Autor";
            this.Autor.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroEdicionDataGridViewTextBoxColumn
            // 
            this.numeroEdicionDataGridViewTextBoxColumn.DataPropertyName = "NumeroEdicion";
            this.numeroEdicionDataGridViewTextBoxColumn.HeaderText = "NumeroEdicion";
            this.numeroEdicionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeroEdicionDataGridViewTextBoxColumn.Name = "numeroEdicionDataGridViewTextBoxColumn";
            this.numeroEdicionDataGridViewTextBoxColumn.Width = 150;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "Año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            this.añoDataGridViewTextBoxColumn.Width = 150;
            // 
            // temaDataGridViewTextBoxColumn
            // 
            this.temaDataGridViewTextBoxColumn.DataPropertyName = "Tema";
            this.temaDataGridViewTextBoxColumn.HeaderText = "Tema";
            this.temaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.temaDataGridViewTextBoxColumn.Name = "temaDataGridViewTextBoxColumn";
            this.temaDataGridViewTextBoxColumn.Width = 150;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.tipoBusqueda_Lbl);
            this.flowLayoutPanel1.Controls.Add(this.tipoBusqueda_CB);
            this.flowLayoutPanel1.Controls.Add(this.busqueda_Tbx);
            this.flowLayoutPanel1.Controls.Add(this.buscar_Btn);
            this.flowLayoutPanel1.Controls.Add(this.detalles_Btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(92, 969);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1671, 63);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(92, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 18;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ISBNAutorTableAdapter = null;
            this.tableAdapterManager.LibrosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.NivelDeAccesoTableAdapter = null;
            this.tableAdapterManager.PrestamosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 1051);
            this.Controls.Add(this.titulo_Lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrincipalForm";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label titulo_Lbl;
        private System.Windows.Forms.Label tipoBusqueda_Lbl;
        private System.Windows.Forms.TextBox busqueda_Tbx;
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.ComboBox tipoBusqueda_CB;
        private System.Windows.Forms.Button detalles_Btn;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEdicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDePrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioDeLibrosToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

