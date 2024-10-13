
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUsrPw = new System.Windows.Forms.TextBox();
            this.lblUsrPw = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.chkIndef = new System.Windows.Forms.RadioButton();
            this.chkMsc = new System.Windows.Forms.RadioButton();
            this.chkFem = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistroUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRegistroUsuario
            // 
            this.picRegistroUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picRegistroUsuario.Image")));
            this.picRegistroUsuario.Location = new System.Drawing.Point(36, 28);
            this.picRegistroUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.picRegistroUsuario.Name = "picRegistroUsuario";
            this.picRegistroUsuario.Size = new System.Drawing.Size(91, 98);
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
            this.btnRegistrar.Location = new System.Drawing.Point(345, 214);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(244, 36);
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
            this.txtNombres.Location = new System.Drawing.Point(345, 9);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(246, 24);
            this.txtNombres.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(20, 136);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 20);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 256);
            this.panel1.TabIndex = 6;
            // 
            // lblVetCatDog
            // 
            this.lblVetCatDog.AutoSize = true;
            this.lblVetCatDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetCatDog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVetCatDog.Location = new System.Drawing.Point(78, 208);
            this.lblVetCatDog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVetCatDog.Name = "lblVetCatDog";
            this.lblVetCatDog.Size = new System.Drawing.Size(97, 40);
            this.lblVetCatDog.TabIndex = 6;
            this.lblVetCatDog.Text = "Veterinaria\r\nCat-Dog";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(4, 175);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(74, 76);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtApellidos.Location = new System.Drawing.Point(345, 36);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.MaxLength = 30;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(246, 24);
            this.txtApellidos.TabIndex = 2;
            // 
            // campoFechaNac
            // 
            this.campoFechaNac.CalendarFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFechaNac.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.campoFechaNac.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoFechaNac.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.campoFechaNac.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFechaNac.Location = new System.Drawing.Point(345, 63);
            this.campoFechaNac.Margin = new System.Windows.Forms.Padding(2);
            this.campoFechaNac.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.campoFechaNac.MinDate = new System.DateTime(1925, 12, 31, 0, 0, 0, 0);
            this.campoFechaNac.Name = "campoFechaNac";
            this.campoFechaNac.Size = new System.Drawing.Size(246, 21);
            this.campoFechaNac.TabIndex = 3;
            // 
            // chkVeterinario
            // 
            this.chkVeterinario.AutoSize = true;
            this.chkVeterinario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkVeterinario.Location = new System.Drawing.Point(212, 230);
            this.chkVeterinario.Margin = new System.Windows.Forms.Padding(2);
            this.chkVeterinario.Name = "chkVeterinario";
            this.chkVeterinario.Size = new System.Drawing.Size(105, 17);
            this.chkVeterinario.TabIndex = 19;
            this.chkVeterinario.Text = "soy veterinario/a";
            this.chkVeterinario.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(345, 84);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 24);
            this.txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(209, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(209, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(209, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(209, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Correo electrónico";
            // 
            // lblUsrLogin
            // 
            this.lblUsrLogin.AutoSize = true;
            this.lblUsrLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsrLogin.Location = new System.Drawing.Point(209, 115);
            this.lblUsrLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsrLogin.Name = "lblUsrLogin";
            this.lblUsrLogin.Size = new System.Drawing.Size(57, 17);
            this.lblUsrLogin.TabIndex = 21;
            this.lblUsrLogin.Text = "Usuario";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUserName.Location = new System.Drawing.Point(345, 110);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.MaxLength = 30;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(246, 24);
            this.txtUserName.TabIndex = 5;
            // 
            // txtUsrPw
            // 
            this.txtUsrPw.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsrPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrPw.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsrPw.Location = new System.Drawing.Point(345, 137);
            this.txtUsrPw.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsrPw.MaxLength = 30;
            this.txtUsrPw.Name = "txtUsrPw";
            this.txtUsrPw.Size = new System.Drawing.Size(246, 24);
            this.txtUsrPw.TabIndex = 6;
            this.txtUsrPw.UseSystemPasswordChar = true;
            // 
            // lblUsrPw
            // 
            this.lblUsrPw.AutoSize = true;
            this.lblUsrPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrPw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsrPw.Location = new System.Drawing.Point(209, 145);
            this.lblUsrPw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsrPw.Name = "lblUsrPw";
            this.lblUsrPw.Size = new System.Drawing.Size(81, 17);
            this.lblUsrPw.TabIndex = 23;
            this.lblUsrPw.Text = "Contraseña";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.chkIndef);
            this.grpGenero.Controls.Add(this.chkMsc);
            this.grpGenero.Controls.Add(this.chkFem);
            this.grpGenero.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpGenero.Location = new System.Drawing.Point(345, 162);
            this.grpGenero.Margin = new System.Windows.Forms.Padding(2);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Padding = new System.Windows.Forms.Padding(2);
            this.grpGenero.Size = new System.Drawing.Size(244, 40);
            this.grpGenero.TabIndex = 24;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
            // 
            // chkIndef
            // 
            this.chkIndef.AutoSize = true;
            this.chkIndef.Location = new System.Drawing.Point(158, 14);
            this.chkIndef.Margin = new System.Windows.Forms.Padding(2);
            this.chkIndef.Name = "chkIndef";
            this.chkIndef.Size = new System.Drawing.Size(71, 17);
            this.chkIndef.TabIndex = 2;
            this.chkIndef.TabStop = true;
            this.chkIndef.Text = "Sin definir";
            this.chkIndef.UseVisualStyleBackColor = true;
            // 
            // chkMsc
            // 
            this.chkMsc.AutoSize = true;
            this.chkMsc.Location = new System.Drawing.Point(81, 16);
            this.chkMsc.Margin = new System.Windows.Forms.Padding(2);
            this.chkMsc.Name = "chkMsc";
            this.chkMsc.Size = new System.Drawing.Size(73, 17);
            this.chkMsc.TabIndex = 1;
            this.chkMsc.TabStop = true;
            this.chkMsc.Text = "Masculino";
            this.chkMsc.UseVisualStyleBackColor = true;
            // 
            // chkFem
            // 
            this.chkFem.AutoSize = true;
            this.chkFem.Location = new System.Drawing.Point(8, 16);
            this.chkFem.Margin = new System.Windows.Forms.Padding(2);
            this.chkFem.Name = "chkFem";
            this.chkFem.Size = new System.Drawing.Size(71, 17);
            this.chkFem.TabIndex = 0;
            this.chkFem.TabStop = true;
            this.chkFem.Text = "Femenino";
            this.chkFem.UseVisualStyleBackColor = true;
            // 
            // VtnRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(619, 256);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.lblUsrPw);
            this.Controls.Add(this.txtUsrPw);
            this.Controls.Add(this.lblUsrLogin);
            this.Controls.Add(this.txtUserName);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
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
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUsrPw;
        private System.Windows.Forms.Label lblUsrPw;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton chkIndef;
        private System.Windows.Forms.RadioButton chkMsc;
        private System.Windows.Forms.RadioButton chkFem;
    }
}