﻿
namespace Clave1_Grupo2.gui
{
    partial class VtnAgregarMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnAgregarMascota));
            this.lblUsrPw = new System.Windows.Forms.Label();
            this.lblEdadMascota = new System.Windows.Forms.Label();
            this.txtEdadMascota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVetCatDog = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picRegistroUsuario = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxPropietario = new System.Windows.Forms.ComboBox();
            this.cbxEspecie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.chkIndef = new System.Windows.Forms.RadioButton();
            this.chkMsc = new System.Windows.Forms.RadioButton();
            this.chkFem = new System.Windows.Forms.RadioButton();
            this.lblEdadValida = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistroUsuario)).BeginInit();
            this.grpGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsrPw
            // 
            this.lblUsrPw.AutoSize = true;
            this.lblUsrPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrPw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsrPw.Location = new System.Drawing.Point(214, 175);
            this.lblUsrPw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsrPw.Name = "lblUsrPw";
            this.lblUsrPw.Size = new System.Drawing.Size(56, 17);
            this.lblUsrPw.TabIndex = 38;
            this.lblUsrPw.Text = "Género";
            // 
            // lblEdadMascota
            // 
            this.lblEdadMascota.AutoSize = true;
            this.lblEdadMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadMascota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdadMascota.Location = new System.Drawing.Point(214, 115);
            this.lblEdadMascota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdadMascota.Name = "lblEdadMascota";
            this.lblEdadMascota.Size = new System.Drawing.Size(41, 17);
            this.lblEdadMascota.TabIndex = 37;
            this.lblEdadMascota.Text = "Edad";
            // 
            // txtEdadMascota
            // 
            this.txtEdadMascota.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEdadMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadMascota.ForeColor = System.Drawing.Color.White;
            this.txtEdadMascota.Location = new System.Drawing.Point(350, 110);
            this.txtEdadMascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEdadMascota.MaxLength = 3;
            this.txtEdadMascota.Name = "txtEdadMascota";
            this.txtEdadMascota.Size = new System.Drawing.Size(78, 24);
            this.txtEdadMascota.TabIndex = 5;
            this.txtEdadMascota.TextChanged += new System.EventHandler(this.txtEdadMascota_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(214, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(214, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Especie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(214, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre mascota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(214, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Propietario";
            // 
            // txtRaza
            // 
            this.txtRaza.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.ForeColor = System.Drawing.Color.White;
            this.txtRaza.Location = new System.Drawing.Point(350, 84);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRaza.MaxLength = 20;
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(246, 24);
            this.txtRaza.TabIndex = 4;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNombreMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMascota.ForeColor = System.Drawing.Color.White;
            this.txtNombreMascota.Location = new System.Drawing.Point(350, 36);
            this.txtNombreMascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreMascota.MaxLength = 25;
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(246, 24);
            this.txtNombreMascota.TabIndex = 2;
            // 
            // btnAgregarMascota
            // 
            this.btnAgregarMascota.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMascota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMascota.Location = new System.Drawing.Point(350, 214);
            this.btnAgregarMascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(244, 36);
            this.btnAgregarMascota.TabIndex = 11;
            this.btnAgregarMascota.Text = "Agregar mascota";
            this.btnAgregarMascota.UseVisualStyleBackColor = false;
            this.btnAgregarMascota.Click += new System.EventHandler(this.btnAgregarMascota_Click);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 263);
            this.panel1.TabIndex = 30;
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
            // picRegistroUsuario
            // 
            this.picRegistroUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picRegistroUsuario.Image")));
            this.picRegistroUsuario.Location = new System.Drawing.Point(36, 28);
            this.picRegistroUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picRegistroUsuario.Name = "picRegistroUsuario";
            this.picRegistroUsuario.Size = new System.Drawing.Size(91, 98);
            this.picRegistroUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegistroUsuario.TabIndex = 0;
            this.picRegistroUsuario.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(20, 136);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 20);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Agregar Mascota";
            // 
            // cbxPropietario
            // 
            this.cbxPropietario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbxPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPropietario.ForeColor = System.Drawing.Color.White;
            this.cbxPropietario.FormattingEnabled = true;
            this.cbxPropietario.Location = new System.Drawing.Point(350, 14);
            this.cbxPropietario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPropietario.Name = "cbxPropietario";
            this.cbxPropietario.Size = new System.Drawing.Size(246, 23);
            this.cbxPropietario.TabIndex = 1;
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbxEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecie.ForeColor = System.Drawing.Color.White;
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Location = new System.Drawing.Point(350, 61);
            this.cbxEspecie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(246, 23);
            this.cbxEspecie.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(214, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(350, 137);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.MaxLength = 25;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(246, 24);
            this.txtColor.TabIndex = 6;
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.chkIndef);
            this.grpGenero.Controls.Add(this.chkMsc);
            this.grpGenero.Controls.Add(this.chkFem);
            this.grpGenero.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpGenero.Location = new System.Drawing.Point(350, 170);
            this.grpGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGenero.Size = new System.Drawing.Size(244, 40);
            this.grpGenero.TabIndex = 7;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
            // 
            // chkIndef
            // 
            this.chkIndef.AutoSize = true;
            this.chkIndef.Location = new System.Drawing.Point(158, 14);
            this.chkIndef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkIndef.Name = "chkIndef";
            this.chkIndef.Size = new System.Drawing.Size(71, 17);
            this.chkIndef.TabIndex = 10;
            this.chkIndef.TabStop = true;
            this.chkIndef.Text = "Sin definir";
            this.chkIndef.UseVisualStyleBackColor = true;
            // 
            // chkMsc
            // 
            this.chkMsc.AutoSize = true;
            this.chkMsc.Location = new System.Drawing.Point(81, 16);
            this.chkMsc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMsc.Name = "chkMsc";
            this.chkMsc.Size = new System.Drawing.Size(73, 17);
            this.chkMsc.TabIndex = 9;
            this.chkMsc.TabStop = true;
            this.chkMsc.Text = "Masculino";
            this.chkMsc.UseVisualStyleBackColor = true;
            // 
            // chkFem
            // 
            this.chkFem.AutoSize = true;
            this.chkFem.Location = new System.Drawing.Point(8, 16);
            this.chkFem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkFem.Name = "chkFem";
            this.chkFem.Size = new System.Drawing.Size(71, 17);
            this.chkFem.TabIndex = 8;
            this.chkFem.TabStop = true;
            this.chkFem.Text = "Femenino";
            this.chkFem.UseVisualStyleBackColor = true;
            // 
            // lblEdadValida
            // 
            this.lblEdadValida.AutoSize = true;
            this.lblEdadValida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdadValida.Location = new System.Drawing.Point(431, 115);
            this.lblEdadValida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdadValida.Name = "lblEdadValida";
            this.lblEdadValida.Size = new System.Drawing.Size(10, 13);
            this.lblEdadValida.TabIndex = 42;
            this.lblEdadValida.Text = "-";
            // 
            // VtnAgregarMascota
            // 
            this.AcceptButton = this.btnAgregarMascota;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(631, 263);
            this.Controls.Add(this.lblEdadValida);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cbxEspecie);
            this.Controls.Add(this.cbxPropietario);
            this.Controls.Add(this.lblUsrPw);
            this.Controls.Add(this.lblEdadMascota);
            this.Controls.Add(this.txtEdadMascota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.btnAgregarMascota);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VtnAgregarMascota";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Mascota";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistroUsuario)).EndInit();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsrPw;
        private System.Windows.Forms.Label lblEdadMascota;
        private System.Windows.Forms.TextBox txtEdadMascota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVetCatDog;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picRegistroUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxPropietario;
        private System.Windows.Forms.ComboBox cbxEspecie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton chkIndef;
        private System.Windows.Forms.RadioButton chkMsc;
        private System.Windows.Forms.RadioButton chkFem;
        private System.Windows.Forms.Label lblEdadValida;
    }
}