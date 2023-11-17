
namespace Control_Bibliotecario
{
    partial class RegistroForm
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
            this.titulo_Lbl = new System.Windows.Forms.Label();
            this.nombre_Lbl = new System.Windows.Forms.Label();
            this.apellidoPaterno_Lbl = new System.Windows.Forms.Label();
            this.apellidoMaterno_Lbl = new System.Windows.Forms.Label();
            this.fechaDeNacimiento_lbl = new System.Windows.Forms.Label();
            this.genero_Lbl = new System.Windows.Forms.Label();
            this.fechaDeNacimiento_Calendar = new System.Windows.Forms.MonthCalendar();
            this.genero_Cbx = new System.Windows.Forms.ComboBox();
            this.apellidoPaterno_Tbx = new System.Windows.Forms.TextBox();
            this.ApellidoMaterno_Tbx = new System.Windows.Forms.TextBox();
            this.nombre_Tbx = new System.Windows.Forms.TextBox();
            this.direccion_Lbl = new System.Windows.Forms.Label();
            this.direccion_Tbx = new System.Windows.Forms.TextBox();
            this.registrar_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo_Lbl
            // 
            this.titulo_Lbl.AutoSize = true;
            this.titulo_Lbl.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_Lbl.Location = new System.Drawing.Point(363, 9);
            this.titulo_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo_Lbl.Name = "titulo_Lbl";
            this.titulo_Lbl.Size = new System.Drawing.Size(367, 51);
            this.titulo_Lbl.TabIndex = 0;
            this.titulo_Lbl.Text = "Registro de Usuario";
            // 
            // nombre_Lbl
            // 
            this.nombre_Lbl.AutoSize = true;
            this.nombre_Lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_Lbl.Location = new System.Drawing.Point(60, 92);
            this.nombre_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombre_Lbl.Name = "nombre_Lbl";
            this.nombre_Lbl.Size = new System.Drawing.Size(85, 22);
            this.nombre_Lbl.TabIndex = 1;
            this.nombre_Lbl.Text = "Nombre: ";
            // 
            // apellidoPaterno_Lbl
            // 
            this.apellidoPaterno_Lbl.AutoSize = true;
            this.apellidoPaterno_Lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoPaterno_Lbl.Location = new System.Drawing.Point(60, 155);
            this.apellidoPaterno_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apellidoPaterno_Lbl.Name = "apellidoPaterno_Lbl";
            this.apellidoPaterno_Lbl.Size = new System.Drawing.Size(152, 22);
            this.apellidoPaterno_Lbl.TabIndex = 2;
            this.apellidoPaterno_Lbl.Text = "Apellido Paterno:";
            // 
            // apellidoMaterno_Lbl
            // 
            this.apellidoMaterno_Lbl.AutoSize = true;
            this.apellidoMaterno_Lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoMaterno_Lbl.Location = new System.Drawing.Point(60, 226);
            this.apellidoMaterno_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apellidoMaterno_Lbl.Name = "apellidoMaterno_Lbl";
            this.apellidoMaterno_Lbl.Size = new System.Drawing.Size(163, 22);
            this.apellidoMaterno_Lbl.TabIndex = 3;
            this.apellidoMaterno_Lbl.Text = "Apellido Materno: ";
            // 
            // fechaDeNacimiento_lbl
            // 
            this.fechaDeNacimiento_lbl.AutoSize = true;
            this.fechaDeNacimiento_lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDeNacimiento_lbl.Location = new System.Drawing.Point(726, 65);
            this.fechaDeNacimiento_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaDeNacimiento_lbl.Name = "fechaDeNacimiento_lbl";
            this.fechaDeNacimiento_lbl.Size = new System.Drawing.Size(188, 22);
            this.fechaDeNacimiento_lbl.TabIndex = 4;
            this.fechaDeNacimiento_lbl.Text = "Fecha de Nacimiento: ";
            // 
            // genero_Lbl
            // 
            this.genero_Lbl.AutoSize = true;
            this.genero_Lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero_Lbl.Location = new System.Drawing.Point(60, 282);
            this.genero_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genero_Lbl.Name = "genero_Lbl";
            this.genero_Lbl.Size = new System.Drawing.Size(79, 22);
            this.genero_Lbl.TabIndex = 5;
            this.genero_Lbl.Text = "Genero: ";
            // 
            // fechaDeNacimiento_Calendar
            // 
            this.fechaDeNacimiento_Calendar.Location = new System.Drawing.Point(730, 106);
            this.fechaDeNacimiento_Calendar.Name = "fechaDeNacimiento_Calendar";
            this.fechaDeNacimiento_Calendar.TabIndex = 6;
            // 
            // genero_Cbx
            // 
            this.genero_Cbx.FormattingEnabled = true;
            this.genero_Cbx.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.genero_Cbx.Location = new System.Drawing.Point(224, 280);
            this.genero_Cbx.Name = "genero_Cbx";
            this.genero_Cbx.Size = new System.Drawing.Size(164, 28);
            this.genero_Cbx.TabIndex = 7;
            this.genero_Cbx.Text = "Género";
            // 
            // apellidoPaterno_Tbx
            // 
            this.apellidoPaterno_Tbx.Location = new System.Drawing.Point(224, 155);
            this.apellidoPaterno_Tbx.Name = "apellidoPaterno_Tbx";
            this.apellidoPaterno_Tbx.Size = new System.Drawing.Size(164, 26);
            this.apellidoPaterno_Tbx.TabIndex = 8;
            // 
            // ApellidoMaterno_Tbx
            // 
            this.ApellidoMaterno_Tbx.Location = new System.Drawing.Point(224, 225);
            this.ApellidoMaterno_Tbx.Name = "ApellidoMaterno_Tbx";
            this.ApellidoMaterno_Tbx.Size = new System.Drawing.Size(164, 26);
            this.ApellidoMaterno_Tbx.TabIndex = 9;
            // 
            // nombre_Tbx
            // 
            this.nombre_Tbx.Location = new System.Drawing.Point(224, 98);
            this.nombre_Tbx.Name = "nombre_Tbx";
            this.nombre_Tbx.Size = new System.Drawing.Size(164, 26);
            this.nombre_Tbx.TabIndex = 10;
            // 
            // direccion_Lbl
            // 
            this.direccion_Lbl.AutoSize = true;
            this.direccion_Lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_Lbl.Location = new System.Drawing.Point(60, 338);
            this.direccion_Lbl.Name = "direccion_Lbl";
            this.direccion_Lbl.Size = new System.Drawing.Size(100, 22);
            this.direccion_Lbl.TabIndex = 11;
            this.direccion_Lbl.Text = "Dirección: ";
            // 
            // direccion_Tbx
            // 
            this.direccion_Tbx.Location = new System.Drawing.Point(224, 332);
            this.direccion_Tbx.Name = "direccion_Tbx";
            this.direccion_Tbx.Size = new System.Drawing.Size(164, 26);
            this.direccion_Tbx.TabIndex = 12;
            // 
            // registrar_Btn
            // 
            this.registrar_Btn.Location = new System.Drawing.Point(1066, 625);
            this.registrar_Btn.Name = "registrar_Btn";
            this.registrar_Btn.Size = new System.Drawing.Size(120, 38);
            this.registrar_Btn.TabIndex = 13;
            this.registrar_Btn.Text = "Registrar ";
            this.registrar_Btn.UseVisualStyleBackColor = true;
            this.registrar_Btn.Click += new System.EventHandler(this.registrar_Btn_Click);
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 689);
            this.Controls.Add(this.registrar_Btn);
            this.Controls.Add(this.direccion_Tbx);
            this.Controls.Add(this.direccion_Lbl);
            this.Controls.Add(this.nombre_Tbx);
            this.Controls.Add(this.ApellidoMaterno_Tbx);
            this.Controls.Add(this.apellidoPaterno_Tbx);
            this.Controls.Add(this.genero_Cbx);
            this.Controls.Add(this.fechaDeNacimiento_Calendar);
            this.Controls.Add(this.genero_Lbl);
            this.Controls.Add(this.fechaDeNacimiento_lbl);
            this.Controls.Add(this.apellidoMaterno_Lbl);
            this.Controls.Add(this.apellidoPaterno_Lbl);
            this.Controls.Add(this.nombre_Lbl);
            this.Controls.Add(this.titulo_Lbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RegistroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_Lbl;
        private System.Windows.Forms.Label nombre_Lbl;
        private System.Windows.Forms.Label apellidoPaterno_Lbl;
        private System.Windows.Forms.Label apellidoMaterno_Lbl;
        private System.Windows.Forms.Label fechaDeNacimiento_lbl;
        private System.Windows.Forms.Label genero_Lbl;
        private System.Windows.Forms.MonthCalendar fechaDeNacimiento_Calendar;
        private System.Windows.Forms.ComboBox genero_Cbx;
        private System.Windows.Forms.TextBox apellidoPaterno_Tbx;
        private System.Windows.Forms.TextBox ApellidoMaterno_Tbx;
        private System.Windows.Forms.TextBox nombre_Tbx;
        private System.Windows.Forms.Label direccion_Lbl;
        private System.Windows.Forms.TextBox direccion_Tbx;
        private System.Windows.Forms.Button registrar_Btn;
    }
}