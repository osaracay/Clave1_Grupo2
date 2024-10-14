﻿using Clave1_Grupo2.dao;
using Clave1_Grupo2.entity;
using Clave1_Grupo2.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Clave1_Grupo2.gui
{
    public partial class VtnVenta : Form
    {
        private List<Venta> vInsumos;
        private Venta vInsumo;
        private ConsultaVenta mConsultaVenta;
        public VtnVenta()
        {
            InitializeComponent();
            Rellenador.CargarDataTableACombo(cmbMetPago, CatDAO.GetMetPago(), "id_met_pago", "nom_met_pago");
            Rellenador.CargarDataTableACombo(cmbEstado, CatDAO.GetEstadoPago(), "id_estado_pago", "nom_estado_pago");
            Rellenador.CargarDataTableACombo(cmbIdCliente, CatDAO.GetUsuarios(), "nombre", "id_usuario");
            Rellenador.CargarDataTableACombo(cmbIdInsumo, CatDAO.GetInsumos(), "nom_insumo", "id_insumo");
            ConfigurarDGV();

            vInsumos = new List<Venta>();
            mConsultaVenta = new ConsultaVenta();
            vInsumo = new Venta();
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

            dgvRegistros.Rows.Clear();
            txtTotal.Text = "";
            btnEliminar.Enabled = false;
            cmbIdCliente.Focus();
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
                txtPrecio.Text = selectedItem["precio_unit"].ToString();
                txtMedida.Text = selectedItem["unit_medida"].ToString();
                txtStock.Text = selectedItem["existencias_insumo"].ToString();
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dgvRegistros.Rows.Count + 1;
                string id = cmbIdInsumo.Text;
                string nombre = txtInsumo.Text;
                string unidad = txtMedida.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                decimal subtotal = precio * cantidad;

                dgvRegistros.Rows.Add(n, id, nombre, unidad, precio, cantidad, subtotal);

                ActualizarTotales();
                cmbIdInsumo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar el Insumo: " + ex.Message);
            }
        }
        private void ActualizarTotales()
        {
            int items = dgvRegistros.Rows.Count;
            decimal Total = 0;

            // si la ultima fila es la fila nueva vacia, restamos 1 del conteo de otems
            if (dgvRegistros.AllowUserToAddRows && dgvRegistros.Rows[items - 1].IsNewRow)
            {
                items--;
            }
            foreach (DataGridViewRow row in dgvRegistros.Rows)
            {
                Total += Convert.ToDecimal(row.Cells["total"].Value);
            }
            //lblItems.Text = $"Items: {items}"; //Activar solo si deseamos ver el numero de items agregados
            txtTotal.Text = Total.ToString("N2");
        }
        private void ConfigurarDGV()
        {
            dgvRegistros.Columns.Clear();
            dgvRegistros.Columns.Add("N", "N°");
            dgvRegistros.Columns.Add("Id", "Id");
            dgvRegistros.Columns.Add("nombre", "Nombre de Insumo");
            dgvRegistros.Columns.Add("medida", "Und");
            dgvRegistros.Columns.Add("precio", "Precio");
            dgvRegistros.Columns.Add("cantidad", "Cant.");
            dgvRegistros.Columns.Add("total", "SubTotal");

            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.Columns["N"].Width = 30;
            dgvRegistros.Columns["Id"].Width = 70;
            dgvRegistros.Columns["nombre"].Width = 290;
            dgvRegistros.Columns["medida"].Width = 60;
            dgvRegistros.Columns["precio"].Width = 90;
            dgvRegistros.Columns["cantidad"].Width = 70;
            dgvRegistros.Columns["total"].Width = 120;

            dgvRegistros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRegistros.DefaultCellStyle.SelectionBackColor = Color.Aquamarine;
            dgvRegistros.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvRegistros.Cursor = Cursors.Hand;

            dgvRegistros.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRegistros.Columns["nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRegistros.Columns["medida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRegistros.Columns["precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRegistros.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRegistros.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvRegistros.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular);
            dgvRegistros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            dgvRegistros.Columns["precio"].DefaultCellStyle.Format = "N2"; // N2 Aplicar formato con 2 decimales
            dgvRegistros.Columns["cantidad"].DefaultCellStyle.Format = "N0";
            dgvRegistros.Columns["total"].DefaultCellStyle.Format = "N2";

            cmbIdCliente.Focus();
            btnEliminar.Enabled = false;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.SelectedRows.Count > 0)
            {
                int rowIndex = dgvRegistros.SelectedRows[0].Index;
                // Actualizar números de filas antes de eliminar
                ActualizarNumerosDeFilas();
                try
                {
                    // Eliminar la fila
                    dgvRegistros.Rows.RemoveAt(rowIndex);

                    // Actualizar los totales
                    ActualizarTotales();
                    MessageBox.Show("Items Eliminado con Exito.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción
                    MessageBox.Show("Ha ocurrido un Error al eliminar el items: " + ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Seleccionar un Items para Eliminar.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ActualizarNumerosDeFilas()
        {
            for (int i = 0; i < dgvRegistros.Rows.Count; i++)
            {
                dgvRegistros.Rows[i].Cells["N"].Value = i + 1;
            }
        }
        private void dgvRegistros_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            //cargarDatosProductos();
            //if (mConsultaVenta.agregarVenta(vInsumo))
            //{
            //    MessageBox.Show("Datos Guardado con exito.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    LimpiarCampos();
            //}

            // Fragmento guarda el Detalle de Ventas en otra Tabla
            Venta nuevaVenta = new Venta
            {
                fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                monto_total = Convert.ToDecimal(txtTotal.Text),
                id_met_pago = cmbMetPago.Text,
                estado_factura = cmbEstado.Text,
            };

            if (mConsultaVenta.agregarDetalleVenta(nuevaVenta, dgvRegistros))
            {
                MessageBox.Show("Venta Guardada con éxito.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarInventarioPorVenta();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al guardar la venta.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarInventarioPorVenta()
        {
            for (int i = 0; i < dgvRegistros.Rows.Count; i++)
            {
                int idInsumo = Convert.ToInt32(dgvRegistros.Rows[i].Cells["Id"].Value);
                int cantidadVendida = Convert.ToInt32(dgvRegistros.Rows[i].Cells["cantidad"].Value);

                if (!mConsultaVenta.ActualizarStockVenta(idInsumo, cantidadVendida))
                {
                    MessageBox.Show("Error al actualizar el inventario del insumo con ID: " + idInsumo, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Inventario Actualizado con éxito.", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //private void cargarDatosProductos()
        //{
        //    vInsumo.fecha = dateTimePicker1.Text;
        //    vInsumo.monto_total = Convert.ToDecimal(txtTotal.Text);
        //    vInsumo.id_met_pago = cmbMetPago.Text;
        //    vInsumo.estado_factura = cmbEstado.Text;
        //}
        private bool validarCampos()
        {
            if (cmbIdCliente.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debe Seleccionar un Cliente.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbMetPago.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione una Forma de Pago.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbEstado.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione una Condicion.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


    }
}