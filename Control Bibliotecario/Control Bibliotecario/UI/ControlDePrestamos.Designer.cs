
namespace Control_Bibliotecario.UI
{
    partial class ControlDePrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.folioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.prestamosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.PrestamosTableAdapter();
            this.tableAdapterManager = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relizarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscar_lbl = new System.Windows.Forms.Label();
            this.IdUsuario_Tbx = new System.Windows.Forms.TextBox();
            this.tipoBusqueda_CB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.fechaInicialDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prestamosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1346, 658);
            this.dataGridView1.TabIndex = 0;
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "Folio";
            dataGridViewCellStyle2.Format = "0000000000";
            dataGridViewCellStyle2.NullValue = null;
            this.folioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.folioDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.folioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            this.folioDataGridViewTextBoxColumn.Width = 150;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaInicialDataGridViewTextBoxColumn
            // 
            this.fechaInicialDataGridViewTextBoxColumn.DataPropertyName = "FechaInicial";
            this.fechaInicialDataGridViewTextBoxColumn.HeaderText = "FechaInicial";
            this.fechaInicialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaInicialDataGridViewTextBoxColumn.Name = "fechaInicialDataGridViewTextBoxColumn";
            this.fechaInicialDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            this.fechaDevolucionDataGridViewTextBoxColumn.Width = 150;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ISBNAutorTableAdapter = null;
            this.tableAdapterManager.LibrosTableAdapter = null;
            this.tableAdapterManager.NivelDeAccesoTableAdapter = null;
            this.tableAdapterManager.PrestamosTableAdapter = this.prestamosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(1119, 763);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(112, 35);
            this.buscar_Btn.TabIndex = 7;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relizarPrestamoToolStripMenuItem,
            this.devolverPrestamoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relizarPrestamoToolStripMenuItem
            // 
            this.relizarPrestamoToolStripMenuItem.Name = "relizarPrestamoToolStripMenuItem";
            this.relizarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.relizarPrestamoToolStripMenuItem.Text = "Relizar Prestamo";
            this.relizarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.relizarPrestamoToolStripMenuItem_Click);
            // 
            // devolverPrestamoToolStripMenuItem
            // 
            this.devolverPrestamoToolStripMenuItem.Name = "devolverPrestamoToolStripMenuItem";
            this.devolverPrestamoToolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.devolverPrestamoToolStripMenuItem.Text = "Devolver Prestamo";
            this.devolverPrestamoToolStripMenuItem.Click += new System.EventHandler(this.devolverPrestamoToolStripMenuItem_Click);
            // 
            // buscar_lbl
            // 
            this.buscar_lbl.AutoSize = true;
            this.buscar_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_lbl.Location = new System.Drawing.Point(58, 765);
            this.buscar_lbl.Name = "buscar_lbl";
            this.buscar_lbl.Size = new System.Drawing.Size(85, 27);
            this.buscar_lbl.TabIndex = 2;
            this.buscar_lbl.Text = "Buscar:";
            // 
            // IdUsuario_Tbx
            // 
            this.IdUsuario_Tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuario_Tbx.Location = new System.Drawing.Point(494, 763);
            this.IdUsuario_Tbx.Name = "IdUsuario_Tbx";
            this.IdUsuario_Tbx.Size = new System.Drawing.Size(618, 30);
            this.IdUsuario_Tbx.TabIndex = 3;
            this.IdUsuario_Tbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdUsuario_Tbx_KeyPress);
            // 
            // tipoBusqueda_CB
            // 
            this.tipoBusqueda_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoBusqueda_CB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoBusqueda_CB.FormattingEnabled = true;
            this.tipoBusqueda_CB.Items.AddRange(new object[] {
            "ISBN",
            "ID Usario",
            "ESTATUS"});
            this.tipoBusqueda_CB.Location = new System.Drawing.Point(144, 763);
            this.tipoBusqueda_CB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipoBusqueda_CB.Name = "tipoBusqueda_CB";
            this.tipoBusqueda_CB.Size = new System.Drawing.Size(340, 30);
            this.tipoBusqueda_CB.TabIndex = 15;
            // 
            // ControlDePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 871);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.tipoBusqueda_CB);
            this.Controls.Add(this.IdUsuario_Tbx);
            this.Controls.Add(this.buscar_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlDePrestamos";
            this.Text = "ControlDePrestamos";
            this.Load += new System.EventHandler(this.ControlDePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private BibliotecaDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relizarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverPrestamoToolStripMenuItem;
        private System.Windows.Forms.Label buscar_lbl;
        private System.Windows.Forms.TextBox IdUsuario_Tbx;
        private System.Windows.Forms.ComboBox tipoBusqueda_CB;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
    }
}