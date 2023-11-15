
namespace Control_Bibliotecario.UI
{
    partial class IngresoAdmin
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
            this.bienvenido_Lbl = new System.Windows.Forms.Label();
            this.usuario_Tbx = new System.Windows.Forms.TextBox();
            this.usuario_Lbl = new System.Windows.Forms.Label();
            this.contrasenia_lbl = new System.Windows.Forms.Label();
            this.contrasenia_tbx = new System.Windows.Forms.TextBox();
            this.ingresar_Btn = new System.Windows.Forms.Button();
            this.mostrar_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bienvenido_Lbl
            // 
            this.bienvenido_Lbl.AutoSize = true;
            this.bienvenido_Lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenido_Lbl.Location = new System.Drawing.Point(135, 9);
            this.bienvenido_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bienvenido_Lbl.Name = "bienvenido_Lbl";
            this.bienvenido_Lbl.Size = new System.Drawing.Size(195, 41);
            this.bienvenido_Lbl.TabIndex = 0;
            this.bienvenido_Lbl.Text = "Bienvenido: ";
            this.bienvenido_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuario_Tbx
            // 
            this.usuario_Tbx.Enabled = false;
            this.usuario_Tbx.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_Tbx.Location = new System.Drawing.Point(279, 114);
            this.usuario_Tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuario_Tbx.Name = "usuario_Tbx";
            this.usuario_Tbx.ReadOnly = true;
            this.usuario_Tbx.Size = new System.Drawing.Size(211, 40);
            this.usuario_Tbx.TabIndex = 1;
            // 
            // usuario_Lbl
            // 
            this.usuario_Lbl.AutoSize = true;
            this.usuario_Lbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_Lbl.Location = new System.Drawing.Point(136, 114);
            this.usuario_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuario_Lbl.Name = "usuario_Lbl";
            this.usuario_Lbl.Size = new System.Drawing.Size(117, 33);
            this.usuario_Lbl.TabIndex = 2;
            this.usuario_Lbl.Text = "Usuario: ";
            this.usuario_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrasenia_lbl
            // 
            this.contrasenia_lbl.AutoSize = true;
            this.contrasenia_lbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenia_lbl.Location = new System.Drawing.Point(98, 258);
            this.contrasenia_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrasenia_lbl.Name = "contrasenia_lbl";
            this.contrasenia_lbl.Size = new System.Drawing.Size(155, 33);
            this.contrasenia_lbl.TabIndex = 4;
            this.contrasenia_lbl.Text = "Contraseña: ";
            this.contrasenia_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrasenia_tbx
            // 
            this.contrasenia_tbx.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenia_tbx.Location = new System.Drawing.Point(279, 255);
            this.contrasenia_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contrasenia_tbx.Name = "contrasenia_tbx";
            this.contrasenia_tbx.PasswordChar = '*';
            this.contrasenia_tbx.Size = new System.Drawing.Size(211, 40);
            this.contrasenia_tbx.TabIndex = 3;
            // 
            // ingresar_Btn
            // 
            this.ingresar_Btn.Location = new System.Drawing.Point(519, 320);
            this.ingresar_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ingresar_Btn.Name = "ingresar_Btn";
            this.ingresar_Btn.Size = new System.Drawing.Size(116, 37);
            this.ingresar_Btn.TabIndex = 5;
            this.ingresar_Btn.Text = "Ingresar";
            this.ingresar_Btn.UseVisualStyleBackColor = true;
            this.ingresar_Btn.Click += new System.EventHandler(this.ingresar_Btn_Click);
            // 
            // mostrar_checkBox
            // 
            this.mostrar_checkBox.AutoSize = true;
            this.mostrar_checkBox.Location = new System.Drawing.Point(519, 271);
            this.mostrar_checkBox.Name = "mostrar_checkBox";
            this.mostrar_checkBox.Size = new System.Drawing.Size(176, 24);
            this.mostrar_checkBox.TabIndex = 6;
            this.mostrar_checkBox.Text = "Mostrar Contraseña";
            this.mostrar_checkBox.UseVisualStyleBackColor = true;
            this.mostrar_checkBox.CheckedChanged += new System.EventHandler(this.mostrar_checkBox_CheckedChanged);
            // 
            // IngresoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 411);
            this.Controls.Add(this.mostrar_checkBox);
            this.Controls.Add(this.ingresar_Btn);
            this.Controls.Add(this.contrasenia_lbl);
            this.Controls.Add(this.contrasenia_tbx);
            this.Controls.Add(this.usuario_Lbl);
            this.Controls.Add(this.usuario_Tbx);
            this.Controls.Add(this.bienvenido_Lbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngresoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IngresoAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenido_Lbl;
        private System.Windows.Forms.TextBox usuario_Tbx;
        private System.Windows.Forms.Label usuario_Lbl;
        private System.Windows.Forms.Label contrasenia_lbl;
        private System.Windows.Forms.TextBox contrasenia_tbx;
        private System.Windows.Forms.Button ingresar_Btn;
        private System.Windows.Forms.CheckBox mostrar_checkBox;
    }
}