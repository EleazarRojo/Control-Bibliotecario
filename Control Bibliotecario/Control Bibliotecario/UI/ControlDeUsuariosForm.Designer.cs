
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Contrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.eliminar_Btn = new System.Windows.Forms.Button();
            this.buscar_Tbx = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeBusqueda_Lbl = new System.Windows.Forms.Label();
            this.tipoDeBusqueda_Cbx = new System.Windows.Forms.ComboBox();
            this.IdUsuario_lbl = new System.Windows.Forms.Label();
            this.rFC_lbl = new System.Windows.Forms.Label();
            this.idNivel_lbl = new System.Windows.Forms.Label();
            this.idUsuario_tbx = new System.Windows.Forms.TextBox();
            this.rFC_tbx = new System.Windows.Forms.TextBox();
            this.nombre_lbl = new System.Windows.Forms.Label();
            this.nombre_tbx = new System.Windows.Forms.TextBox();
            this.apellidoPaterno_lbl = new System.Windows.Forms.Label();
            this.apellidoPaterno_tbx = new System.Windows.Forms.TextBox();
            this.apellidoMaterno_tbx = new System.Windows.Forms.TextBox();
            this.apellidoMaterno_lbl = new System.Windows.Forms.Label();
            this.genero_lbl = new System.Windows.Forms.Label();
            this.edad_lbl = new System.Windows.Forms.Label();
            this.fechaDeNacimiento_lbl = new System.Windows.Forms.Label();
            this.fechaDeNacimiento_tbx = new System.Windows.Forms.TextBox();
            this.edad_tbx = new System.Windows.Forms.TextBox();
            this.genero_tbx = new System.Windows.Forms.TextBox();
            this.aceptarModificacion_btn = new System.Windows.Forms.Button();
            this.regresar_btn = new System.Windows.Forms.Button();
            this.usuariosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.direccion_tbx = new System.Windows.Forms.TextBox();
            this.direccion_lbl = new System.Windows.Forms.Label();
            this.idNivel_Cbx = new System.Windows.Forms.ComboBox();
            this.contraseña_tbx = new System.Windows.Forms.TextBox();
            this.contraseña_lbl = new System.Windows.Forms.Label();
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
            this.Contrasenia});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(977, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            dataGridViewCellStyle1.Format = "000000";
            dataGridViewCellStyle1.NullValue = null;
            this.idUsuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idUsuarioDataGridViewTextBoxColumn.Frozen = true;
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            this.rFCDataGridViewTextBoxColumn.ReadOnly = true;
            this.rFCDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDeNivelDataGridViewTextBoxColumn
            // 
            this.idDeNivelDataGridViewTextBoxColumn.DataPropertyName = "IdDeNivel";
            this.idDeNivelDataGridViewTextBoxColumn.HeaderText = "IdDeNivel";
            this.idDeNivelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDeNivelDataGridViewTextBoxColumn.Name = "idDeNivelDataGridViewTextBoxColumn";
            this.idDeNivelDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDeNivelDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            this.apellidoPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoPaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            this.apellidoMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoMaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDeNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaDeNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaDeNacimiento";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaDeNacimiento";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaDeNacimientoDataGridViewTextBoxColumn.Name = "fechaDeNacimientoDataGridViewTextBoxColumn";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDeNacimientoDataGridViewTextBoxColumn.Width = 150;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Width = 150;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionParticularDataGridViewTextBoxColumn
            // 
            this.direccionParticularDataGridViewTextBoxColumn.DataPropertyName = "DireccionParticular";
            this.direccionParticularDataGridViewTextBoxColumn.HeaderText = "DireccionParticular";
            this.direccionParticularDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.direccionParticularDataGridViewTextBoxColumn.Name = "direccionParticularDataGridViewTextBoxColumn";
            this.direccionParticularDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionParticularDataGridViewTextBoxColumn.Width = 150;
            // 
            // Contrasenia
            // 
            this.Contrasenia.DataPropertyName = "Contrasenia";
            this.Contrasenia.HeaderText = "Contraseña";
            this.Contrasenia.MinimumWidth = 8;
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.ReadOnly = true;
            this.Contrasenia.Width = 150;
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
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(39, 575);
            this.buscar_Btn.Margin = new System.Windows.Forms.Padding(2);
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
            this.eliminar_Btn.Location = new System.Drawing.Point(839, 575);
            this.eliminar_Btn.Margin = new System.Windows.Forms.Padding(2);
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
            this.buscar_Tbx.Margin = new System.Windows.Forms.Padding(2);
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
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.registrarColaboradorToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(994, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.registrarToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // registrarColaboradorToolStripMenuItem
            // 
            this.registrarColaboradorToolStripMenuItem.Name = "registrarColaboradorToolStripMenuItem";
            this.registrarColaboradorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.registrarColaboradorToolStripMenuItem.Text = "Registrar Colaborador";
            this.registrarColaboradorToolStripMenuItem.Click += new System.EventHandler(this.registrarColaboradorToolStripMenuItem_Click);
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
            "Eliminación ",
            "Modificar Usuario"});
            this.tipoDeBusqueda_Cbx.Location = new System.Drawing.Point(161, 548);
            this.tipoDeBusqueda_Cbx.Margin = new System.Windows.Forms.Padding(2);
            this.tipoDeBusqueda_Cbx.Name = "tipoDeBusqueda_Cbx";
            this.tipoDeBusqueda_Cbx.Size = new System.Drawing.Size(161, 21);
            this.tipoDeBusqueda_Cbx.TabIndex = 9;
            this.tipoDeBusqueda_Cbx.Text = "Seleccione tipo de búsqueda";
            this.tipoDeBusqueda_Cbx.SelectedIndexChanged += new System.EventHandler(this.tipoDeBusqueda_Cbx_SelectedIndexChanged);
            // 
            // IdUsuario_lbl
            // 
            this.IdUsuario_lbl.AutoSize = true;
            this.IdUsuario_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuario_lbl.Location = new System.Drawing.Point(36, 635);
            this.IdUsuario_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdUsuario_lbl.Name = "IdUsuario_lbl";
            this.IdUsuario_lbl.Size = new System.Drawing.Size(76, 19);
            this.IdUsuario_lbl.TabIndex = 10;
            this.IdUsuario_lbl.Text = "Id Usuario:";
            // 
            // rFC_lbl
            // 
            this.rFC_lbl.AutoSize = true;
            this.rFC_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFC_lbl.Location = new System.Drawing.Point(36, 668);
            this.rFC_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rFC_lbl.Name = "rFC_lbl";
            this.rFC_lbl.Size = new System.Drawing.Size(42, 19);
            this.rFC_lbl.TabIndex = 11;
            this.rFC_lbl.Text = "RFC:";
            // 
            // idNivel_lbl
            // 
            this.idNivel_lbl.AutoSize = true;
            this.idNivel_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNivel_lbl.Location = new System.Drawing.Point(31, 700);
            this.idNivel_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idNivel_lbl.Name = "idNivel_lbl";
            this.idNivel_lbl.Size = new System.Drawing.Size(80, 19);
            this.idNivel_lbl.TabIndex = 12;
            this.idNivel_lbl.Text = "Id de Nivel:";
            // 
            // idUsuario_tbx
            // 
            this.idUsuario_tbx.Enabled = false;
            this.idUsuario_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuario_tbx.Location = new System.Drawing.Point(119, 633);
            this.idUsuario_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.idUsuario_tbx.Name = "idUsuario_tbx";
            this.idUsuario_tbx.Size = new System.Drawing.Size(197, 23);
            this.idUsuario_tbx.TabIndex = 13;
            // 
            // rFC_tbx
            // 
            this.rFC_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFC_tbx.Location = new System.Drawing.Point(119, 668);
            this.rFC_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.rFC_tbx.Name = "rFC_tbx";
            this.rFC_tbx.Size = new System.Drawing.Size(197, 23);
            this.rFC_tbx.TabIndex = 14;
            // 
            // nombre_lbl
            // 
            this.nombre_lbl.AutoSize = true;
            this.nombre_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_lbl.Location = new System.Drawing.Point(351, 633);
            this.nombre_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre_lbl.Name = "nombre_lbl";
            this.nombre_lbl.Size = new System.Drawing.Size(79, 19);
            this.nombre_lbl.TabIndex = 16;
            this.nombre_lbl.Text = "Nombre(s):";
            // 
            // nombre_tbx
            // 
            this.nombre_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_tbx.Location = new System.Drawing.Point(479, 633);
            this.nombre_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_tbx.Name = "nombre_tbx";
            this.nombre_tbx.Size = new System.Drawing.Size(197, 23);
            this.nombre_tbx.TabIndex = 17;
            // 
            // apellidoPaterno_lbl
            // 
            this.apellidoPaterno_lbl.AutoSize = true;
            this.apellidoPaterno_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoPaterno_lbl.Location = new System.Drawing.Point(351, 668);
            this.apellidoPaterno_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellidoPaterno_lbl.Name = "apellidoPaterno_lbl";
            this.apellidoPaterno_lbl.Size = new System.Drawing.Size(113, 19);
            this.apellidoPaterno_lbl.TabIndex = 18;
            this.apellidoPaterno_lbl.Text = "Apellida Paterno:";
            // 
            // apellidoPaterno_tbx
            // 
            this.apellidoPaterno_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoPaterno_tbx.Location = new System.Drawing.Point(479, 668);
            this.apellidoPaterno_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.apellidoPaterno_tbx.Name = "apellidoPaterno_tbx";
            this.apellidoPaterno_tbx.Size = new System.Drawing.Size(197, 23);
            this.apellidoPaterno_tbx.TabIndex = 19;
            // 
            // apellidoMaterno_tbx
            // 
            this.apellidoMaterno_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoMaterno_tbx.Location = new System.Drawing.Point(479, 701);
            this.apellidoMaterno_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.apellidoMaterno_tbx.Name = "apellidoMaterno_tbx";
            this.apellidoMaterno_tbx.Size = new System.Drawing.Size(197, 23);
            this.apellidoMaterno_tbx.TabIndex = 21;
            // 
            // apellidoMaterno_lbl
            // 
            this.apellidoMaterno_lbl.AutoSize = true;
            this.apellidoMaterno_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoMaterno_lbl.Location = new System.Drawing.Point(351, 700);
            this.apellidoMaterno_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellidoMaterno_lbl.Name = "apellidoMaterno_lbl";
            this.apellidoMaterno_lbl.Size = new System.Drawing.Size(118, 19);
            this.apellidoMaterno_lbl.TabIndex = 20;
            this.apellidoMaterno_lbl.Text = "Apellida Materno:";
            // 
            // genero_lbl
            // 
            this.genero_lbl.AutoSize = true;
            this.genero_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero_lbl.Location = new System.Drawing.Point(721, 707);
            this.genero_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genero_lbl.Name = "genero_lbl";
            this.genero_lbl.Size = new System.Drawing.Size(57, 19);
            this.genero_lbl.TabIndex = 24;
            this.genero_lbl.Text = "Genero:";
            // 
            // edad_lbl
            // 
            this.edad_lbl.AutoSize = true;
            this.edad_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad_lbl.Location = new System.Drawing.Point(721, 669);
            this.edad_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edad_lbl.Name = "edad_lbl";
            this.edad_lbl.Size = new System.Drawing.Size(44, 19);
            this.edad_lbl.TabIndex = 23;
            this.edad_lbl.Text = "Edad:";
            // 
            // fechaDeNacimiento_lbl
            // 
            this.fechaDeNacimiento_lbl.AutoSize = true;
            this.fechaDeNacimiento_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDeNacimiento_lbl.Location = new System.Drawing.Point(721, 632);
            this.fechaDeNacimiento_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaDeNacimiento_lbl.Name = "fechaDeNacimiento_lbl";
            this.fechaDeNacimiento_lbl.Size = new System.Drawing.Size(136, 19);
            this.fechaDeNacimiento_lbl.TabIndex = 22;
            this.fechaDeNacimiento_lbl.Text = "Fecha de nacimiento:";
            // 
            // fechaDeNacimiento_tbx
            // 
            this.fechaDeNacimiento_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDeNacimiento_tbx.Location = new System.Drawing.Point(870, 630);
            this.fechaDeNacimiento_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.fechaDeNacimiento_tbx.Name = "fechaDeNacimiento_tbx";
            this.fechaDeNacimiento_tbx.Size = new System.Drawing.Size(86, 23);
            this.fechaDeNacimiento_tbx.TabIndex = 25;
            // 
            // edad_tbx
            // 
            this.edad_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad_tbx.Location = new System.Drawing.Point(870, 670);
            this.edad_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.edad_tbx.Name = "edad_tbx";
            this.edad_tbx.Size = new System.Drawing.Size(86, 23);
            this.edad_tbx.TabIndex = 26;
            // 
            // genero_tbx
            // 
            this.genero_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero_tbx.Location = new System.Drawing.Point(870, 705);
            this.genero_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.genero_tbx.Name = "genero_tbx";
            this.genero_tbx.Size = new System.Drawing.Size(86, 23);
            this.genero_tbx.TabIndex = 27;
            // 
            // aceptarModificacion_btn
            // 
            this.aceptarModificacion_btn.Location = new System.Drawing.Point(769, 761);
            this.aceptarModificacion_btn.Margin = new System.Windows.Forms.Padding(2);
            this.aceptarModificacion_btn.Name = "aceptarModificacion_btn";
            this.aceptarModificacion_btn.Size = new System.Drawing.Size(186, 32);
            this.aceptarModificacion_btn.TabIndex = 29;
            this.aceptarModificacion_btn.Text = "Aceptar Modificacion Usuario";
            this.aceptarModificacion_btn.UseVisualStyleBackColor = true;
            this.aceptarModificacion_btn.Click += new System.EventHandler(this.aceptarModificacion_btn_Click);
            // 
            // regresar_btn
            // 
            this.regresar_btn.Location = new System.Drawing.Point(649, 761);
            this.regresar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.regresar_btn.Name = "regresar_btn";
            this.regresar_btn.Size = new System.Drawing.Size(116, 32);
            this.regresar_btn.TabIndex = 30;
            this.regresar_btn.Text = "Regresar";
            this.regresar_btn.UseVisualStyleBackColor = true;
            this.regresar_btn.Click += new System.EventHandler(this.regresar_btn_Click);
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
            // direccion_tbx
            // 
            this.direccion_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_tbx.Location = new System.Drawing.Point(119, 731);
            this.direccion_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.direccion_tbx.Name = "direccion_tbx";
            this.direccion_tbx.Size = new System.Drawing.Size(197, 23);
            this.direccion_tbx.TabIndex = 32;
            // 
            // direccion_lbl
            // 
            this.direccion_lbl.AutoSize = true;
            this.direccion_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_lbl.Location = new System.Drawing.Point(36, 733);
            this.direccion_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.direccion_lbl.Name = "direccion_lbl";
            this.direccion_lbl.Size = new System.Drawing.Size(70, 19);
            this.direccion_lbl.TabIndex = 31;
            this.direccion_lbl.Text = "Direccion:";
            // 
            // idNivel_Cbx
            // 
            this.idNivel_Cbx.FormattingEnabled = true;
            this.idNivel_Cbx.Items.AddRange(new object[] {
            "010",
            "020",
            "003"});
            this.idNivel_Cbx.Location = new System.Drawing.Point(119, 700);
            this.idNivel_Cbx.Margin = new System.Windows.Forms.Padding(2);
            this.idNivel_Cbx.Name = "idNivel_Cbx";
            this.idNivel_Cbx.Size = new System.Drawing.Size(82, 21);
            this.idNivel_Cbx.TabIndex = 33;
            this.idNivel_Cbx.SelectedIndexChanged += new System.EventHandler(this.idNivel_Cbx_SelectedIndexChanged);
            // 
            // contraseña_tbx
            // 
            this.contraseña_tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña_tbx.Location = new System.Drawing.Point(479, 731);
            this.contraseña_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.contraseña_tbx.Name = "contraseña_tbx";
            this.contraseña_tbx.Size = new System.Drawing.Size(103, 23);
            this.contraseña_tbx.TabIndex = 35;
            this.contraseña_tbx.Visible = false;
            // 
            // contraseña_lbl
            // 
            this.contraseña_lbl.AutoSize = true;
            this.contraseña_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña_lbl.Location = new System.Drawing.Point(351, 733);
            this.contraseña_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contraseña_lbl.Name = "contraseña_lbl";
            this.contraseña_lbl.Size = new System.Drawing.Size(81, 19);
            this.contraseña_lbl.TabIndex = 34;
            this.contraseña_lbl.Text = "Contraseña:";
            this.contraseña_lbl.Visible = false;
            // 
            // ControlDeUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 621);
            this.Controls.Add(this.contraseña_tbx);
            this.Controls.Add(this.contraseña_lbl);
            this.Controls.Add(this.idNivel_Cbx);
            this.Controls.Add(this.direccion_tbx);
            this.Controls.Add(this.direccion_lbl);
            this.Controls.Add(this.regresar_btn);
            this.Controls.Add(this.aceptarModificacion_btn);
            this.Controls.Add(this.genero_tbx);
            this.Controls.Add(this.edad_tbx);
            this.Controls.Add(this.fechaDeNacimiento_tbx);
            this.Controls.Add(this.genero_lbl);
            this.Controls.Add(this.edad_lbl);
            this.Controls.Add(this.fechaDeNacimiento_lbl);
            this.Controls.Add(this.apellidoMaterno_tbx);
            this.Controls.Add(this.apellidoMaterno_lbl);
            this.Controls.Add(this.apellidoPaterno_tbx);
            this.Controls.Add(this.apellidoPaterno_lbl);
            this.Controls.Add(this.nombre_tbx);
            this.Controls.Add(this.nombre_lbl);
            this.Controls.Add(this.rFC_tbx);
            this.Controls.Add(this.idUsuario_tbx);
            this.Controls.Add(this.idNivel_lbl);
            this.Controls.Add(this.rFC_lbl);
            this.Controls.Add(this.IdUsuario_lbl);
            this.Controls.Add(this.tipoDeBusqueda_Cbx);
            this.Controls.Add(this.tipoDeBusqueda_Lbl);
            this.Controls.Add(this.buscar_Tbx);
            this.Controls.Add(this.eliminar_Btn);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ControlDeUsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label tipoDeBusqueda_Lbl;
        private System.Windows.Forms.ComboBox tipoDeBusqueda_Cbx;
        private System.Windows.Forms.ToolStripMenuItem registrarColaboradorToolStripMenuItem;
        private System.Windows.Forms.Label IdUsuario_lbl;
        private System.Windows.Forms.Label rFC_lbl;
        private System.Windows.Forms.Label idNivel_lbl;
        private System.Windows.Forms.TextBox idUsuario_tbx;
        private System.Windows.Forms.TextBox rFC_tbx;
        private System.Windows.Forms.Label nombre_lbl;
        private System.Windows.Forms.TextBox nombre_tbx;
        private System.Windows.Forms.Label apellidoPaterno_lbl;
        private System.Windows.Forms.TextBox apellidoPaterno_tbx;
        private System.Windows.Forms.TextBox apellidoMaterno_tbx;
        private System.Windows.Forms.Label apellidoMaterno_lbl;
        private System.Windows.Forms.Label genero_lbl;
        private System.Windows.Forms.Label edad_lbl;
        private System.Windows.Forms.Label fechaDeNacimiento_lbl;
        private System.Windows.Forms.TextBox fechaDeNacimiento_tbx;
        private System.Windows.Forms.TextBox edad_tbx;
        private System.Windows.Forms.TextBox genero_tbx;
        private System.Windows.Forms.Button aceptarModificacion_btn;
        private System.Windows.Forms.Button regresar_btn;
        private System.Windows.Forms.TextBox direccion_tbx;
        private System.Windows.Forms.Label direccion_lbl;
        private System.Windows.Forms.ComboBox idNivel_Cbx;
        private System.Windows.Forms.TextBox contraseña_tbx;
        private System.Windows.Forms.Label contraseña_lbl;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenia;
    }
}