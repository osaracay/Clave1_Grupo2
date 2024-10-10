using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.gui
{
    public partial class VtnInsumo : Form
    {
        public VtnInsumo()
        {
            InitializeComponent();
            ConfigurarDGV();
        }
        private void ConfigurarDGV()
        {
            dgvLstProductos.Columns.Clear();
            dgvLstProductos.Columns.Add("Id", "Id");
            dgvLstProductos.Columns.Add("nombre", "Nombre de Insumo");
            dgvLstProductos.Columns.Add("tipo", "TP");
            dgvLstProductos.Columns.Add("precio", "Precio");
            dgvLstProductos.Columns.Add("medida", "U-Medida");
            dgvLstProductos.Columns.Add("cantidad", "Existencia");
            dgvLstProductos.Columns.Add("stockm", "ROP");

            dgvLstProductos.AllowUserToAddRows = false;
            dgvLstProductos.Columns["Id"].Width = 70;
            dgvLstProductos.Columns["nombre"].Width = 340;
            dgvLstProductos.Columns["tipo"].Width = 0;
            dgvLstProductos.Columns["precio"].Width = 100;
            dgvLstProductos.Columns["medida"].Width = 80;
            dgvLstProductos.Columns["cantidad"].Width = 100;
            dgvLstProductos.Columns["stockm"].Width = 100;

            dgvLstProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLstProductos.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dgvLstProductos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvLstProductos.Cursor = Cursors.Hand;

            dgvLstProductos.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLstProductos.Columns["nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvLstProductos.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLstProductos.Columns["precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLstProductos.Columns["medida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLstProductos.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLstProductos.Columns["stockm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvLstProductos.DefaultCellStyle.Font = new Font("Arial", 11F, FontStyle.Regular);
            dgvLstProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11F, FontStyle.Bold);

            dgvLstProductos.Columns["precio"].DefaultCellStyle.Format = "C2"; // N2 Aplicar formato con 2 decimales
            dgvLstProductos.Columns["cantidad"].DefaultCellStyle.Format = "N0";
            dgvLstProductos.Columns["stockm"].DefaultCellStyle.Format = "N0";

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
