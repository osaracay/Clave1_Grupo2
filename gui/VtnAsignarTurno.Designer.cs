
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
            this.cbxVeterinario.Location = new System.Drawing.Point(102, 18);
            this.cbxVeterinario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(232, 23);
            this.cbxVeterinario.TabIndex = 97;
            this.cbxVeterinario.SelectedIndexChanged += new System.EventHandler(this.cbxVeterinario_SelectedIndexChanged);
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.BackColor = System.Drawing.Color.Transparent;
            this.lblVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.ForeColor = System.Drawing.Color.Black;
            this.lblVet.Location = new System.Drawing.Point(17, 18);
            this.lblVet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(77, 17);
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
            this.cbxTurno.Location = new System.Drawing.Point(102, 58);
            this.cbxTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(232, 23);
            this.cbxTurno.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
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
            this.grpDiaDesc.Location = new System.Drawing.Point(114, 100);
            this.grpDiaDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDiaDesc.Name = "grpDiaDesc";
            this.grpDiaDesc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDiaDesc.Size = new System.Drawing.Size(219, 133);
            this.grpDiaDesc.TabIndex = 101;
            this.grpDiaDesc.TabStop = false;
            this.grpDiaDesc.Text = "Dias de descanso";
            // 
            // chkDom
            // 
            this.chkDom.AutoSize = true;
            this.chkDom.Location = new System.Drawing.Point(82, 26);
            this.chkDom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDom.Name = "chkDom";
            this.chkDom.Size = new System.Drawing.Size(81, 21);
            this.chkDom.TabIndex = 6;
            this.chkDom.Text = "domingo";
            this.chkDom.UseVisualStyleBackColor = true;
            this.chkDom.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkSab
            // 
            this.chkSab.AutoSize = true;
            this.chkSab.Location = new System.Drawing.Point(127, 114);
            this.chkSab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSab.Name = "chkSab";
            this.chkSab.Size = new System.Drawing.Size(74, 21);
            this.chkSab.TabIndex = 5;
            this.chkSab.Text = "sábado";
            this.chkSab.UseVisualStyleBackColor = true;
            this.chkSab.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkVie
            // 
            this.chkVie.AutoSize = true;
            this.chkVie.Location = new System.Drawing.Point(35, 114);
            this.chkVie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkVie.Name = "chkVie";
            this.chkVie.Size = new System.Drawing.Size(73, 21);
            this.chkVie.TabIndex = 4;
            this.chkVie.Text = "viernes";
            this.chkVie.UseVisualStyleBackColor = true;
            this.chkVie.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkJue
            // 
            this.chkJue.AutoSize = true;
            this.chkJue.Location = new System.Drawing.Point(127, 84);
            this.chkJue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkJue.Name = "chkJue";
            this.chkJue.Size = new System.Drawing.Size(68, 21);
            this.chkJue.TabIndex = 3;
            this.chkJue.Text = "jueves";
            this.chkJue.UseVisualStyleBackColor = true;
            this.chkJue.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkMie
            // 
            this.chkMie.AutoSize = true;
            this.chkMie.Location = new System.Drawing.Point(35, 84);
            this.chkMie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMie.Name = "chkMie";
            this.chkMie.Size = new System.Drawing.Size(87, 21);
            this.chkMie.TabIndex = 2;
            this.chkMie.Text = "miércoles";
            this.chkMie.UseVisualStyleBackColor = true;
            this.chkMie.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkMar
            // 
            this.chkMar.AutoSize = true;
            this.chkMar.Location = new System.Drawing.Point(127, 52);
            this.chkMar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMar.Name = "chkMar";
            this.chkMar.Size = new System.Drawing.Size(70, 21);
            this.chkMar.TabIndex = 1;
            this.chkMar.Text = "martes";
            this.chkMar.UseVisualStyleBackColor = true;
            this.chkMar.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkLun
            // 
            this.chkLun.AutoSize = true;
            this.chkLun.Location = new System.Drawing.Point(35, 52);
            this.chkLun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLun.Name = "chkLun";
            this.chkLun.Size = new System.Drawing.Size(61, 21);
            this.chkLun.TabIndex = 0;
            this.chkLun.Text = "lunes";
            this.chkLun.UseVisualStyleBackColor = true;
            this.chkLun.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(20, 255);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(102, 54);
            this.btnAsignar.TabIndex = 102;
            this.btnAsignar.Text = "ASIGNAR";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnReasignar
            // 
            this.btnReasignar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReasignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReasignar.Location = new System.Drawing.Point(125, 255);
            this.btnReasignar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReasignar.Name = "btnReasignar";
            this.btnReasignar.Size = new System.Drawing.Size(102, 54);
            this.btnReasignar.TabIndex = 103;
            this.btnReasignar.Text = "REASIGNAR";
            this.btnReasignar.UseVisualStyleBackColor = false;
            this.btnReasignar.Click += new System.EventHandler(this.btnReasignar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(231, 255);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 54);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblVetCatDog
            // 
            this.lblVetCatDog.AutoSize = true;
            this.lblVetCatDog.BackColor = System.Drawing.Color.Transparent;
            this.lblVetCatDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetCatDog.Location = new System.Drawing.Point(-6, 193);
            this.lblVetCatDog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVetCatDog.Name = "lblVetCatDog";
            this.lblVetCatDog.Size = new System.Drawing.Size(128, 52);
            this.lblVetCatDog.TabIndex = 106;
            this.lblVetCatDog.Text = "Veterinaria\r\nCat-Dog";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(2, 85);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 106);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 105;
            this.picLogo.TabStop = false;
            // 
            // VtnAsignarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(365, 320);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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