using Clave1_Grupo2.dao;
using Clave1_Grupo2.util;
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
            Rellenador.CargarDataTableACombo(cmbMetPago, CatDAO.GetMetPago(), "id_met_pago", "nom_met_pago");
            Rellenador.CargarDataTableACombo(cmbEstado, CatDAO.GetEstadoPago(), "id_estado_pago", "nom_estado_pago");
            Rellenador.CargarDataTableACombo(cmbIdCliente, CatDAO.GetUsuarios(), "nombre", "id_usuario");
            Rellenador.CargarDataTableACombo(cmbIdInsumo, CatDAO.GetInsumos(), "nombre", "id_usuario");
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

        private void brnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números, punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Solo permite un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números, punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Solo permite un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void cmbIdInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdInsumo.SelectedIndex != -1)
            {
                // Obtener el elemento seleccionado
                DataRowView selectedItem = (DataRowView)cmbIdInsumo.SelectedItem;

                // Mostrar el nom_tipo_insumo en el TextBox
                txtInsumo.Text = selectedItem["nom_insumo"].ToString();
                txtMedida.Text = selectedItem["unit_medida"].ToString();
                txtStock.Text = selectedItem["existencias_insumo"].ToString();
                txtMedida.Text = selectedItem["unit_medida"].ToString();
            }
            else
            {
                // Si no hay selección, limpio el TextBox
                //cmbIdInsumo.SelectedIndex = -1;
                txtInsumo.Text = "";
                txtMedida.Text = "";
                txtStock.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                cmbEstado.SelectedIndex = -1;
                cmbMetPago.SelectedIndex = -1;
            }
        }

        private void cmbIdInsumo_TextChanged(object sender, EventArgs e)
        {
            // Si el ComboBox se limpia manualmente, también limpiar txtDescripcion
            if (string.IsNullOrEmpty(cmbIdInsumo.Text))
            {
                txtInsumo.Text = "";
                txtMedida.Text = "";
                txtStock.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                cmbEstado.SelectedIndex = -1;
                cmbMetPago.SelectedIndex = -1;
            }
        }

        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdCliente.SelectedIndex != -1)
            {
                // Obtener el elemento seleccionado
                DataRowView selectedItem = (DataRowView)cmbIdCliente.SelectedItem;

                // Mostrar el nom_tipo_insumo en el TextBox
                txtCliente.Text = selectedItem["nombre"].ToString();
            }
            else
            {
                // Si no hay selección, limpio el TextBox
                //cmbIdCliente.SelectedIndex = -1;
                txtCliente.Text = "";
            }
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
