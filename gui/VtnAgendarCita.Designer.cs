
namespace Clave1_Grupo2.gui
{
    partial class VtnAgendarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnAgendarCita));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVetCatDog = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.campoFechaAgenda = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbxPropietario = new System.Windows.Forms.ComboBox();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.cbxMascota = new System.Windows.Forms.ComboBox();
            this.lblMascota = new System.Windows.Forms.Label();
            this.cbxVeterinario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoCita = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.pbxFotoPerfil);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.lblVetCatDog);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 450);
            this.panel2.TabIndex = 62;
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(41, 170);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 29);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "Agendar Cita";
            // 
            // lblVetCatDog
            // 
            this.lblVetCatDog.AutoSize = true;
            this.lblVetCatDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetCatDog.ForeColor = System.Drawing.Color.White;
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
            // campoFechaAgenda
            // 
            this.campoFechaAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.campoFechaAgenda.Location = new System.Drawing.Point(657, 27);
            this.campoFechaAgenda.MaxDate = new System.DateTime(2025, 1, 18, 0, 0, 0, 0);
            this.campoFechaAgenda.MinDate = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            this.campoFechaAgenda.Name = "campoFechaAgenda";
            this.campoFechaAgenda.Size = new System.Drawing.Size(131, 22);
            this.campoFechaAgenda.TabIndex = 63;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(657, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 308);
            this.listBox1.TabIndex = 64;
            // 
            // cbxPropietario
            // 
            this.cbxPropietario.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPropietario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxPropietario.FormattingEnabled = true;
            this.cbxPropietario.Location = new System.Drawing.Point(342, 87);
            this.cbxPropietario.Name = "cbxPropietario";
            this.cbxPropietario.Size = new System.Drawing.Size(308, 26);
            this.cbxPropietario.TabIndex = 3;
            this.cbxPropietario.SelectedIndexChanged += new System.EventHandler(this.cbxPropietario_SelectedIndexChanged);
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPropietario.Location = new System.Drawing.Point(229, 87);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(90, 20);
            this.lblPropietario.TabIndex = 92;
            this.lblPropietario.Text = "Propietario";
            // 
            // cbxMascota
            // 
            this.cbxMascota.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMascota.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxMascota.FormattingEnabled = true;
            this.cbxMascota.Location = new System.Drawing.Point(342, 119);
            this.cbxMascota.Name = "cbxMascota";
            this.cbxMascota.Size = new System.Drawing.Size(308, 26);
            this.cbxMascota.TabIndex = 4;
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMascota.Location = new System.Drawing.Point(229, 119);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(73, 20);
            this.lblMascota.TabIndex = 94;
            this.lblMascota.Text = "Mascota";
            // 
            // cbxVeterinario
            // 
            this.cbxVeterinario.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVeterinario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxVeterinario.FormattingEnabled = true;
            this.cbxVeterinario.Location = new System.Drawing.Point(342, 23);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(308, 26);
            this.cbxVeterinario.TabIndex = 1;
            this.cbxVeterinario.SelectedIndexChanged += new System.EventHandler(this.cbxVeterinario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(229, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Veterinario";
            // 
            // cbxTipoCita
            // 
            this.cbxTipoCita.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCita.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxTipoCita.FormattingEnabled = true;
            this.cbxTipoCita.Location = new System.Drawing.Point(342, 55);
            this.cbxTipoCita.Name = "cbxTipoCita";
            this.cbxTipoCita.Size = new System.Drawing.Size(308, 26);
            this.cbxTipoCita.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(229, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Tipo de cita";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(342, 182);
            this.txtMotivo.MaxLength = 250;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(308, 181);
            this.txtMotivo.TabIndex = 99;
            this.txtMotivo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(229, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Motivo de su visita:";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(657, 375);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(131, 44);
            this.btnAgendar.TabIndex = 101;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // VtnAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.cbxTipoCita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxVeterinario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMascota);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.cbxPropietario);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.campoFechaAgenda);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VtnAgendarCita";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Cita";
            this.Load += new System.EventHandler(this.VtnAgendarCita_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxFotoPerfil;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVetCatDog;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DateTimePicker campoFechaAgenda;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbxPropietario;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.ComboBox cbxMascota;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.ComboBox cbxVeterinario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgendar;
    }
}