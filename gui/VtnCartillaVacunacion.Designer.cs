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
            this.button1 = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxTipoCita = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVacuna = new System.Windows.Forms.TextBox();
            this.campoFechaAgenda = new System.Windows.Forms.DateTimePicker();
            this.txtPulso = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbxCupos = new System.Windows.Forms.ListBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1288, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 45);
            this.button1.TabIndex = 28;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxPropietario);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.apellido1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.nombre1);
            this.groupBox2.Location = new System.Drawing.Point(38, 481);
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
            this.groupBox1.Location = new System.Drawing.Point(38, 108);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cartilla Vacunacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Falta Fechas/Vacunas/Dosis/ProximaCita";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxTipoCita);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtVacuna);
            this.groupBox3.Controls.Add(this.campoFechaAgenda);
            this.groupBox3.Controls.Add(this.txtPulso);
            this.groupBox3.Controls.Add(this.txtPeso);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(537, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 282);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso de Datos de Vacunas";
            // 
            // cbxTipoCita
            // 
            this.cbxTipoCita.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCita.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxTipoCita.FormattingEnabled = true;
            this.cbxTipoCita.Location = new System.Drawing.Point(149, 154);
            this.cbxTipoCita.Name = "cbxTipoCita";
            this.cbxTipoCita.Size = new System.Drawing.Size(319, 30);
            this.cbxTipoCita.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 66;
            this.label13.Text = "Tipo de Cita";
            // 
            // txtVacuna
            // 
            this.txtVacuna.Location = new System.Drawing.Point(149, 112);
            this.txtVacuna.Name = "txtVacuna";
            this.txtVacuna.Size = new System.Drawing.Size(319, 26);
            this.txtVacuna.TabIndex = 8;
            // 
            // campoFechaAgenda
            // 
            this.campoFechaAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFechaAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.campoFechaAgenda.Location = new System.Drawing.Point(149, 195);
            this.campoFechaAgenda.MaxDate = new System.DateTime(2025, 1, 18, 0, 0, 0, 0);
            this.campoFechaAgenda.MinDate = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            this.campoFechaAgenda.Name = "campoFechaAgenda";
            this.campoFechaAgenda.Size = new System.Drawing.Size(319, 30);
            this.campoFechaAgenda.TabIndex = 65;
            this.campoFechaAgenda.ValueChanged += new System.EventHandler(this.campoFechaAgenda_ValueChanged);
            // 
            // txtPulso
            // 
            this.txtPulso.Location = new System.Drawing.Point(149, 75);
            this.txtPulso.Name = "txtPulso";
            this.txtPulso.Size = new System.Drawing.Size(319, 26);
            this.txtPulso.TabIndex = 7;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(149, 38);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(319, 26);
            this.txtPeso.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Proxima Cita";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Vacuna";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Pulso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Peso";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(537, 417);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(728, 219);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1288, 590);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 49);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbxCupos
            // 
            this.lbxCupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCupos.FormattingEnabled = true;
            this.lbxCupos.ItemHeight = 25;
            this.lbxCupos.Location = new System.Drawing.Point(1091, 133);
            this.lbxCupos.Name = "lbxCupos";
            this.lbxCupos.Size = new System.Drawing.Size(332, 254);
            this.lbxCupos.TabIndex = 66;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgendar.BackgroundImage")));
            this.btnAgendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(1307, 417);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(116, 98);
            this.btnAgendar.TabIndex = 102;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgendar.UseVisualStyleBackColor = true;
            // 
            // VtnCartillaVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1578, 669);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lbxCupos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxMascota;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtVacuna;
        private System.Windows.Forms.TextBox txtPulso;
        private System.Windows.Forms.ComboBox cbxPropietario;
        private System.Windows.Forms.DateTimePicker campoFechaAgenda;
        private System.Windows.Forms.ListBox lbxCupos;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxTipoCita;
    }
}