
namespace Clave1_Grupo2.gui
{
    partial class VtnRegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtnRegistrarUsuario));
            this.picRegistroUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistroUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // picRegistroUsuario
            // 
            this.picRegistroUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picRegistroUsuario.Image")));
            this.picRegistroUsuario.Location = new System.Drawing.Point(258, 12);
            this.picRegistroUsuario.Name = "picRegistroUsuario";
            this.picRegistroUsuario.Size = new System.Drawing.Size(121, 121);
            this.picRegistroUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegistroUsuario.TabIndex = 0;
            this.picRegistroUsuario.TabStop = false;
            // 
            // VtnRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picRegistroUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VtnRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picRegistroUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRegistroUsuario;
    }
}