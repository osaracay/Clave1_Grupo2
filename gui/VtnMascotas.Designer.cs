
namespace Clave1_Grupo2.gui
{
    partial class VtnMascotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnMascotas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.lblVetCatDog = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.listaMascotas = new System.Windows.Forms.ListBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtColorMascota = new System.Windows.Forms.TextBox();
            this.cbxPropietario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEspecie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.pbxFotoPerfil);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblVetCatDog);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 450);
            this.panel2.TabIndex = 61;
            // 
            // pbxFotoPerfil
            // 
            this.pbxFotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.pbxFotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbxFotoPerfil.Image")));
            this.pbxFotoPerfil.Location = new System.Drawing.Point(45, 15);
            this.pbxFotoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.pbxFotoPerfil.Name = "pbxFotoPerfil";
            this.pbxFotoPerfil.Size = new System.Drawing.Size(148, 151);
            this.pbxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFotoPerfil.TabIndex = 63;
            this.pbxFotoPerfil.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(81, 170);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(96, 29);
            this.txtNombre.TabIndex = 62;
            this.txtNombre.Text = "Usuario";
            // 
            // lblVetCatDog
            // 
            this.lblVetCatDog.AutoSize = true;
            this.lblVetCatDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetCatDog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVetCatDog.Location = new System.Drawing.Point(96, 390);
            this.lblVetCatDog.Name = "lblVetCatDog";
            this.lblVetCatDog.Size = new System.Drawing.Size(117, 50);
            this.lblVetCatDog.TabIndex = 6;
            this.lblVetCatDog.Text = "Veterinaria\r\nCat-Dog";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(-3, 349);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(99, 94);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // listaMascotas
            // 
            this.listaMascotas.BackColor = System.Drawing.Color.Black;
            this.listaMascotas.ForeColor = System.Drawing.Color.White;
            this.listaMascotas.FormattingEnabled = true;
            this.listaMascotas.ItemHeight = 16;
            this.listaMascotas.Location = new System.Drawing.Point(638, 58);
            this.listaMascotas.Name = "listaMascotas";
            this.listaMascotas.Size = new System.Drawing.Size(150, 372);
            this.listaMascotas.TabIndex = 62;
            this.listaMascotas.SelectedIndexChanged += new System.EventHandler(this.listaMascotas_SelectedIndexChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Location = new System.Drawing.Point(241, 98);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 82;
            this.lblApellido.Text = "Especie";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(241, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 81;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombres.Location = new System.Drawing.Point(324, 58);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(308, 29);
            this.txtNombres.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdad.Location = new System.Drawing.Point(241, 177);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 78;
            this.lblEdad.Text = "Edad";
            // 
            // txtRaza
            // 
            this.txtRaza.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRaza.Location = new System.Drawing.Point(324, 132);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRaza.MaxLength = 25;
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(308, 29);
            this.txtRaza.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(241, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(455, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(241, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Color";
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEdad.Location = new System.Drawing.Point(324, 170);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad.MaxLength = 30;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(107, 29);
            this.txtEdad.TabIndex = 6;
            // 
            // txtColorMascota
            // 
            this.txtColorMascota.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtColorMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorMascota.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtColorMascota.Location = new System.Drawing.Point(324, 214);
            this.txtColorMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColorMascota.MaxLength = 25;
            this.txtColorMascota.Name = "txtColorMascota";
            this.txtColorMascota.Size = new System.Drawing.Size(308, 29);
            this.txtColorMascota.TabIndex = 8;
            // 
            // cbxPropietario
            // 
            this.cbxPropietario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbxPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPropietario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxPropietario.FormattingEnabled = true;
            this.cbxPropietario.Location = new System.Drawing.Point(324, 15);
            this.cbxPropietario.Name = "cbxPropietario";
            this.cbxPropietario.Size = new System.Drawing.Size(308, 26);
            this.cbxPropietario.TabIndex = 1;
            this.cbxPropietario.SelectedIndexChanged += new System.EventHandler(this.cbxPropietario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(241, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Propietario";
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbxEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecie.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Location = new System.Drawing.Point(324, 92);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(308, 30);
            this.cbxEspecie.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(699, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "Mascotas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(388, 150);
            this.dataGridView1.TabIndex = 93;
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGenero.Location = new System.Drawing.Point(525, 171);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGenero.MaxLength = 30;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(107, 29);
            this.txtGenero.TabIndex = 7;
            // 
            // VtnMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxEspecie);
            this.Controls.Add(this.cbxPropietario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtColorMascota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.listaMascotas);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VtnMascotas";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascotas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VtnMascotas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxFotoPerfil;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label lblVetCatDog;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ListBox listaMascotas;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtColorMascota;
        private System.Windows.Forms.ComboBox cbxPropietario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEspecie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGenero;
    }
}