namespace Clave1_Grupo2.gui
{
    partial class VtnCartillaVacunacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnCartillaVacunacion));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxPropietario = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.apellido1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nombre1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMascota = new System.Windows.Forms.ComboBox();
            this.txtColorMascota = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.generoMascota = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.Label();
            this.nomMascota = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxVeterinario = new System.Windows.Forms.ComboBox();
            this.cbxTipoCita = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVacunaSeleccionada = new System.Windows.Forms.TextBox();
            this.btnVacuna = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblVetCatDog = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(337, 240);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 29);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbxPropietario);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.apellido1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.nombre1);
            this.groupBox2.Location = new System.Drawing.Point(14, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(292, 101);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            // 
            // cbxPropietario
            // 
            this.cbxPropietario.FormattingEnabled = true;
            this.cbxPropietario.Location = new System.Drawing.Point(100, 22);
            this.cbxPropietario.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPropietario.Name = "cbxPropietario";
            this.cbxPropietario.Size = new System.Drawing.Size(178, 21);
            this.cbxPropietario.TabIndex = 21;
            this.cbxPropietario.SelectedIndexChanged += new System.EventHandler(this.cbxPropietario_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 75);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // apellido1
            // 
            this.apellido1.AutoSize = true;
            this.apellido1.Location = new System.Drawing.Point(25, 77);
            this.apellido1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(32, 13);
            this.apellido1.TabIndex = 10;
            this.apellido1.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Propietario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // nombre1
            // 
            this.nombre1.AutoSize = true;
            this.nombre1.Location = new System.Drawing.Point(25, 51);
            this.nombre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(44, 13);
            this.nombre1.TabIndex = 6;
            this.nombre1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxMascota);
            this.groupBox1.Controls.Add(this.txtColorMascota);
            this.groupBox1.Controls.Add(this.color);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.generoMascota);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.edad);
            this.groupBox1.Controls.Add(this.nomMascota);
            this.groupBox1.Controls.Add(this.txtRaza);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEspecie);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.especie);
            this.groupBox1.Location = new System.Drawing.Point(14, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 229);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Mascota";
            // 
            // cbxMascota
            // 
            this.cbxMascota.FormattingEnabled = true;
            this.cbxMascota.Location = new System.Drawing.Point(131, 20);
            this.cbxMascota.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMascota.Name = "cbxMascota";
            this.cbxMascota.Size = new System.Drawing.Size(127, 21);
            this.cbxMascota.TabIndex = 20;
            this.cbxMascota.SelectedIndexChanged += new System.EventHandler(this.cbxMascota_SelectedIndexChanged);
            // 
            // txtColorMascota
            // 
            this.txtColorMascota.Location = new System.Drawing.Point(131, 201);
            this.txtColorMascota.Margin = new System.Windows.Forms.Padding(2);
            this.txtColorMascota.Name = "txtColorMascota";
            this.txtColorMascota.Size = new System.Drawing.Size(127, 20);
            this.txtColorMascota.TabIndex = 19;
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(20, 205);
            this.color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(31, 13);
            this.color.TabIndex = 18;
            this.color.Text = "Color";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(131, 170);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(127, 20);
            this.txtGenero.TabIndex = 17;
            // 
            // generoMascota
            // 
            this.generoMascota.AutoSize = true;
            this.generoMascota.Location = new System.Drawing.Point(20, 174);
            this.generoMascota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generoMascota.Name = "generoMascota";
            this.generoMascota.Size = new System.Drawing.Size(42, 13);
            this.generoMascota.TabIndex = 16;
            this.generoMascota.Text = "Genero";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(131, 137);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(127, 20);
            this.txtEdad.TabIndex = 15;
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(20, 141);
            this.edad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(32, 13);
            this.edad.TabIndex = 14;
            this.edad.Text = "Edad";
            // 
            // nomMascota
            // 
            this.nomMascota.Location = new System.Drawing.Point(131, 44);
            this.nomMascota.Margin = new System.Windows.Forms.Padding(2);
            this.nomMascota.Name = "nomMascota";
            this.nomMascota.Size = new System.Drawing.Size(127, 20);
            this.nomMascota.TabIndex = 9;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(131, 105);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(2);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(127, 20);
            this.txtRaza.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mascota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Raza";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(131, 73);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(2);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(127, 20);
            this.txtEspecie.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre de Mascota";
            // 
            // especie
            // 
            this.especie.AutoSize = true;
            this.especie.Location = new System.Drawing.Point(20, 77);
            this.especie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(45, 13);
            this.especie.TabIndex = 10;
            this.especie.Text = "Especie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cartilla Vacunacion";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbxVeterinario);
            this.groupBox3.Controls.Add(this.cbxTipoCita);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtVacunaSeleccionada);
            this.groupBox3.Controls.Add(this.btnVacuna);
            this.groupBox3.Location = new System.Drawing.Point(337, 51);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(277, 183);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso de Datos de Vacunas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Veterinario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 109;
            this.label9.Text = "Tipo de Cita";
            // 
            // cbxVeterinario
            // 
            this.cbxVeterinario.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVeterinario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxVeterinario.FormattingEnabled = true;
            this.cbxVeterinario.Location = new System.Drawing.Point(99, 146);
            this.cbxVeterinario.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(162, 23);
            this.cbxVeterinario.TabIndex = 108;
            // 
            // cbxTipoCita
            // 
            this.cbxTipoCita.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCita.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxTipoCita.FormattingEnabled = true;
            this.cbxTipoCita.Location = new System.Drawing.Point(99, 119);
            this.cbxTipoCita.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbxTipoCita.Name = "cbxTipoCita";
            this.cbxTipoCita.Size = new System.Drawing.Size(162, 23);
            this.cbxTipoCita.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Vacuna Seleccionada";
            // 
            // txtVacunaSeleccionada
            // 
            this.txtVacunaSeleccionada.Location = new System.Drawing.Point(19, 82);
            this.txtVacunaSeleccionada.Margin = new System.Windows.Forms.Padding(2);
            this.txtVacunaSeleccionada.Name = "txtVacunaSeleccionada";
            this.txtVacunaSeleccionada.Size = new System.Drawing.Size(227, 20);
            this.txtVacunaSeleccionada.TabIndex = 69;
            // 
            // btnVacuna
            // 
            this.btnVacuna.Location = new System.Drawing.Point(33, 24);
            this.btnVacuna.Margin = new System.Windows.Forms.Padding(2);
            this.btnVacuna.Name = "btnVacuna";
            this.btnVacuna.Size = new System.Drawing.Size(211, 32);
            this.btnVacuna.TabIndex = 68;
            this.btnVacuna.Text = "Seleccionar Vacuna";
            this.btnVacuna.UseVisualStyleBackColor = true;
            this.btnVacuna.Click += new System.EventHandler(this.btnVacuna_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(337, 273);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 32);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblVetCatDog
            // 
            this.lblVetCatDog.AutoSize = true;
            this.lblVetCatDog.BackColor = System.Drawing.Color.Transparent;
            this.lblVetCatDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetCatDog.Location = new System.Drawing.Point(384, 321);
            this.lblVetCatDog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVetCatDog.Name = "lblVetCatDog";
            this.lblVetCatDog.Size = new System.Drawing.Size(128, 52);
            this.lblVetCatDog.TabIndex = 108;
            this.lblVetCatDog.Text = "Veterinaria\r\nCat-Dog";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(516, 265);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 106);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 107;
            this.picLogo.TabStop = false;
            // 
            // VtnCartillaVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 382);
            this.Controls.Add(this.lblVetCatDog);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VtnCartillaVacunacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartillaVacunación";
            this.Load += new System.EventHandler(this.VtnCartillaVacunacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label apellido1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label nombre1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColorMascota;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label generoMascota;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.TextBox nomMascota;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxMascota;
        private System.Windows.Forms.ComboBox cbxPropietario;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnVacuna;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtVacunaSeleccionada;
        private System.Windows.Forms.ComboBox cbxVeterinario;
        private System.Windows.Forms.ComboBox cbxTipoCita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblVetCatDog;
        private System.Windows.Forms.PictureBox picLogo;
    }
}