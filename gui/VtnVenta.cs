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
    public partial class VtnVenta : Form
    {
        public VtnVenta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            cmbIdCliente.SelectedIndex = -1;
            txtCliente.Text = "";
            cmbIdInsumo.SelectedIndex = -1;
            txtInsumo.Text = "";
            txtMedida.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtStock.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            cmbMetPago.SelectedIndex = -1;

            dgvLstProductos.Rows.Clear();
            txtTotal.Text = "";
        }
    }
}
