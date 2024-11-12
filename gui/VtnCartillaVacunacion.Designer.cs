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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(530, 489);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 45);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxPropietario);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.apellido1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.nombre1);
            this.groupBox2.Location = new System.Drawing.Point(21, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 155);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            // 
            // cbxPropietario
            // 
            this.cbxPropietario.FormattingEnabled = true;
            this.cbxPropietario.Location = new System.Drawing.Point(150, 34);
            this.cbxPropietario.Name = "cbxPropietario";
            this.cbxPropietario.Size = new System.Drawing.Size(265, 28);
            this.cbxPropietario.TabIndex = 21;
            this.cbxPropietario.SelectedIndexChanged += new System.EventHandler(this.cbxPropietario_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // apellido1
            // 
            this.apellido1.AutoSize = true;
            this.apellido1.Location = new System.Drawing.Point(38, 118);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(48, 20);
            this.apellido1.TabIndex = 10;
            this.apellido1.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Propietario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // nombre1
            // 
            this.nombre1.AutoSize = true;
            this.nombre1.Location = new System.Drawing.Point(38, 78);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(65, 20);
            this.nombre1.TabIndex = 6;
            this.nombre1.Text = "Nombre";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(21, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 352);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Mascota";
            // 
            // cbxMascota
            // 
            this.cbxMascota.FormattingEnabled = true;
            this.cbxMascota.Location = new System.Drawing.Point(196, 31);
            this.cbxMascota.Name = "cbxMascota";
            this.cbxMascota.Size = new System.Drawing.Size(188, 28);
            this.cbxMascota.TabIndex = 20;
            this.cbxMascota.SelectedIndexChanged += new System.EventHandler(this.cbxMascota_SelectedIndexChanged);
            // 
            // txtColorMascota
            // 
            this.txtColorMascota.Location = new System.Drawing.Point(196, 309);
            this.txtColorMascota.Name = "txtColorMascota";
            this.txtColorMascota.Size = new System.Drawing.Size(188, 26);
            this.txtColorMascota.TabIndex = 19;
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(30, 315);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(46, 20);
            this.color.TabIndex = 18;
            this.color.Text = "Color";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(196, 262);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(188, 26);
            this.txtGenero.TabIndex = 17;
            // 
            // generoMascota
            // 
            this.generoMascota.AutoSize = true;
            this.generoMascota.Location = new System.Drawing.Point(30, 268);
            this.generoMascota.Name = "generoMascota";
            this.generoMascota.Size = new System.Drawing.Size(63, 20);
            this.generoMascota.TabIndex = 16;
            this.generoMascota.Text = "Genero";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(196, 211);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(188, 26);
            this.txtEdad.TabIndex = 15;
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(30, 217);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(47, 20);
            this.edad.TabIndex = 14;
            this.edad.Text = "Edad";
            // 
            // nomMascota
            // 
            this.nomMascota.Location = new System.Drawing.Point(196, 68);
            this.nomMascota.Name = "nomMascota";
            this.nomMascota.Size = new System.Drawing.Size(188, 26);
            this.nomMascota.TabIndex = 9;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(196, 162);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(188, 26);
            this.txtRaza.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mascota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Raza";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(196, 112);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(188, 26);
            this.txtEspecie.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre de Mascota";
            // 
            // especie
            // 
            this.especie.AutoSize = true;
            this.especie.Location = new System.Drawing.Point(30, 118);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(66, 20);
            this.especie.TabIndex = 10;
            this.especie.Text = "Especie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cartilla Vacunacion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbxVeterinario);
            this.groupBox3.Controls.Add(this.cbxTipoCita);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtVacunaSeleccionada);
            this.groupBox3.Controls.Add(this.btnVacuna);
            this.groupBox3.Location = new System.Drawing.Point(505, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 282);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso de Datos de Vacunas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 110;
            this.label10.Text = "Veterinario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
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
            this.cbxVeterinario.Location = new System.Drawing.Point(149, 224);
            this.cbxVeterinario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(241, 30);
            this.cbxVeterinario.TabIndex = 108;
            // 
            // cbxTipoCita
            // 
            this.cbxTipoCita.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCita.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxTipoCita.FormattingEnabled = true;
            this.cbxTipoCita.Location = new System.Drawing.Point(149, 183);
            this.cbxTipoCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipoCita.Name = "cbxTipoCita";
            this.cbxTipoCita.Size = new System.Drawing.Size(241, 30);
            this.cbxTipoCita.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Vacuna Seleccionada";
            // 
            // txtVacunaSeleccionada
            // 
            this.txtVacunaSeleccionada.Location = new System.Drawing.Point(28, 126);
            this.txtVacunaSeleccionada.Name = "txtVacunaSeleccionada";
            this.txtVacunaSeleccionada.Size = new System.Drawing.Size(338, 26);
            this.txtVacunaSeleccionada.TabIndex = 69;
            // 
            // btnVacuna
            // 
            this.btnVacuna.Location = new System.Drawing.Point(49, 37);
            this.btnVacuna.Name = "btnVacuna";
            this.btnVacuna.Size = new System.Drawing.Size(317, 49);
            this.btnVacuna.TabIndex = 68;
            this.btnVacuna.Text = "Seleccionar Vacuna";
            this.btnVacuna.UseVisualStyleBackColor = true;
            this.btnVacuna.Click += new System.EventHandler(this.btnVacuna_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(740, 489);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 49);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // VtnCartillaVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 588);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}