
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
            this.lblMascotas = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblCitas = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblEdadValida = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(224, 450);
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
            this.txtNombre.Location = new System.Drawing.Point(67, 169);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(96, 29);
            this.txtNombre.TabIndex = 62;
            this.txtNombre.Text = "Usuario";
            this.txtNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.listaMascotas.Location = new System.Drawing.Point(638, 42);
            this.listaMascotas.Name = "listaMascotas";
            this.listaMascotas.Size = new System.Drawing.Size(150, 212);
            this.listaMascotas.TabIndex = 2;
            this.listaMascotas.SelectedIndexChanged += new System.EventHandler(this.listaMascotas_SelectedIndexChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Location = new System.Drawing.Point(226, 97);
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
            this.lblNombre.Location = new System.Drawing.Point(226, 57);
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
            this.txtNombres.Location = new System.Drawing.Point(324, 51);
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
            this.lblEdad.Location = new System.Drawing.Point(226, 176);
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
            this.label1.Location = new System.Drawing.Point(226, 138);
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
            this.label3.Location = new System.Drawing.Point(226, 214);
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
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(107, 29);
            this.txtEdad.TabIndex = 6;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
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
            this.cbxPropietario.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.label4.Location = new System.Drawing.Point(226, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Propietario";
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbxEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecie.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Location = new System.Drawing.Point(324, 92);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(308, 30);
            this.cbxEspecie.TabIndex = 4;
            // 
            // lblMascotas
            // 
            this.lblMascotas.AutoSize = true;
            this.lblMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascotas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMascotas.Location = new System.Drawing.Point(639, 12);
            this.lblMascotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(115, 29);
            this.lblMascotas.TabIndex = 64;
            this.lblMascotas.Text = "Mascotas";
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(230, 292);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.RowTemplate.Height = 24;
            this.dgvCitas.Size = new System.Drawing.Size(558, 150);
            this.dgvCitas.TabIndex = 93;
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGenero.Location = new System.Drawing.Point(525, 171);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGenero.MaxLength = 1;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(107, 29);
            this.txtGenero.TabIndex = 7;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCitas.Location = new System.Drawing.Point(225, 256);
            this.lblCitas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(67, 29);
            this.lblCitas.TabIndex = 94;
            this.lblCitas.Text = "Citas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(555, 256);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 35);
            this.btnCancelar.TabIndex = 97;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(437, 256);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 35);
            this.btnGuardar.TabIndex = 96;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(673, 256);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 36);
            this.btnModificar.TabIndex = 95;
            this.btnModificar.Text = "Editar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblEdadValida
            // 
            this.lblEdadValida.AutoSize = true;
            this.lblEdadValida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdadValida.Location = new System.Drawing.Point(367, 177);
            this.lblEdadValida.Name = "lblEdadValida";
            this.lblEdadValida.Size = new System.Drawing.Size(13, 17);
            this.lblEdadValida.TabIndex = 98;
            this.lblEdadValida.Text = "-";
            // 
            // VtnMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEdadValida);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblCitas);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.lblMascotas);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VtnMascotas";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascotas";
            this.Load += new System.EventHandler(this.VtnMascotas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
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
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblEdadValida;
    }
}