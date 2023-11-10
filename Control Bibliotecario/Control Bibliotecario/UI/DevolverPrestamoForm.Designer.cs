
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolverPrestamoForm));
            this.idUsario_lbl = new System.Windows.Forms.Label();
            this.idUsuario_tbx = new System.Windows.Forms.TextBox();
            this.iSBN_tbx = new System.Windows.Forms.TextBox();
            this.iSBN_lbl = new System.Windows.Forms.Label();
            this.bibliotecaDataSet = new Control_Bibliotecario.BibliotecaDataSet();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.LibrosTableAdapter();
            this.tableAdapterManager = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.librosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.librosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCopia_tbx = new System.Windows.Forms.TextBox();
            this.idCopia_lbl = new System.Windows.Forms.Label();
            this.devolver_btn = new System.Windows.Forms.Button();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new Control_Bibliotecario.BibliotecaDataSetTableAdapters.PrestamosTableAdapter();
            this.prestamosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor_tbx = new System.Windows.Forms.TextBox();
            this.autor_lbl = new System.Windows.Forms.Label();
            this.nombreLibro_tbx = new System.Windows.Forms.TextBox();
            this.nombreLibro_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingNavigator)).BeginInit();
            this.librosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idUsario_lbl
            // 
            this.idUsario_lbl.AutoSize = true;
            this.idUsario_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsario_lbl.Location = new System.Drawing.Point(26, 309);
            this.idUsario_lbl.Name = "idUsario_lbl";
            this.idUsario_lbl.Size = new System.Drawing.Size(76, 19);
            this.idUsario_lbl.TabIndex = 0;
            this.idUsario_lbl.Text = "Id Usuario:";
            // 
            // idUsuario_tbx
            // 
            this.idUsuario_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuario_tbx.Location = new System.Drawing.Point(106, 306);
            this.idUsuario_tbx.Name = "idUsuario_tbx";
            this.idUsuario_tbx.Size = new System.Drawing.Size(100, 26);
            this.idUsuario_tbx.TabIndex = 1;
            // 
            // iSBN_tbx
            // 
            this.iSBN_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBN_tbx.Location = new System.Drawing.Point(656, 306);
            this.iSBN_tbx.Name = "iSBN_tbx";
            this.iSBN_tbx.Size = new System.Drawing.Size(100, 26);
            this.iSBN_tbx.TabIndex = 3;
            // 
            // iSBN_lbl
            // 
            this.iSBN_lbl.AutoSize = true;
            this.iSBN_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBN_lbl.Location = new System.Drawing.Point(589, 309);
            this.iSBN_lbl.Name = "iSBN_lbl";
            this.iSBN_lbl.Size = new System.Drawing.Size(48, 19);
            this.iSBN_lbl.TabIndex = 2;
            this.iSBN_lbl.Text = "ISBN:";
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
            this.tableAdapterManager.PrestamosTableAdapter = this.prestamosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Control_Bibliotecario.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // librosBindingNavigator
            // 
            this.librosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.librosBindingNavigator.BindingSource = this.librosBindingSource;
            this.librosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.librosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.librosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.librosBindingNavigatorSaveItem});
            this.librosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.librosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.librosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.librosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.librosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.librosBindingNavigator.Name = "librosBindingNavigator";
            this.librosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.librosBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.librosBindingNavigator.TabIndex = 4;
            this.librosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // librosBindingNavigatorSaveItem
            // 
            this.librosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.librosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("librosBindingNavigatorSaveItem.Image")));
            this.librosBindingNavigatorSaveItem.Name = "librosBindingNavigatorSaveItem";
            this.librosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.librosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.librosBindingNavigatorSaveItem.Click += new System.EventHandler(this.librosBindingNavigatorSaveItem_Click);
            // 
            // idCopia_tbx
            // 
            this.idCopia_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCopia_tbx.Location = new System.Drawing.Point(386, 306);
            this.idCopia_tbx.Name = "idCopia_tbx";
            this.idCopia_tbx.Size = new System.Drawing.Size(100, 26);
            this.idCopia_tbx.TabIndex = 7;
            // 
            // idCopia_lbl
            // 
            this.idCopia_lbl.AutoSize = true;
            this.idCopia_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCopia_lbl.Location = new System.Drawing.Point(306, 309);
            this.idCopia_lbl.Name = "idCopia_lbl";
            this.idCopia_lbl.Size = new System.Drawing.Size(66, 19);
            this.idCopia_lbl.TabIndex = 6;
            this.idCopia_lbl.Text = "Id Copia:";
            // 
            // devolver_btn
            // 
            this.devolver_btn.Location = new System.Drawing.Point(681, 454);
            this.devolver_btn.Name = "devolver_btn";
            this.devolver_btn.Size = new System.Drawing.Size(107, 23);
            this.devolver_btn.TabIndex = 8;
            this.devolver_btn.Text = "Devolver Prestamo";
            this.devolver_btn.UseVisualStyleBackColor = true;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // prestamosDataGridView
            // 
            this.prestamosDataGridView.AutoGenerateColumns = false;
            this.prestamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.prestamosDataGridView.DataSource = this.prestamosBindingSource;
            this.prestamosDataGridView.Location = new System.Drawing.Point(12, 40);
            this.prestamosDataGridView.Name = "prestamosDataGridView";
            this.prestamosDataGridView.Size = new System.Drawing.Size(776, 220);
            this.prestamosDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaInicial";
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaInicial";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaDevolucion";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaDevolucion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Folio";
            this.dataGridViewTextBoxColumn8.HeaderText = "Folio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // autor_tbx
            // 
            this.autor_tbx.Enabled = false;
            this.autor_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor_tbx.Location = new System.Drawing.Point(148, 448);
            this.autor_tbx.Name = "autor_tbx";
            this.autor_tbx.Size = new System.Drawing.Size(323, 26);
            this.autor_tbx.TabIndex = 23;
            // 
            // autor_lbl
            // 
            this.autor_lbl.AutoSize = true;
            this.autor_lbl.Enabled = false;
            this.autor_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor_lbl.Location = new System.Drawing.Point(26, 455);
            this.autor_lbl.Name = "autor_lbl";
            this.autor_lbl.Size = new System.Drawing.Size(47, 19);
            this.autor_lbl.TabIndex = 22;
            this.autor_lbl.Text = "Autor:";
            // 
            // nombreLibro_tbx
            // 
            this.nombreLibro_tbx.Enabled = false;
            this.nombreLibro_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLibro_tbx.Location = new System.Drawing.Point(148, 382);
            this.nombreLibro_tbx.Name = "nombreLibro_tbx";
            this.nombreLibro_tbx.Size = new System.Drawing.Size(323, 26);
            this.nombreLibro_tbx.TabIndex = 21;
            // 
            // nombreLibro_lbl
            // 
            this.nombreLibro_lbl.AutoSize = true;
            this.nombreLibro_lbl.Enabled = false;
            this.nombreLibro_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLibro_lbl.Location = new System.Drawing.Point(26, 385);
            this.nombreLibro_lbl.Name = "nombreLibro_lbl";
            this.nombreLibro_lbl.Size = new System.Drawing.Size(116, 19);
            this.nombreLibro_lbl.TabIndex = 20;
            this.nombreLibro_lbl.Text = "Nombre del libro:";
            // 
            // DevolverPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.autor_tbx);
            this.Controls.Add(this.autor_lbl);
            this.Controls.Add(this.nombreLibro_tbx);
            this.Controls.Add(this.nombreLibro_lbl);
            this.Controls.Add(this.prestamosDataGridView);
            this.Controls.Add(this.devolver_btn);
            this.Controls.Add(this.idCopia_tbx);
            this.Controls.Add(this.idCopia_lbl);
            this.Controls.Add(this.librosBindingNavigator);
            this.Controls.Add(this.iSBN_tbx);
            this.Controls.Add(this.iSBN_lbl);
            this.Controls.Add(this.idUsuario_tbx);
            this.Controls.Add(this.idUsario_lbl);
            this.Name = "DevolverPrestamoForm";
            this.Text = "DevolverPrestamoForm";
            this.Load += new System.EventHandler(this.DevolverPrestamoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingNavigator)).EndInit();
            this.librosBindingNavigator.ResumeLayout(false);
            this.librosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idUsario_lbl;
        private System.Windows.Forms.TextBox idUsuario_tbx;
        private System.Windows.Forms.TextBox iSBN_tbx;
        private System.Windows.Forms.Label iSBN_lbl;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator librosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton librosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCopia_tbx;
        private System.Windows.Forms.Label idCopia_lbl;
        private System.Windows.Forms.Button devolver_btn;
        private BibliotecaDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private System.Windows.Forms.DataGridView prestamosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox autor_tbx;
        private System.Windows.Forms.Label autor_lbl;
        private System.Windows.Forms.TextBox nombreLibro_tbx;
        private System.Windows.Forms.Label nombreLibro_lbl;
    }
}