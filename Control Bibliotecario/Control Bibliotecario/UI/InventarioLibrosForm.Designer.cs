
namespace Control_Bibliotecario.UI
{
    partial class InventarioLibrosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEdicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCopiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.tipoBusqueda_CB = new System.Windows.Forms.ComboBox();
            this.buscar_Tbx = new System.Windows.Forms.TextBox();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.librosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.LibrosTableAdapter();
            this.tableAdapterManager = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.eliminar_Btn = new System.Windows.Forms.Button();
            this.ISBN_Lbl = new System.Windows.Forms.Label();
            this.titulo_Lbl = new System.Windows.Forms.Label();
            this.autor_Lbl = new System.Windows.Forms.Label();
            this.numEdicion_Lbl = new System.Windows.Forms.Label();
            this.year_Lbl = new System.Windows.Forms.Label();
            this.tema_Lbl = new System.Windows.Forms.Label();
            this.ISBN_Tbx = new System.Windows.Forms.TextBox();
            this.titulo_Tbx = new System.Windows.Forms.TextBox();
            this.autor_Tbx = new System.Windows.Forms.TextBox();
            this.tema_Tbx = new System.Windows.Forms.TextBox();
            this.year_Tbx = new System.Windows.Forms.TextBox();
            this.numEdicion_Tbx = new System.Windows.Forms.TextBox();
            this.agregar_Btn = new System.Windows.Forms.Button();
            this.modificar_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.numeroEdicionDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.temaDataGridViewTextBoxColumn,
            this.idCopiaDataGridViewTextBoxColumn,
            this.estadoPrestamoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.librosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(900, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSBNDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroEdicionDataGridViewTextBoxColumn
            // 
            this.numeroEdicionDataGridViewTextBoxColumn.DataPropertyName = "NumeroEdicion";
            this.numeroEdicionDataGridViewTextBoxColumn.HeaderText = "NumeroEdicion";
            this.numeroEdicionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeroEdicionDataGridViewTextBoxColumn.Name = "numeroEdicionDataGridViewTextBoxColumn";
            this.numeroEdicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroEdicionDataGridViewTextBoxColumn.Width = 150;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "Año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            this.añoDataGridViewTextBoxColumn.ReadOnly = true;
            this.añoDataGridViewTextBoxColumn.Width = 150;
            // 
            // temaDataGridViewTextBoxColumn
            // 
            this.temaDataGridViewTextBoxColumn.DataPropertyName = "Tema";
            this.temaDataGridViewTextBoxColumn.HeaderText = "Tema";
            this.temaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.temaDataGridViewTextBoxColumn.Name = "temaDataGridViewTextBoxColumn";
            this.temaDataGridViewTextBoxColumn.ReadOnly = true;
            this.temaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idCopiaDataGridViewTextBoxColumn
            // 
            this.idCopiaDataGridViewTextBoxColumn.DataPropertyName = "IdCopia";
            this.idCopiaDataGridViewTextBoxColumn.HeaderText = "IdCopia";
            this.idCopiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCopiaDataGridViewTextBoxColumn.Name = "idCopiaDataGridViewTextBoxColumn";
            this.idCopiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCopiaDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoPrestamoDataGridViewTextBoxColumn
            // 
            this.estadoPrestamoDataGridViewTextBoxColumn.DataPropertyName = "EstadoPrestamo";
            this.estadoPrestamoDataGridViewTextBoxColumn.HeaderText = "EstadoPrestamo";
            this.estadoPrestamoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoPrestamoDataGridViewTextBoxColumn.Name = "estadoPrestamoDataGridViewTextBoxColumn";
            this.estadoPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoPrestamoDataGridViewTextBoxColumn.Width = 150;
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
            // tipoBusqueda_CB
            // 
            this.tipoBusqueda_CB.FormattingEnabled = true;
            this.tipoBusqueda_CB.Items.AddRange(new object[] {
            "ISBN",
            "IdCopia",
            "Titulo",
            "Autor",
            "Año",
            "Agregar Libro",
            "Editar Libro",
            "Eliminar Libro"});
            this.tipoBusqueda_CB.Location = new System.Drawing.Point(12, 512);
            this.tipoBusqueda_CB.Name = "tipoBusqueda_CB";
            this.tipoBusqueda_CB.Size = new System.Drawing.Size(142, 21);
            this.tipoBusqueda_CB.TabIndex = 1;
            this.tipoBusqueda_CB.Text = "Tipo de Busqueda";
            this.tipoBusqueda_CB.SelectedIndexChanged += new System.EventHandler(this.tipoBusqueda_CB_SelectedIndexChanged);
            // 
            // buscar_Tbx
            // 
            this.buscar_Tbx.Location = new System.Drawing.Point(161, 512);
            this.buscar_Tbx.Name = "buscar_Tbx";
            this.buscar_Tbx.Size = new System.Drawing.Size(259, 20);
            this.buscar_Tbx.TabIndex = 2;
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(426, 512);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(75, 23);
            this.buscar_Btn.TabIndex = 3;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
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
            // eliminar_Btn
            // 
            this.eliminar_Btn.Enabled = false;
            this.eliminar_Btn.Location = new System.Drawing.Point(507, 512);
            this.eliminar_Btn.Name = "eliminar_Btn";
            this.eliminar_Btn.Size = new System.Drawing.Size(96, 23);
            this.eliminar_Btn.TabIndex = 4;
            this.eliminar_Btn.Text = "Eliminar Libro";
            this.eliminar_Btn.UseVisualStyleBackColor = true;
            this.eliminar_Btn.Click += new System.EventHandler(this.eliminar_Btn_Click);
            // 
            // ISBN_Lbl
            // 
            this.ISBN_Lbl.AutoSize = true;
            this.ISBN_Lbl.Location = new System.Drawing.Point(12, 580);
            this.ISBN_Lbl.Name = "ISBN_Lbl";
            this.ISBN_Lbl.Size = new System.Drawing.Size(35, 13);
            this.ISBN_Lbl.TabIndex = 5;
            this.ISBN_Lbl.Text = "ISBN:";
            this.ISBN_Lbl.Visible = false;
            // 
            // titulo_Lbl
            // 
            this.titulo_Lbl.AutoSize = true;
            this.titulo_Lbl.Location = new System.Drawing.Point(12, 610);
            this.titulo_Lbl.Name = "titulo_Lbl";
            this.titulo_Lbl.Size = new System.Drawing.Size(36, 13);
            this.titulo_Lbl.TabIndex = 6;
            this.titulo_Lbl.Text = "Titulo:";
            this.titulo_Lbl.Visible = false;
            // 
            // autor_Lbl
            // 
            this.autor_Lbl.AutoSize = true;
            this.autor_Lbl.Location = new System.Drawing.Point(12, 640);
            this.autor_Lbl.Name = "autor_Lbl";
            this.autor_Lbl.Size = new System.Drawing.Size(35, 13);
            this.autor_Lbl.TabIndex = 7;
            this.autor_Lbl.Text = "Autor:";
            this.autor_Lbl.Visible = false;
            // 
            // numEdicion_Lbl
            // 
            this.numEdicion_Lbl.AutoSize = true;
            this.numEdicion_Lbl.Location = new System.Drawing.Point(280, 580);
            this.numEdicion_Lbl.Name = "numEdicion_Lbl";
            this.numEdicion_Lbl.Size = new System.Drawing.Size(77, 13);
            this.numEdicion_Lbl.TabIndex = 8;
            this.numEdicion_Lbl.Text = "No de Edición:";
            this.numEdicion_Lbl.Visible = false;
            // 
            // year_Lbl
            // 
            this.year_Lbl.AutoSize = true;
            this.year_Lbl.Location = new System.Drawing.Point(328, 610);
            this.year_Lbl.Name = "year_Lbl";
            this.year_Lbl.Size = new System.Drawing.Size(29, 13);
            this.year_Lbl.TabIndex = 9;
            this.year_Lbl.Text = "Año:";
            this.year_Lbl.Visible = false;
            // 
            // tema_Lbl
            // 
            this.tema_Lbl.AutoSize = true;
            this.tema_Lbl.Location = new System.Drawing.Point(320, 640);
            this.tema_Lbl.Name = "tema_Lbl";
            this.tema_Lbl.Size = new System.Drawing.Size(37, 13);
            this.tema_Lbl.TabIndex = 10;
            this.tema_Lbl.Text = "Tema:";
            this.tema_Lbl.Visible = false;
            // 
            // ISBN_Tbx
            // 
            this.ISBN_Tbx.Location = new System.Drawing.Point(53, 577);
            this.ISBN_Tbx.Name = "ISBN_Tbx";
            this.ISBN_Tbx.Size = new System.Drawing.Size(211, 20);
            this.ISBN_Tbx.TabIndex = 11;
            this.ISBN_Tbx.Visible = false;
            // 
            // titulo_Tbx
            // 
            this.titulo_Tbx.Location = new System.Drawing.Point(53, 607);
            this.titulo_Tbx.Name = "titulo_Tbx";
            this.titulo_Tbx.Size = new System.Drawing.Size(211, 20);
            this.titulo_Tbx.TabIndex = 12;
            this.titulo_Tbx.Visible = false;
            // 
            // autor_Tbx
            // 
            this.autor_Tbx.Location = new System.Drawing.Point(53, 637);
            this.autor_Tbx.Name = "autor_Tbx";
            this.autor_Tbx.Size = new System.Drawing.Size(211, 20);
            this.autor_Tbx.TabIndex = 13;
            this.autor_Tbx.Visible = false;
            // 
            // tema_Tbx
            // 
            this.tema_Tbx.Location = new System.Drawing.Point(363, 637);
            this.tema_Tbx.Name = "tema_Tbx";
            this.tema_Tbx.Size = new System.Drawing.Size(211, 20);
            this.tema_Tbx.TabIndex = 16;
            this.tema_Tbx.Visible = false;
            // 
            // year_Tbx
            // 
            this.year_Tbx.Location = new System.Drawing.Point(363, 607);
            this.year_Tbx.Name = "year_Tbx";
            this.year_Tbx.Size = new System.Drawing.Size(211, 20);
            this.year_Tbx.TabIndex = 15;
            this.year_Tbx.Visible = false;
            // 
            // numEdicion_Tbx
            // 
            this.numEdicion_Tbx.Location = new System.Drawing.Point(363, 577);
            this.numEdicion_Tbx.Name = "numEdicion_Tbx";
            this.numEdicion_Tbx.Size = new System.Drawing.Size(211, 20);
            this.numEdicion_Tbx.TabIndex = 14;
            this.numEdicion_Tbx.Visible = false;
            // 
            // agregar_Btn
            // 
            this.agregar_Btn.Location = new System.Drawing.Point(616, 575);
            this.agregar_Btn.Name = "agregar_Btn";
            this.agregar_Btn.Size = new System.Drawing.Size(93, 23);
            this.agregar_Btn.TabIndex = 17;
            this.agregar_Btn.Text = "Añadir Libro";
            this.agregar_Btn.UseVisualStyleBackColor = true;
            this.agregar_Btn.Visible = false;
            this.agregar_Btn.Click += new System.EventHandler(this.agregar_Btn_Click);
            // 
            // modificar_Btn
            // 
            this.modificar_Btn.Enabled = false;
            this.modificar_Btn.Location = new System.Drawing.Point(616, 610);
            this.modificar_Btn.Name = "modificar_Btn";
            this.modificar_Btn.Size = new System.Drawing.Size(93, 23);
            this.modificar_Btn.TabIndex = 18;
            this.modificar_Btn.Text = "Modificar Libro";
            this.modificar_Btn.UseVisualStyleBackColor = true;
            this.modificar_Btn.Visible = false;
            this.modificar_Btn.Click += new System.EventHandler(this.modificar_Btn_Click);
            // 
            // InventarioLibrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 551);
            this.Controls.Add(this.modificar_Btn);
            this.Controls.Add(this.agregar_Btn);
            this.Controls.Add(this.tema_Tbx);
            this.Controls.Add(this.year_Tbx);
            this.Controls.Add(this.numEdicion_Tbx);
            this.Controls.Add(this.autor_Tbx);
            this.Controls.Add(this.titulo_Tbx);
            this.Controls.Add(this.ISBN_Tbx);
            this.Controls.Add(this.tema_Lbl);
            this.Controls.Add(this.year_Lbl);
            this.Controls.Add(this.numEdicion_Lbl);
            this.Controls.Add(this.autor_Lbl);
            this.Controls.Add(this.titulo_Lbl);
            this.Controls.Add(this.ISBN_Lbl);
            this.Controls.Add(this.eliminar_Btn);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.buscar_Tbx);
            this.Controls.Add(this.tipoBusqueda_CB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "InventarioLibrosForm";
            this.Text = "Inventario de Libros";
            this.Load += new System.EventHandler(this.InventarioLibrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEdicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCopiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox tipoBusqueda_CB;
        private System.Windows.Forms.TextBox buscar_Tbx;
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.Button eliminar_Btn;
        private System.Windows.Forms.Label ISBN_Lbl;
        private System.Windows.Forms.Label titulo_Lbl;
        private System.Windows.Forms.Label autor_Lbl;
        private System.Windows.Forms.Label numEdicion_Lbl;
        private System.Windows.Forms.Label year_Lbl;
        private System.Windows.Forms.Label tema_Lbl;
        private System.Windows.Forms.TextBox ISBN_Tbx;
        private System.Windows.Forms.TextBox titulo_Tbx;
        private System.Windows.Forms.TextBox autor_Tbx;
        private System.Windows.Forms.TextBox tema_Tbx;
        private System.Windows.Forms.TextBox year_Tbx;
        private System.Windows.Forms.TextBox numEdicion_Tbx;
        private System.Windows.Forms.Button agregar_Btn;
        private System.Windows.Forms.Button modificar_Btn;
    }
}