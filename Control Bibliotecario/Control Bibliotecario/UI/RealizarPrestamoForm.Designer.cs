
namespace Control_Bibliotecario.UI
{
    partial class RealizarPrestamoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.LibrosTableAdapter();
            this.tableAdapterManager = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizarPresatamo_btn = new System.Windows.Forms.Button();
            this.idCopia_lbl = new System.Windows.Forms.Label();
            this.iSBN_tbx = new System.Windows.Forms.TextBox();
            this.iSBN_lbl = new System.Windows.Forms.Label();
            this.idUsuario_tbx = new System.Windows.Forms.TextBox();
            this.idUsario_lbl = new System.Windows.Forms.Label();
            this.nombreLibro_tbx = new System.Windows.Forms.TextBox();
            this.nombreLibro_lbl = new System.Windows.Forms.Label();
            this.autor_tbx = new System.Windows.Forms.TextBox();
            this.autor_lbl = new System.Windows.Forms.Label();
            this.buscarLibro_btn = new System.Windows.Forms.Button();
            this.idCopia_Cbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // librosDataGridView
            // 
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.RowHeadersWidth = 62;
            this.librosDataGridView.Size = new System.Drawing.Size(843, 220);
            this.librosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumeroEdicion";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumeroEdicion";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Año";
            this.dataGridViewTextBoxColumn5.HeaderText = "Año";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tema";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tema";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdCopia";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdCopia";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EstadoPrestamo";
            this.dataGridViewTextBoxColumn8.HeaderText = "EstadoPrestamo";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // realizarPresatamo_btn
            // 
            this.realizarPresatamo_btn.Enabled = false;
            this.realizarPresatamo_btn.Location = new System.Drawing.Point(373, 363);
            this.realizarPresatamo_btn.Name = "realizarPresatamo_btn";
            this.realizarPresatamo_btn.Size = new System.Drawing.Size(107, 23);
            this.realizarPresatamo_btn.TabIndex = 15;
            this.realizarPresatamo_btn.Text = "Realizar Prestamo";
            this.realizarPresatamo_btn.UseVisualStyleBackColor = true;
            this.realizarPresatamo_btn.Visible = false;
            this.realizarPresatamo_btn.Click += new System.EventHandler(this.realizarPresatamo_btn_Click);
            // 
            // idCopia_lbl
            // 
            this.idCopia_lbl.AutoSize = true;
            this.idCopia_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCopia_lbl.Location = new System.Drawing.Point(301, 266);
            this.idCopia_lbl.Name = "idCopia_lbl";
            this.idCopia_lbl.Size = new System.Drawing.Size(66, 19);
            this.idCopia_lbl.TabIndex = 13;
            this.idCopia_lbl.Text = "Id Copia:";
            this.idCopia_lbl.Visible = false;
            // 
            // iSBN_tbx
            // 
            this.iSBN_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBN_tbx.Location = new System.Drawing.Point(61, 265);
            this.iSBN_tbx.Name = "iSBN_tbx";
            this.iSBN_tbx.Size = new System.Drawing.Size(185, 26);
            this.iSBN_tbx.TabIndex = 12;
            // 
            // iSBN_lbl
            // 
            this.iSBN_lbl.AutoSize = true;
            this.iSBN_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBN_lbl.Location = new System.Drawing.Point(9, 265);
            this.iSBN_lbl.Name = "iSBN_lbl";
            this.iSBN_lbl.Size = new System.Drawing.Size(48, 19);
            this.iSBN_lbl.TabIndex = 11;
            this.iSBN_lbl.Text = "ISBN:";
            // 
            // idUsuario_tbx
            // 
            this.idUsuario_tbx.Enabled = false;
            this.idUsuario_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuario_tbx.Location = new System.Drawing.Point(134, 363);
            this.idUsuario_tbx.Name = "idUsuario_tbx";
            this.idUsuario_tbx.Size = new System.Drawing.Size(185, 26);
            this.idUsuario_tbx.TabIndex = 10;
            this.idUsuario_tbx.Visible = false;
            // 
            // idUsario_lbl
            // 
            this.idUsario_lbl.AutoSize = true;
            this.idUsario_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsario_lbl.Location = new System.Drawing.Point(9, 363);
            this.idUsario_lbl.Name = "idUsario_lbl";
            this.idUsario_lbl.Size = new System.Drawing.Size(76, 19);
            this.idUsario_lbl.TabIndex = 9;
            this.idUsario_lbl.Text = "Id Usuario:";
            this.idUsario_lbl.Visible = false;
            // 
            // nombreLibro_tbx
            // 
            this.nombreLibro_tbx.Enabled = false;
            this.nombreLibro_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLibro_tbx.Location = new System.Drawing.Point(135, 409);
            this.nombreLibro_tbx.Name = "nombreLibro_tbx";
            this.nombreLibro_tbx.ReadOnly = true;
            this.nombreLibro_tbx.Size = new System.Drawing.Size(185, 26);
            this.nombreLibro_tbx.TabIndex = 17;
            this.nombreLibro_tbx.Visible = false;
            // 
            // nombreLibro_lbl
            // 
            this.nombreLibro_lbl.AutoSize = true;
            this.nombreLibro_lbl.Enabled = false;
            this.nombreLibro_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLibro_lbl.Location = new System.Drawing.Point(9, 409);
            this.nombreLibro_lbl.Name = "nombreLibro_lbl";
            this.nombreLibro_lbl.Size = new System.Drawing.Size(116, 19);
            this.nombreLibro_lbl.TabIndex = 16;
            this.nombreLibro_lbl.Text = "Nombre del libro:";
            this.nombreLibro_lbl.Visible = false;
            // 
            // autor_tbx
            // 
            this.autor_tbx.Enabled = false;
            this.autor_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor_tbx.Location = new System.Drawing.Point(134, 448);
            this.autor_tbx.Name = "autor_tbx";
            this.autor_tbx.ReadOnly = true;
            this.autor_tbx.Size = new System.Drawing.Size(185, 26);
            this.autor_tbx.TabIndex = 19;
            this.autor_tbx.Visible = false;
            // 
            // autor_lbl
            // 
            this.autor_lbl.AutoSize = true;
            this.autor_lbl.Enabled = false;
            this.autor_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor_lbl.Location = new System.Drawing.Point(9, 450);
            this.autor_lbl.Name = "autor_lbl";
            this.autor_lbl.Size = new System.Drawing.Size(47, 19);
            this.autor_lbl.TabIndex = 18;
            this.autor_lbl.Text = "Autor:";
            this.autor_lbl.Visible = false;
            // 
            // buscarLibro_btn
            // 
            this.buscarLibro_btn.Location = new System.Drawing.Point(728, 263);
            this.buscarLibro_btn.Name = "buscarLibro_btn";
            this.buscarLibro_btn.Size = new System.Drawing.Size(107, 23);
            this.buscarLibro_btn.TabIndex = 20;
            this.buscarLibro_btn.Text = "Buscar Libro";
            this.buscarLibro_btn.UseVisualStyleBackColor = true;
            this.buscarLibro_btn.Click += new System.EventHandler(this.buscarLibro_btn_Click);
            // 
            // idCopia_Cbx
            // 
            this.idCopia_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCopia_Cbx.FormattingEnabled = true;
            this.idCopia_Cbx.Location = new System.Drawing.Point(373, 266);
            this.idCopia_Cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idCopia_Cbx.Name = "idCopia_Cbx";
            this.idCopia_Cbx.Size = new System.Drawing.Size(128, 21);
            this.idCopia_Cbx.TabIndex = 21;
            this.idCopia_Cbx.Visible = false;
            // 
            // RealizarPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 311);
            this.Controls.Add(this.idCopia_Cbx);
            this.Controls.Add(this.buscarLibro_btn);
            this.Controls.Add(this.autor_tbx);
            this.Controls.Add(this.autor_lbl);
            this.Controls.Add(this.nombreLibro_tbx);
            this.Controls.Add(this.nombreLibro_lbl);
            this.Controls.Add(this.realizarPresatamo_btn);
            this.Controls.Add(this.idCopia_lbl);
            this.Controls.Add(this.iSBN_tbx);
            this.Controls.Add(this.iSBN_lbl);
            this.Controls.Add(this.idUsuario_tbx);
            this.Controls.Add(this.idUsario_lbl);
            this.Controls.Add(this.librosDataGridView);
            this.MaximizeBox = false;
            this.Name = "RealizarPrestamoForm";
            this.Text = "Realizar Prestamo";
            this.Load += new System.EventHandler(this.RealizarPrestamoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.Button realizarPresatamo_btn;
        private System.Windows.Forms.Label idCopia_lbl;
        private System.Windows.Forms.TextBox iSBN_tbx;
        private System.Windows.Forms.Label iSBN_lbl;
        private System.Windows.Forms.TextBox idUsuario_tbx;
        private System.Windows.Forms.Label idUsario_lbl;
        private System.Windows.Forms.TextBox nombreLibro_tbx;
        private System.Windows.Forms.Label nombreLibro_lbl;
        private System.Windows.Forms.TextBox autor_tbx;
        private System.Windows.Forms.Label autor_lbl;
        private System.Windows.Forms.Button buscarLibro_btn;
        private System.Windows.Forms.ComboBox idCopia_Cbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}