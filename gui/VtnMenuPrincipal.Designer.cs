
namespace Clave1_Grupo2
{
    partial class VtnMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnMenuPrincipal));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblSesion = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.lblRegistrarUsuario = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblVetCatDog = new System.Windows.Forms.Label();
            this.btnMisMascotas = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.Location = new System.Drawing.Point(8, 215);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(122, 24);
            this.lblSesion.TabIndex = 0;
            this.lblSesion.Text = "Iniciar Sesion";
            this.lblSesion.Click += new System.EventHandler(this.lblSesion_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgendar.BackgroundImage")));
            this.btnAgendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgendar.Location = new System.Drawing.Point(198, 176);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(130, 130);
            this.btnAgendar.TabIndex = 1;
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnAgregarMascota
            // 
            this.btnAgregarMascota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarMascota.BackgroundImage")));
            this.btnAgregarMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarMascota.Location = new System.Drawing.Point(198, 12);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(130, 130);
            this.btnAgregarMascota.TabIndex = 2;
            this.btnAgregarMascota.UseVisualStyleBackColor = true;
            this.btnAgregarMascota.Click += new System.EventHandler(this.btnAgregarMascota_Click);
            // 
            // lblRegistrarUsuario
            // 
            this.lblRegistrarUsuario.AutoSize = true;
            this.lblRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarUsuario.Location = new System.Drawing.Point(8, 250);
            this.lblRegistrarUsuario.Name = "lblRegistrarUsuario";
            this.lblRegistrarUsuario.Size = new System.Drawing.Size(153, 24);
            this.lblRegistrarUsuario.TabIndex = 3;
            this.lblRegistrarUsuario.Text = "Registrar Usuario";
            this.lblRegistrarUsuario.Click += new System.EventHandler(this.lblRegistrarUsuario_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(130, 130);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // lblVetCatDog
            // 
            this.lblVetCatDog.AutoSize = true;
            this.lblVetCatDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetCatDog.Location = new System.Drawing.Point(6, 142);
            this.lblVetCatDog.Name = "lblVetCatDog";
            this.lblVetCatDog.Size = new System.Drawing.Size(165, 64);
            this.lblVetCatDog.TabIndex = 5;
            this.lblVetCatDog.Text = "Veterinaria\r\nCat-Dog";
            // 
            // btnMisMascotas
            // 
            this.btnMisMascotas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMisMascotas.BackgroundImage")));
            this.btnMisMascotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMisMascotas.Location = new System.Drawing.Point(334, 12);
            this.btnMisMascotas.Name = "btnMisMascotas";
            this.btnMisMascotas.Size = new System.Drawing.Size(130, 130);
            this.btnMisMascotas.TabIndex = 6;
            this.btnMisMascotas.UseVisualStyleBackColor = true;
            this.btnMisMascotas.Click += new System.EventHandler(this.btnMisMascotas_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCitas.BackgroundImage")));
            this.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCitas.Location = new System.Drawing.Point(334, 176);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(130, 130);
            this.btnCitas.TabIndex = 7;
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agregar Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mis Mascotas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Agendar Cita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Citas";
            // 
            // VtnMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(897, 648);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lblVetCatDog);
            this.Controls.Add(this.btnMisMascotas);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnAgregarMascota);
            this.Controls.Add(this.lblRegistrarUsuario);
            this.Controls.Add(this.lblSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VtnMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Cat-Dog";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Label lblRegistrarUsuario;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblVetCatDog;
        private System.Windows.Forms.Button btnMisMascotas;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

