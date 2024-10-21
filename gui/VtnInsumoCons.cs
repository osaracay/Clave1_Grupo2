using Clave1_Grupo2.entity;
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
    public partial class VtnInsumoCons : Form
    {
        private List<Insumo> mInsumos;
        private Insumo mInsumo;
        private ConsultaInsumo mConsultaInsumo;

        // Propiedades para devolver los valores seleccionados
        public string InsumoId { get; private set; }
        public string InsumoNombre { get; private set; }
        public string InsumoPrecio { get; private set; }
        public string InsumoMedida { get; private set; }
        public string InsumoCantidad { get; private set; }
        public string InsumoStockMinimo { get; private set; }

        public VtnInsumoCons()
        {
            InitializeComponent();
            mInsumos = new List<Insumo>();
            mConsultaInsumo = new ConsultaInsumo();
            mInsumo = new Insumo();
            txtBuscar.Focus();
            ConfigurarDGV();
            cargarInsumos();

            dgvRegistros.CellDoubleClick += DgvRegistros_CellDoubleClick;
        }

        private void DgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvRegistros.Rows[e.RowIndex];

                // Guardar los valores seleccionados en las propiedades
                InsumoId = row.Cells["Id"].Value.ToString();
                InsumoNombre = row.Cells["nombre"].Value.ToString();
                InsumoPrecio = row.Cells["precio"].Value.ToString();
                InsumoMedida = row.Cells["medida"].Value.ToString();
                InsumoCantidad = row.Cells["cantidad"].Value.ToString();
                InsumoStockMinimo = row.Cells["stockm"].Value.ToString();

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void cargarInsumos(string filtro = "")
        {
            dgvRegistros.Rows.Clear();
            dgvRegistros.Refresh();
            mInsumos.Clear();
            mInsumos = mConsultaInsumo.getInsumos(filtro);

            for (int i = 0; i < mInsumos.Count(); i++)
            {

                dgvRegistros.Rows.Add(
                    mInsumos[i].id_insumo,
                    mInsumos[i].nom_insumo,
                    mInsumos[i].id_tipo_insumo,
                    mInsumos[i].precio_unit.ToString("N2"),
                    mInsumos[i].unit_medida,
                    mInsumos[i].existencias_insumo);
            }
        }
         private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarInsumos(txtBuscar.Text.Trim());
        }

        private void ConfigurarDGV()
        {
            dgvRegistros.Columns.Clear();
            dgvRegistros.Columns.Add("Id", "Id");
            dgvRegistros.Columns.Add("nombre", "Nombre de Insumo");
            dgvRegistros.Columns.Add("tipo", "TP");
            dgvRegistros.Columns.Add("precio", "Precio");
            dgvRegistros.Columns.Add("medida", "U-Medida");
            dgvRegistros.Columns.Add("cantidad", "Existencia");

            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.Columns["Id"].Width = 70;
            dgvRegistros.Columns["nombre"].Width = 340;
            dgvRegistros.Columns["tipo"].Width = 0;
            dgvRegistros.Columns["precio"].Width = 100;
            dgvRegistros.Columns["medida"].Width = 80;
            dgvRegistros.Columns["cantidad"].Width = 100;
            dgvRegistros.Columns["stockm"].Width = 100;

            dgvRegistros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRegistros.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dgvRegistros.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvRegistros.Cursor = Cursors.Hand;

            dgvRegistros.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRegistros.Columns["nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRegistros.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRegistros.Columns["precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRegistros.Columns["medida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRegistros.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRegistros.Columns["stockm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvRegistros.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular);
            dgvRegistros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            dgvRegistros.Columns["precio"].DefaultCellStyle.Format = "N2"; // N2 Aplicar formato con 2 decimales
            dgvRegistros.Columns["cantidad"].DefaultCellStyle.Format = "N0";
            dgvRegistros.Columns["stockm"].DefaultCellStyle.Format = "N0";

        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    var row = dgvRegistros.Rows[e.RowIndex];

            //    // Guardar los valores seleccionados en las propiedades
            //    InsumoId = row.Cells["Id"].Value.ToString();
            //    InsumoNombre = row.Cells["nombre"].Value.ToString();
            //    InsumoPrecio = row.Cells["precio"].Value.ToString();
            //    InsumoMedida = row.Cells["medida"].Value.ToString();
            //    InsumoCantidad = row.Cells["cantidad"].Value.ToString();
            //    InsumoStockMinimo = row.Cells["stockm"].Value.ToString();

            //    DialogResult = DialogResult.OK;
            //    this.Close();
            //}
        }

        private void dgvRegistros_DoubleClick(object sender, EventArgs e)
        {/*
            if (e.RowIndex >= 0)
            {
                var row = dgvRegistros.Rows[e.RowIndex];

                // Guardar los valores seleccionados en las propiedades
                InsumoId = row.Cells["Id"].Value.ToString();
                InsumoNombre = row.Cells["nombre"].Value.ToString();
                InsumoPrecio = row.Cells["precio"].Value.ToString();
                InsumoMedida = row.Cells["medida"].Value.ToString();
                InsumoCantidad = row.Cells["cantidad"].Value.ToString();
                InsumoStockMinimo = row.Cells["stockm"].Value.ToString();

                DialogResult = DialogResult.OK;
                this.Close();
            }
            */
        }
    }
}
