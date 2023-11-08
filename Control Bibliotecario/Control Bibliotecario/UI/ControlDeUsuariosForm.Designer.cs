
namespace Control_Bibliotecario.UI
{
    partial class ControlDeUsuariosForm
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
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDeNivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionParticularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.usuariosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.eliminar_Btn = new System.Windows.Forms.Button();
            this.buscar_Tbx = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeBusqueda_Lbl = new System.Windows.Forms.Label();
            this.tipoDeBusqueda_Cbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.rFCDataGridViewTextBoxColumn,
            this.idDeNivelDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.fechaDeNacimientoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.direccionParticularDataGridViewTextBoxColumn,
            this.Prestamo});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(943, 509);
            this.dataGridView1.TabIndex = 0;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            dataGridViewCellStyle2.Format = "000000";
            dataGridViewCellStyle2.NullValue = null;
            this.idUsuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idUsuarioDataGridViewTextBoxColumn.Frozen = true;
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            this.rFCDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDeNivelDataGridViewTextBoxColumn
            // 
            this.idDeNivelDataGridViewTextBoxColumn.DataPropertyName = "IdDeNivel";
            this.idDeNivelDataGridViewTextBoxColumn.HeaderText = "IdDeNivel";
            this.idDeNivelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDeNivelDataGridViewTextBoxColumn.Name = "idDeNivelDataGridViewTextBoxColumn";
            this.idDeNivelDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            this.apellidoPaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            this.apellidoMaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDeNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaDeNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaDeNacimiento";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaDeNacimiento";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaDeNacimientoDataGridViewTextBoxColumn.Name = "fechaDeNacimientoDataGridViewTextBoxColumn";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.Width = 150;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.Width = 150;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionParticularDataGridViewTextBoxColumn
            // 
            this.direccionParticularDataGridViewTextBoxColumn.DataPropertyName = "DireccionParticular";
            this.direccionParticularDataGridViewTextBoxColumn.HeaderText = "DireccionParticular";
            this.direccionParticularDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.direccionParticularDataGridViewTextBoxColumn.Name = "direccionParticularDataGridViewTextBoxColumn";
            this.direccionParticularDataGridViewTextBoxColumn.Width = 150;
            // 
            // Prestamo
            // 
            this.Prestamo.HeaderText = "Prestamo";
            this.Prestamo.MinimumWidth = 8;
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.Width = 150;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ISBNAutorTableAdapter = null;
            this.tableAdapterManager.LibrosTableAdapter = null;
            this.tableAdapterManager.NivelDeAccesoTableAdapter = null;
            this.tableAdapterManager.PrestamosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(39, 575);
            this.buscar_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(76, 32);
            this.buscar_Btn.TabIndex = 1;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
            // 
            // eliminar_Btn
            // 
            this.eliminar_Btn.Enabled = false;
            this.eliminar_Btn.Location = new System.Drawing.Point(861, 575);
            this.eliminar_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eliminar_Btn.Name = "eliminar_Btn";
            this.eliminar_Btn.Size = new System.Drawing.Size(116, 32);
            this.eliminar_Btn.TabIndex = 2;
            this.eliminar_Btn.Text = "Eliminar Usuario";
            this.eliminar_Btn.UseVisualStyleBackColor = true;
            this.eliminar_Btn.Click += new System.EventHandler(this.eliminar_Btn_Click);
            // 
            // buscar_Tbx
            // 
            this.buscar_Tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_Tbx.Location = new System.Drawing.Point(119, 582);
            this.buscar_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buscar_Tbx.Name = "buscar_Tbx";
            this.buscar_Tbx.Size = new System.Drawing.Size(197, 23);
            this.buscar_Tbx.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(985, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.registrarToolStripMenuItem.Text = "Registrar Usuario";
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario ";
            // 
            // tipoDeBusqueda_Lbl
            // 
            this.tipoDeBusqueda_Lbl.AutoSize = true;
            this.tipoDeBusqueda_Lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDeBusqueda_Lbl.Location = new System.Drawing.Point(36, 547);
            this.tipoDeBusqueda_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipoDeBusqueda_Lbl.Name = "tipoDeBusqueda_Lbl";
            this.tipoDeBusqueda_Lbl.Size = new System.Drawing.Size(124, 19);
            this.tipoDeBusqueda_Lbl.TabIndex = 8;
            this.tipoDeBusqueda_Lbl.Text = "Tipo de búsqueda: ";
            // 
            // tipoDeBusqueda_Cbx
            // 
            this.tipoDeBusqueda_Cbx.FormattingEnabled = true;
            this.tipoDeBusqueda_Cbx.Items.AddRange(new object[] {
            "IdUsuario",
            "RFC",
            "Eliminación "});
            this.tipoDeBusqueda_Cbx.Location = new System.Drawing.Point(161, 548);
            this.tipoDeBusqueda_Cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoDeBusqueda_Cbx.Name = "tipoDeBusqueda_Cbx";
            this.tipoDeBusqueda_Cbx.Size = new System.Drawing.Size(161, 21);
            this.tipoDeBusqueda_Cbx.TabIndex = 9;
            this.tipoDeBusqueda_Cbx.Text = "Seleccione tipo de búsqueda";
            this.tipoDeBusqueda_Cbx.SelectedIndexChanged += new System.EventHandler(this.tipoDeBusqueda_Cbx_SelectedIndexChanged);
            // 
            // ControlDeUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 638);
            this.Controls.Add(this.tipoDeBusqueda_Cbx);
            this.Controls.Add(this.tipoDeBusqueda_Lbl);
            this.Controls.Add(this.buscar_Tbx);
            this.Controls.Add(this.eliminar_Btn);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ControlDeUsuariosForm";
            this.Text = "Control de Usuarios";
            this.Load += new System.EventHandler(this.VistaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BibliotecaDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.Button eliminar_Btn;
        private System.Windows.Forms.TextBox buscar_Tbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Label tipoDeBusqueda_Lbl;
        private System.Windows.Forms.ComboBox tipoDeBusqueda_Cbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeNivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionParticularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
    }
}