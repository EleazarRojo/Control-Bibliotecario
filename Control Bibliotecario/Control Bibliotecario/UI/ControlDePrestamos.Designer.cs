
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.prestamosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.PrestamosTableAdapter();
            this.tableAdapterManager = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.folioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizarPrestamo_Btn = new System.Windows.Forms.Button();
            this.IdUsuario_lbl = new System.Windows.Forms.Label();
            this.IdUsuario_Tbx = new System.Windows.Forms.TextBox();
            this.ISBN_lbl = new System.Windows.Forms.Label();
            this.ISBN_Tbx = new System.Windows.Forms.TextBox();
            this.devolverPrestamo_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.idUsuarioDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.fechaInicialDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prestamosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(80, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1167, 511);
            this.dataGridView1.TabIndex = 0;
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
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "Folio";
            dataGridViewCellStyle1.Format = "0000000000";
            dataGridViewCellStyle1.NullValue = null;
            this.folioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.folioDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.folioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            this.folioDataGridViewTextBoxColumn.Width = 150;
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
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // realizarPrestamo_Btn
            // 
            this.realizarPrestamo_Btn.Enabled = false;
            this.realizarPrestamo_Btn.Location = new System.Drawing.Point(981, 687);
            this.realizarPrestamo_Btn.Name = "realizarPrestamo_Btn";
            this.realizarPrestamo_Btn.Size = new System.Drawing.Size(156, 49);
            this.realizarPrestamo_Btn.TabIndex = 1;
            this.realizarPrestamo_Btn.Text = "Realizar Prestamo";
            this.realizarPrestamo_Btn.UseVisualStyleBackColor = true;
            // 
            // IdUsuario_lbl
            // 
            this.IdUsuario_lbl.AutoSize = true;
            this.IdUsuario_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuario_lbl.Location = new System.Drawing.Point(75, 572);
            this.IdUsuario_lbl.Name = "IdUsuario_lbl";
            this.IdUsuario_lbl.Size = new System.Drawing.Size(124, 27);
            this.IdUsuario_lbl.TabIndex = 2;
            this.IdUsuario_lbl.Text = "Id Usuario: ";
            // 
            // IdUsuario_Tbx
            // 
            this.IdUsuario_Tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuario_Tbx.Location = new System.Drawing.Point(205, 572);
            this.IdUsuario_Tbx.Name = "IdUsuario_Tbx";
            this.IdUsuario_Tbx.Size = new System.Drawing.Size(254, 30);
            this.IdUsuario_Tbx.TabIndex = 3;
            // 
            // ISBN_lbl
            // 
            this.ISBN_lbl.AutoSize = true;
            this.ISBN_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_lbl.Location = new System.Drawing.Point(75, 632);
            this.ISBN_lbl.Name = "ISBN_lbl";
            this.ISBN_lbl.Size = new System.Drawing.Size(77, 27);
            this.ISBN_lbl.TabIndex = 4;
            this.ISBN_lbl.Text = "ISBN: ";
            // 
            // ISBN_Tbx
            // 
            this.ISBN_Tbx.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_Tbx.Location = new System.Drawing.Point(205, 629);
            this.ISBN_Tbx.Name = "ISBN_Tbx";
            this.ISBN_Tbx.Size = new System.Drawing.Size(254, 30);
            this.ISBN_Tbx.TabIndex = 5;
            // 
            // devolverPrestamo_Btn
            // 
            this.devolverPrestamo_Btn.Enabled = false;
            this.devolverPrestamo_Btn.Location = new System.Drawing.Point(1165, 687);
            this.devolverPrestamo_Btn.Name = "devolverPrestamo_Btn";
            this.devolverPrestamo_Btn.Size = new System.Drawing.Size(156, 49);
            this.devolverPrestamo_Btn.TabIndex = 6;
            this.devolverPrestamo_Btn.Text = "Devolver Prestamo";
            this.devolverPrestamo_Btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 687);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ControlDePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 763);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.devolverPrestamo_Btn);
            this.Controls.Add(this.ISBN_Tbx);
            this.Controls.Add(this.ISBN_lbl);
            this.Controls.Add(this.IdUsuario_Tbx);
            this.Controls.Add(this.IdUsuario_lbl);
            this.Controls.Add(this.realizarPrestamo_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ControlDePrestamos";
            this.Text = "ControlDePrestamos";
            this.Load += new System.EventHandler(this.ControlDePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button realizarPrestamo_Btn;
        private System.Windows.Forms.Label IdUsuario_lbl;
        private System.Windows.Forms.TextBox IdUsuario_Tbx;
        private System.Windows.Forms.Label ISBN_lbl;
        private System.Windows.Forms.TextBox ISBN_Tbx;
        private System.Windows.Forms.Button devolverPrestamo_Btn;
        private System.Windows.Forms.Button button1;
    }
}