
namespace Clave1_Grupo2.gui
{
    partial class VtnRegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnRegistrarUsuario));
            this.picRegistroUsuario = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVetCatDog = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.campoFechaNac = new System.Windows.Forms.DateTimePicker();
            this.chkVeterinario = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsrLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtUsrPw = new System.Windows.Forms.TextBox();
            this.lblUsrPw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistroUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picRegistroUsuario
            // 
            this.picRegistroUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picRegistroUsuario.Image")));
            this.picRegistroUsuario.Location = new System.Drawing.Point(54, 42);
            this.picRegistroUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picRegistroUsuario.Name = "picRegistroUsuario";
            this.picRegistroUsuario.Size = new System.Drawing.Size(136, 151);
            this.picRegistroUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegistroUsuario.TabIndex = 0;
            this.picRegistroUsuario.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(518, 330);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(367, 55);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombres.Location = new System.Drawing.Point(518, 14);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(366, 33);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Text = "Ingrese sus nombres";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(29, 209);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 29);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Registrar Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lblVetCatDog);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.picRegistroUsuario);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 394);
            this.panel1.TabIndex = 6;
            // 
            // lblVetCatDog
            // 
            this.lblVetCatDog.AutoSize = true;
            this.lblVetCatDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetCatDog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVetCatDog.Location = new System.Drawing.Point(117, 320);
            this.lblVetCatDog.Name = "lblVetCatDog";
            this.lblVetCatDog.Size = new System.Drawing.Size(140, 58);
            this.lblVetCatDog.TabIndex = 6;
            this.lblVetCatDog.Text = "Veterinaria\r\nCat-Dog";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(6, 269);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(110, 116);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtApellidos.Location = new System.Drawing.Point(518, 55);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.MaxLength = 30;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(366, 33);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.Text = "Ingrese sus apellidos";
            // 
            // campoFechaNac
            // 
            this.campoFechaNac.CalendarFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFechaNac.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.campoFechaNac.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoFechaNac.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.campoFechaNac.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFechaNac.Location = new System.Drawing.Point(518, 96);
            this.campoFechaNac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoFechaNac.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.campoFechaNac.MinDate = new System.DateTime(1925, 12, 31, 0, 0, 0, 0);
            this.campoFechaNac.Name = "campoFechaNac";
            this.campoFechaNac.Size = new System.Drawing.Size(366, 31);
            this.campoFechaNac.TabIndex = 3;
            // 
            // chkVeterinario
            // 
            this.chkVeterinario.AutoSize = true;
            this.chkVeterinario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkVeterinario.Location = new System.Drawing.Point(318, 354);
            this.chkVeterinario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkVeterinario.Name = "chkVeterinario";
            this.chkVeterinario.Size = new System.Drawing.Size(149, 24);
            this.chkVeterinario.TabIndex = 19;
            this.chkVeterinario.Text = "soy veterinario/a";
            this.chkVeterinario.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(518, 129);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(366, 33);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "e-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(314, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(314, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(314, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(314, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Correo electrónico";
            // 
            // lblUsrLogin
            // 
            this.lblUsrLogin.AutoSize = true;
            this.lblUsrLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsrLogin.Location = new System.Drawing.Point(314, 178);
            this.lblUsrLogin.Name = "lblUsrLogin";
            this.lblUsrLogin.Size = new System.Drawing.Size(86, 25);
            this.lblUsrLogin.TabIndex = 21;
            this.lblUsrLogin.Text = "Usuario";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(518, 170);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 33);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "nombre de usuario";
            // 
            // txtUsrPw
            // 
            this.txtUsrPw.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsrPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrPw.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsrPw.Location = new System.Drawing.Point(518, 211);
            this.txtUsrPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsrPw.MaxLength = 60;
            this.txtUsrPw.Name = "txtUsrPw";
            this.txtUsrPw.Size = new System.Drawing.Size(366, 33);
            this.txtUsrPw.TabIndex = 6;
            this.txtUsrPw.UseSystemPasswordChar = true;
            this.txtUsrPw.TextChanged += new System.EventHandler(this.txtUsrPw_TextChanged);
            // 
            // lblUsrPw
            // 
            this.lblUsrPw.AutoSize = true;
            this.lblUsrPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrPw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsrPw.Location = new System.Drawing.Point(314, 222);
            this.lblUsrPw.Name = "lblUsrPw";
            this.lblUsrPw.Size = new System.Drawing.Size(123, 25);
            this.lblUsrPw.TabIndex = 23;
            this.lblUsrPw.Text = "Contraseña";
            // 
            // VtnRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(928, 394);
            this.Controls.Add(this.lblUsrPw);
            this.Controls.Add(this.txtUsrPw);
            this.Controls.Add(this.lblUsrLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkVeterinario);
            this.Controls.Add(this.campoFechaNac);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VtnRegistrarUsuario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picRegistroUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRegistroUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.DateTimePicker campoFechaNac;
        private System.Windows.Forms.CheckBox chkVeterinario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblVetCatDog;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsrLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtUsrPw;
        private System.Windows.Forms.Label lblUsrPw;
    }
}