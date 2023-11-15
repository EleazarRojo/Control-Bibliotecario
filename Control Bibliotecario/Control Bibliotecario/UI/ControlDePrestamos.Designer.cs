
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDePrestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relizarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscar_lbl = new System.Windows.Forms.Label();
            this.buscar_Tbx = new System.Windows.Forms.TextBox();
            this.tipoBusqueda_CB = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
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
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            // 
            // buscar_Btn
            // 
            resources.ApplyResources(this.buscar_Btn, "buscar_Btn");
            this.buscar_Btn.Name = "buscar_Btn";
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
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // relizarPrestamoToolStripMenuItem
            // 
            this.relizarPrestamoToolStripMenuItem.Name = "relizarPrestamoToolStripMenuItem";
            resources.ApplyResources(this.relizarPrestamoToolStripMenuItem, "relizarPrestamoToolStripMenuItem");
            this.relizarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.relizarPrestamoToolStripMenuItem_Click);
            // 
            // devolverPrestamoToolStripMenuItem
            // 
            this.devolverPrestamoToolStripMenuItem.Name = "devolverPrestamoToolStripMenuItem";
            resources.ApplyResources(this.devolverPrestamoToolStripMenuItem, "devolverPrestamoToolStripMenuItem");
            this.devolverPrestamoToolStripMenuItem.Click += new System.EventHandler(this.devolverPrestamoToolStripMenuItem_Click);
            // 
            // buscar_lbl
            // 
            resources.ApplyResources(this.buscar_lbl, "buscar_lbl");
            this.buscar_lbl.Name = "buscar_lbl";
            // 
            // buscar_Tbx
            // 
            resources.ApplyResources(this.buscar_Tbx, "buscar_Tbx");
            this.buscar_Tbx.Name = "buscar_Tbx";
            this.buscar_Tbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdUsuario_Tbx_KeyPress);
            // 
            // tipoBusqueda_CB
            // 
            resources.ApplyResources(this.tipoBusqueda_CB, "tipoBusqueda_CB");
            this.tipoBusqueda_CB.FormattingEnabled = true;
            this.tipoBusqueda_CB.Items.AddRange(new object[] {
            resources.GetString("tipoBusqueda_CB.Items"),
            resources.GetString("tipoBusqueda_CB.Items1"),
            resources.GetString("tipoBusqueda_CB.Items2"),
            resources.GetString("tipoBusqueda_CB.Items3"),
            resources.GetString("tipoBusqueda_CB.Items4")});
            this.tipoBusqueda_CB.Name = "tipoBusqueda_CB";
            this.tipoBusqueda_CB.SelectedIndexChanged += new System.EventHandler(this.tipoBusqueda_CB_SelectedIndexChanged);
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "Folio";
            dataGridViewCellStyle3.Format = "0000000000";
            dataGridViewCellStyle3.NullValue = null;
            this.folioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.folioDataGridViewTextBoxColumn, "folioDataGridViewTextBoxColumn");
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            this.folioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            resources.ApplyResources(this.estatusDataGridViewTextBoxColumn, "estatusDataGridViewTextBoxColumn");
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            resources.ApplyResources(this.idUsuarioDataGridViewTextBoxColumn, "idUsuarioDataGridViewTextBoxColumn");
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            resources.ApplyResources(this.iSBNDataGridViewTextBoxColumn, "iSBNDataGridViewTextBoxColumn");
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            resources.ApplyResources(this.tituloDataGridViewTextBoxColumn, "tituloDataGridViewTextBoxColumn");
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            resources.ApplyResources(this.autorDataGridViewTextBoxColumn, "autorDataGridViewTextBoxColumn");
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicialDataGridViewTextBoxColumn
            // 
            this.fechaInicialDataGridViewTextBoxColumn.DataPropertyName = "FechaInicial";
            resources.ApplyResources(this.fechaInicialDataGridViewTextBoxColumn, "fechaInicialDataGridViewTextBoxColumn");
            this.fechaInicialDataGridViewTextBoxColumn.Name = "fechaInicialDataGridViewTextBoxColumn";
            this.fechaInicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion";
            resources.ApplyResources(this.fechaDevolucionDataGridViewTextBoxColumn, "fechaDevolucionDataGridViewTextBoxColumn");
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            this.fechaDevolucionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ControlDePrestamos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.tipoBusqueda_CB);
            this.Controls.Add(this.buscar_Tbx);
            this.Controls.Add(this.buscar_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ControlDePrestamos";
            this.Load += new System.EventHandler(this.ControlDePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox buscar_Tbx;
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