
namespace Clave1_Grupo2.gui
{
    partial class VntTipoInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VntTipoInsumo));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.brnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(17, 53);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(257, 30);
            this.txtNombre.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 24);
            this.label11.TabIndex = 107;
            this.label11.Text = "Nombre :";
            // 
            // brnGuardar
            // 
            this.brnGuardar.BackColor = System.Drawing.Color.White;
            this.brnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnGuardar.ForeColor = System.Drawing.Color.Black;
            this.brnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("brnGuardar.Image")));
            this.brnGuardar.Location = new System.Drawing.Point(167, 106);
            this.brnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.brnGuardar.Name = "brnGuardar";
            this.brnGuardar.Size = new System.Drawing.Size(107, 80);
            this.brnGuardar.TabIndex = 1;
            this.brnGuardar.Text = "Guardar";
            this.brnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brnGuardar.UseVisualStyleBackColor = false;
            this.brnGuardar.Click += new System.EventHandler(this.brnGuardar_Click);
            // 
            // VntTipoInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 197);
            this.Controls.Add(this.brnGuardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombre);
            this.Name = "VntTipoInsumo";
            this.Text = "Tipo de Insumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button brnGuardar;
    }
}