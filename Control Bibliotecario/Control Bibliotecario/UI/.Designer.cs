﻿
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
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busqueda_DataGridView = new System.Windows.Forms.DataGridView();
            this.titulo_Lbl = new System.Windows.Forms.Label();
            this.descripcion_Lbl = new System.Windows.Forms.Label();
            this.imagen_Lbl = new System.Windows.Forms.Label();
            this.tipoBusqueda_Lbl = new System.Windows.Forms.Label();
            this.busqueda_Tbx = new System.Windows.Forms.TextBox();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.tipoBusqueda_CB = new System.Windows.Forms.ComboBox();
            this.detalles_Btn = new System.Windows.Forms.Button();
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.LibrosTableAdapter();
            this.tableAdapterManager = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEdicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejemplaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.registrarseToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.ingresoToolStripMenuItem.Text = "&Ingresar";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.registrarseToolStripMenuItem.Text = "&Registrarse";
            this.registrarseToolStripMenuItem.Click += new System.EventHandler(this.registrarseToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // busqueda_DataGridView
            // 
            this.busqueda_DataGridView.AutoGenerateColumns = false;
            this.busqueda_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busqueda_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.numeroEdicionDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.temaDataGridViewTextBoxColumn,
            this.ejemplaresDataGridViewTextBoxColumn});
            this.busqueda_DataGridView.DataSource = this.librosBindingSource;
            this.busqueda_DataGridView.Location = new System.Drawing.Point(73, 155);
            this.busqueda_DataGridView.Name = "busqueda_DataGridView";
            this.busqueda_DataGridView.RowHeadersWidth = 62;
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
            // tipoBusqueda_CB
            // 
            this.tipoBusqueda_CB.FormattingEnabled = true;
            this.tipoBusqueda_CB.Items.AddRange(new object[] {
            "Titulo",
            "Autor",
            "Tema"});
            this.tipoBusqueda_CB.Location = new System.Drawing.Point(173, 499);
            this.tipoBusqueda_CB.Name = "tipoBusqueda_CB";
            this.tipoBusqueda_CB.Size = new System.Drawing.Size(108, 21);
            this.tipoBusqueda_CB.TabIndex = 14;
            this.tipoBusqueda_CB.SelectedIndexChanged += new System.EventHandler(this.tipoBusqueda_CB_SelectedIndexChanged);
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
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.bibliotecaDataSet;
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
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // numeroEdicionDataGridViewTextBoxColumn
            // 
            this.numeroEdicionDataGridViewTextBoxColumn.DataPropertyName = "NumeroEdicion";
            this.numeroEdicionDataGridViewTextBoxColumn.HeaderText = "NumeroEdicion";
            this.numeroEdicionDataGridViewTextBoxColumn.Name = "numeroEdicionDataGridViewTextBoxColumn";
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "Año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            // 
            // temaDataGridViewTextBoxColumn
            // 
            this.temaDataGridViewTextBoxColumn.DataPropertyName = "Tema";
            this.temaDataGridViewTextBoxColumn.HeaderText = "Tema";
            this.temaDataGridViewTextBoxColumn.Name = "temaDataGridViewTextBoxColumn";
            // 
            // ejemplaresDataGridViewTextBoxColumn
            // 
            this.ejemplaresDataGridViewTextBoxColumn.DataPropertyName = "Ejemplares";
            this.ejemplaresDataGridViewTextBoxColumn.HeaderText = "Ejemplares";
            this.ejemplaresDataGridViewTextBoxColumn.Name = "ejemplaresDataGridViewTextBoxColumn";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.detalles_Btn);
            this.Controls.Add(this.tipoBusqueda_CB);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.busqueda_Tbx);
            this.Controls.Add(this.tipoBusqueda_Lbl);
            this.Controls.Add(this.imagen_Lbl);
            this.Controls.Add(this.descripcion_Lbl);
            this.Controls.Add(this.titulo_Lbl);
            this.Controls.Add(this.busqueda_DataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox tipoBusqueda_CB;
        private System.Windows.Forms.Button detalles_Btn;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEdicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejemplaresDataGridViewTextBoxColumn;
    }
}
