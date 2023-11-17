
namespace Control_Bibliotecario.UI
{
    partial class DevolverPrestamoForm
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
            this.idUsario_lbl = new System.Windows.Forms.Label();
            this.idUsuario_tbx = new System.Windows.Forms.TextBox();
            this.iSBN_tbx = new System.Windows.Forms.TextBox();
            this.iSBN_lbl = new System.Windows.Forms.Label();
            this.idCopia_tbx = new System.Windows.Forms.TextBox();
            this.idCopia_lbl = new System.Windows.Forms.Label();
            this.devolver_btn = new System.Windows.Forms.Button();
            this.autor_tbx = new System.Windows.Forms.TextBox();
            this.autor_lbl = new System.Windows.Forms.Label();
            this.nombreLibro_tbx = new System.Windows.Forms.TextBox();
            this.nombreLibro_lbl = new System.Windows.Forms.Label();
            this.buscarPrestamo_btn = new System.Windows.Forms.Button();
            this.prestamosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCopia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.prestamosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idUsario_lbl
            // 
            this.idUsario_lbl.AutoSize = true;
            this.idUsario_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsario_lbl.Location = new System.Drawing.Point(12, 253);
            this.idUsario_lbl.Name = "idUsario_lbl";
            this.idUsario_lbl.Size = new System.Drawing.Size(76, 19);
            this.idUsario_lbl.TabIndex = 0;
            this.idUsario_lbl.Text = "Id Usuario:";
            // 
            // idUsuario_tbx
            // 
            this.idUsuario_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuario_tbx.Location = new System.Drawing.Point(94, 250);
            this.idUsuario_tbx.Name = "idUsuario_tbx";
            this.idUsuario_tbx.Size = new System.Drawing.Size(137, 26);
            this.idUsuario_tbx.TabIndex = 1;
            // 
            // iSBN_tbx
            // 
            this.iSBN_tbx.Enabled = false;
            this.iSBN_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBN_tbx.Location = new System.Drawing.Point(135, 318);
            this.iSBN_tbx.Name = "iSBN_tbx";
            this.iSBN_tbx.ReadOnly = true;
            this.iSBN_tbx.Size = new System.Drawing.Size(323, 26);
            this.iSBN_tbx.TabIndex = 3;
            this.iSBN_tbx.Visible = false;
            // 
            // iSBN_lbl
            // 
            this.iSBN_lbl.AutoSize = true;
            this.iSBN_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBN_lbl.Location = new System.Drawing.Point(12, 325);
            this.iSBN_lbl.Name = "iSBN_lbl";
            this.iSBN_lbl.Size = new System.Drawing.Size(48, 19);
            this.iSBN_lbl.TabIndex = 2;
            this.iSBN_lbl.Text = "ISBN:";
            this.iSBN_lbl.Visible = false;
            // 
            // idCopia_tbx
            // 
            this.idCopia_tbx.Enabled = false;
            this.idCopia_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCopia_tbx.Location = new System.Drawing.Point(135, 356);
            this.idCopia_tbx.Name = "idCopia_tbx";
            this.idCopia_tbx.ReadOnly = true;
            this.idCopia_tbx.Size = new System.Drawing.Size(323, 26);
            this.idCopia_tbx.TabIndex = 7;
            this.idCopia_tbx.Visible = false;
            // 
            // idCopia_lbl
            // 
            this.idCopia_lbl.AutoSize = true;
            this.idCopia_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCopia_lbl.Location = new System.Drawing.Point(13, 359);
            this.idCopia_lbl.Name = "idCopia_lbl";
            this.idCopia_lbl.Size = new System.Drawing.Size(66, 19);
            this.idCopia_lbl.TabIndex = 6;
            this.idCopia_lbl.Text = "Id Copia:";
            this.idCopia_lbl.Visible = false;
            // 
            // devolver_btn
            // 
            this.devolver_btn.Enabled = false;
            this.devolver_btn.Location = new System.Drawing.Point(745, 320);
            this.devolver_btn.Name = "devolver_btn";
            this.devolver_btn.Size = new System.Drawing.Size(107, 23);
            this.devolver_btn.TabIndex = 8;
            this.devolver_btn.Text = "Devolver Prestamo";
            this.devolver_btn.UseVisualStyleBackColor = true;
            this.devolver_btn.Click += new System.EventHandler(this.devolver_btn_Click);
            // 
            // autor_tbx
            // 
            this.autor_tbx.Enabled = false;
            this.autor_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor_tbx.Location = new System.Drawing.Point(135, 449);
            this.autor_tbx.Name = "autor_tbx";
            this.autor_tbx.ReadOnly = true;
            this.autor_tbx.Size = new System.Drawing.Size(323, 26);
            this.autor_tbx.TabIndex = 23;
            this.autor_tbx.Visible = false;
            // 
            // autor_lbl
            // 
            this.autor_lbl.AutoSize = true;
            this.autor_lbl.Enabled = false;
            this.autor_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor_lbl.Location = new System.Drawing.Point(13, 452);
            this.autor_lbl.Name = "autor_lbl";
            this.autor_lbl.Size = new System.Drawing.Size(47, 19);
            this.autor_lbl.TabIndex = 22;
            this.autor_lbl.Text = "Autor:";
            this.autor_lbl.Visible = false;
            // 
            // nombreLibro_tbx
            // 
            this.nombreLibro_tbx.Enabled = false;
            this.nombreLibro_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLibro_tbx.Location = new System.Drawing.Point(135, 402);
            this.nombreLibro_tbx.Name = "nombreLibro_tbx";
            this.nombreLibro_tbx.ReadOnly = true;
            this.nombreLibro_tbx.Size = new System.Drawing.Size(323, 26);
            this.nombreLibro_tbx.TabIndex = 21;
            this.nombreLibro_tbx.Visible = false;
            // 
            // nombreLibro_lbl
            // 
            this.nombreLibro_lbl.AutoSize = true;
            this.nombreLibro_lbl.Enabled = false;
            this.nombreLibro_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLibro_lbl.Location = new System.Drawing.Point(13, 405);
            this.nombreLibro_lbl.Name = "nombreLibro_lbl";
            this.nombreLibro_lbl.Size = new System.Drawing.Size(116, 19);
            this.nombreLibro_lbl.TabIndex = 20;
            this.nombreLibro_lbl.Text = "Nombre del libro:";
            this.nombreLibro_lbl.Visible = false;
            // 
            // buscarPrestamo_btn
            // 
            this.buscarPrestamo_btn.Location = new System.Drawing.Point(745, 252);
            this.buscarPrestamo_btn.Name = "buscarPrestamo_btn";
            this.buscarPrestamo_btn.Size = new System.Drawing.Size(107, 23);
            this.buscarPrestamo_btn.TabIndex = 24;
            this.buscarPrestamo_btn.Text = "Buscar Prestamo";
            this.buscarPrestamo_btn.UseVisualStyleBackColor = true;
            this.buscarPrestamo_btn.Click += new System.EventHandler(this.buscarPrestamo_btn_Click);
            // 
            // prestamosDataGridView
            // 
            this.prestamosDataGridView.AutoGenerateColumns = false;
            this.prestamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn1,
            this.IdCopia,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.prestamosDataGridView.DataSource = this.prestamosBindingSource;
            this.prestamosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.prestamosDataGridView.Name = "prestamosDataGridView";
            this.prestamosDataGridView.ReadOnly = true;
            this.prestamosDataGridView.RowHeadersWidth = 62;
            this.prestamosDataGridView.Size = new System.Drawing.Size(840, 220);
            this.prestamosDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Folio";
            this.dataGridViewTextBoxColumn8.HeaderText = "Folio";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // IdCopia
            // 
            this.IdCopia.DataPropertyName = "IdCopia";
            this.IdCopia.HeaderText = "IdCopia";
            this.IdCopia.MinimumWidth = 8;
            this.IdCopia.Name = "IdCopia";
            this.IdCopia.ReadOnly = true;
            this.IdCopia.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaInicial";
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaInicial";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaDevolucion";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaDevolucion";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
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
            // DevolverPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 291);
            this.Controls.Add(this.buscarPrestamo_btn);
            this.Controls.Add(this.autor_tbx);
            this.Controls.Add(this.autor_lbl);
            this.Controls.Add(this.nombreLibro_tbx);
            this.Controls.Add(this.nombreLibro_lbl);
            this.Controls.Add(this.prestamosDataGridView);
            this.Controls.Add(this.devolver_btn);
            this.Controls.Add(this.idCopia_tbx);
            this.Controls.Add(this.idCopia_lbl);
            this.Controls.Add(this.iSBN_tbx);
            this.Controls.Add(this.iSBN_lbl);
            this.Controls.Add(this.idUsuario_tbx);
            this.Controls.Add(this.idUsario_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DevolverPrestamoForm";
            this.Text = "Devolver Prestamo";
            this.Load += new System.EventHandler(this.DevolverPrestamoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idUsario_lbl;
        private System.Windows.Forms.TextBox idUsuario_tbx;
        private System.Windows.Forms.TextBox iSBN_tbx;
        private System.Windows.Forms.Label iSBN_lbl;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.TextBox idCopia_tbx;
        private System.Windows.Forms.Label idCopia_lbl;
        private System.Windows.Forms.Button devolver_btn;
        private BibliotecaDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private System.Windows.Forms.TextBox autor_tbx;
        private System.Windows.Forms.Label autor_lbl;
        private System.Windows.Forms.TextBox nombreLibro_tbx;
        private System.Windows.Forms.Label nombreLibro_lbl;
        private System.Windows.Forms.Button buscarPrestamo_btn;
        private System.Windows.Forms.DataGridView prestamosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCopia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}