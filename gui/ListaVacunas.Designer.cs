namespace Clave1_Grupo2.gui
{
    partial class ListaVacunas
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
            this.dataGridViewVacunacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacunacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacunacion
            // 
            this.dataGridViewVacunacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacunacion.Location = new System.Drawing.Point(8, 12);
            this.dataGridViewVacunacion.Name = "dataGridViewVacunacion";
            this.dataGridViewVacunacion.RowHeadersWidth = 62;
            this.dataGridViewVacunacion.RowTemplate.Height = 28;
            this.dataGridViewVacunacion.Size = new System.Drawing.Size(996, 477);
            this.dataGridViewVacunacion.TabIndex = 0;
            this.dataGridViewVacunacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVacunacion_CellClick);
            this.dataGridViewVacunacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVacunacion_CellClick);
            // 
            // ListaVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 495);
            this.Controls.Add(this.dataGridViewVacunacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaVacunas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaVacunas";
            this.Load += new System.EventHandler(this.ListaVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacunacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVacunacion;
    }
}