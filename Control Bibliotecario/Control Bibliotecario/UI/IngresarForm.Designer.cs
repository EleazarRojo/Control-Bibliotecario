
namespace Control_Bibliotecario
{
    partial class IngresarForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idUsario_lbl = new System.Windows.Forms.Label();
            this.Titulo_lbl = new System.Windows.Forms.Label();
            this.contraseña_lbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.acceder_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(169, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 5;
            // 
            // idUsario_lbl
            // 
            this.idUsario_lbl.AutoSize = true;
            this.idUsario_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsario_lbl.Location = new System.Drawing.Point(192, 101);
            this.idUsario_lbl.Name = "idUsario_lbl";
            this.idUsario_lbl.Size = new System.Drawing.Size(76, 19);
            this.idUsario_lbl.TabIndex = 4;
            this.idUsario_lbl.Text = "Id Usuario:";
            // 
            // Titulo_lbl
            // 
            this.Titulo_lbl.AutoSize = true;
            this.Titulo_lbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_lbl.Location = new System.Drawing.Point(148, 39);
            this.Titulo_lbl.Name = "Titulo_lbl";
            this.Titulo_lbl.Size = new System.Drawing.Size(175, 31);
            this.Titulo_lbl.TabIndex = 3;
            this.Titulo_lbl.Text = "Member Login";
            // 
            // contraseña_lbl
            // 
            this.contraseña_lbl.AutoSize = true;
            this.contraseña_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña_lbl.Location = new System.Drawing.Point(187, 171);
            this.contraseña_lbl.Name = "contraseña_lbl";
            this.contraseña_lbl.Size = new System.Drawing.Size(76, 19);
            this.contraseña_lbl.TabIndex = 6;
            this.contraseña_lbl.Text = "Contaseña:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(169, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 26);
            this.textBox2.TabIndex = 7;
            // 
            // acceder_btn
            // 
            this.acceder_btn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceder_btn.Location = new System.Drawing.Point(408, 273);
            this.acceder_btn.Name = "acceder_btn";
            this.acceder_btn.Size = new System.Drawing.Size(75, 23);
            this.acceder_btn.TabIndex = 8;
            this.acceder_btn.Text = "Acceder";
            this.acceder_btn.UseVisualStyleBackColor = true;
            // 
            // IngresarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 322);
            this.Controls.Add(this.acceder_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.contraseña_lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idUsario_lbl);
            this.Controls.Add(this.Titulo_lbl);
            this.Name = "IngresarForm";
            this.Text = "Ingresar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label idUsario_lbl;
        private System.Windows.Forms.Label Titulo_lbl;
        private System.Windows.Forms.Label contraseña_lbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button acceder_btn;
    }
}