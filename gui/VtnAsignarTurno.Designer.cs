
namespace Clave1_Grupo2.gui
{
    partial class VtnAsignarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnAsignarTurno));
            this.cbxVeterinario = new System.Windows.Forms.ComboBox();
            this.lblVet = new System.Windows.Forms.Label();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDiaDesc = new System.Windows.Forms.GroupBox();
            this.chkDom = new System.Windows.Forms.CheckBox();
            this.chkSab = new System.Windows.Forms.CheckBox();
            this.chkVie = new System.Windows.Forms.CheckBox();
            this.chkJue = new System.Windows.Forms.CheckBox();
            this.chkMie = new System.Windows.Forms.CheckBox();
            this.chkMar = new System.Windows.Forms.CheckBox();
            this.chkLun = new System.Windows.Forms.CheckBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnReasignar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblVetCatDog = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpDiaDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxVeterinario
            // 
            this.cbxVeterinario.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVeterinario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxVeterinario.FormattingEnabled = true;
            this.cbxVeterinario.Location = new System.Drawing.Point(136, 22);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(308, 26);
            this.cbxVeterinario.TabIndex = 97;
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.BackColor = System.Drawing.Color.Transparent;
            this.lblVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.ForeColor = System.Drawing.Color.Black;
            this.lblVet.Location = new System.Drawing.Point(23, 22);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(90, 20);
            this.lblVet.TabIndex = 98;
            this.lblVet.Text = "Veterinario";
            // 
            // cbxTurno
            // 
            this.cbxTurno.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTurno.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Location = new System.Drawing.Point(136, 72);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(308, 26);
            this.cbxTurno.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Turno";
            // 
            // grpDiaDesc
            // 
            this.grpDiaDesc.BackColor = System.Drawing.Color.Transparent;
            this.grpDiaDesc.Controls.Add(this.chkDom);
            this.grpDiaDesc.Controls.Add(this.chkSab);
            this.grpDiaDesc.Controls.Add(this.chkVie);
            this.grpDiaDesc.Controls.Add(this.chkJue);
            this.grpDiaDesc.Controls.Add(this.chkMie);
            this.grpDiaDesc.Controls.Add(this.chkMar);
            this.grpDiaDesc.Controls.Add(this.chkLun);
            this.grpDiaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDiaDesc.Location = new System.Drawing.Point(152, 123);
            this.grpDiaDesc.Name = "grpDiaDesc";
            this.grpDiaDesc.Size = new System.Drawing.Size(292, 164);
            this.grpDiaDesc.TabIndex = 101;
            this.grpDiaDesc.TabStop = false;
            this.grpDiaDesc.Text = "Dias de descanso";
            // 
            // chkDom
            // 
            this.chkDom.AutoSize = true;
            this.chkDom.Location = new System.Drawing.Point(109, 32);
            this.chkDom.Name = "chkDom";
            this.chkDom.Size = new System.Drawing.Size(94, 24);
            this.chkDom.TabIndex = 6;
            this.chkDom.Text = "domingo";
            this.chkDom.UseVisualStyleBackColor = true;
            // 
            // chkSab
            // 
            this.chkSab.AutoSize = true;
            this.chkSab.Location = new System.Drawing.Point(169, 140);
            this.chkSab.Name = "chkSab";
            this.chkSab.Size = new System.Drawing.Size(85, 24);
            this.chkSab.TabIndex = 5;
            this.chkSab.Text = "sábado";
            this.chkSab.UseVisualStyleBackColor = true;
            // 
            // chkVie
            // 
            this.chkVie.AutoSize = true;
            this.chkVie.Location = new System.Drawing.Point(169, 102);
            this.chkVie.Name = "chkVie";
            this.chkVie.Size = new System.Drawing.Size(85, 24);
            this.chkVie.TabIndex = 4;
            this.chkVie.Text = "viernes";
            this.chkVie.UseVisualStyleBackColor = true;
            // 
            // chkJue
            // 
            this.chkJue.AutoSize = true;
            this.chkJue.Location = new System.Drawing.Point(169, 64);
            this.chkJue.Name = "chkJue";
            this.chkJue.Size = new System.Drawing.Size(79, 24);
            this.chkJue.TabIndex = 3;
            this.chkJue.Text = "jueves";
            this.chkJue.UseVisualStyleBackColor = true;
            // 
            // chkMie
            // 
            this.chkMie.AutoSize = true;
            this.chkMie.Location = new System.Drawing.Point(52, 140);
            this.chkMie.Name = "chkMie";
            this.chkMie.Size = new System.Drawing.Size(104, 24);
            this.chkMie.TabIndex = 2;
            this.chkMie.Text = "miércoles";
            this.chkMie.UseVisualStyleBackColor = true;
            // 
            // chkMar
            // 
            this.chkMar.AutoSize = true;
            this.chkMar.Location = new System.Drawing.Point(52, 102);
            this.chkMar.Name = "chkMar";
            this.chkMar.Size = new System.Drawing.Size(83, 24);
            this.chkMar.TabIndex = 1;
            this.chkMar.Text = "martes";
            this.chkMar.UseVisualStyleBackColor = true;
            // 
            // chkLun
            // 
            this.chkLun.AutoSize = true;
            this.chkLun.Location = new System.Drawing.Point(52, 64);
            this.chkLun.Name = "chkLun";
            this.chkLun.Size = new System.Drawing.Size(71, 24);
            this.chkLun.TabIndex = 0;
            this.chkLun.Text = "lunes";
            this.chkLun.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(27, 314);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(136, 67);
            this.btnAsignar.TabIndex = 102;
            this.btnAsignar.Text = "ASIGNAR";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnReasignar
            // 
            this.btnReasignar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReasignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReasignar.Location = new System.Drawing.Point(167, 314);
            this.btnReasignar.Name = "btnReasignar";
            this.btnReasignar.Size = new System.Drawing.Size(136, 67);
            this.btnReasignar.TabIndex = 103;
            this.btnReasignar.Text = "REASIGNAR";
            this.btnReasignar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(308, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 67);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblVetCatDog
            // 
            this.lblVetCatDog.AutoSize = true;
            this.lblVetCatDog.BackColor = System.Drawing.Color.Transparent;
            this.lblVetCatDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetCatDog.Location = new System.Drawing.Point(-8, 238);
            this.lblVetCatDog.Name = "lblVetCatDog";
            this.lblVetCatDog.Size = new System.Drawing.Size(165, 64);
            this.lblVetCatDog.TabIndex = 106;
            this.lblVetCatDog.Text = "Veterinaria\r\nCat-Dog";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(2, 105);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(131, 130);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 105;
            this.picLogo.TabStop = false;
            // 
            // VtnAsignarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 394);
            this.Controls.Add(this.lblVetCatDog);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReasignar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.grpDiaDesc);
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxVeterinario);
            this.Controls.Add(this.lblVet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VtnAsignarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar turno veterinario";
            this.grpDiaDesc.ResumeLayout(false);
            this.grpDiaDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxVeterinario;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.ComboBox cbxTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDiaDesc;
        private System.Windows.Forms.CheckBox chkSab;
        private System.Windows.Forms.CheckBox chkVie;
        private System.Windows.Forms.CheckBox chkJue;
        private System.Windows.Forms.CheckBox chkMie;
        private System.Windows.Forms.CheckBox chkMar;
        private System.Windows.Forms.CheckBox chkLun;
        private System.Windows.Forms.CheckBox chkDom;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnReasignar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblVetCatDog;
        private System.Windows.Forms.PictureBox picLogo;
    }
}