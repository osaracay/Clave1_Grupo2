using Clave1_Grupo2.dao;
using Clave1_Grupo2.entity;
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
    public partial class VtnCompra : Form
    {
        private List<Compra> cInsumos;
        private Compra cInsumo;
        private ConsultaCompra mConsultaCompra;
        public VtnCompra()
        {
            InitializeComponent();
            Rellenador.CargarDataTableACombo(cmbIdInsumo, CatDAO.GetInsumos(), "nom_insumo", "id_insumo");
            txtExistencia.TextChanged += (s, e) => calcularStockFinal();
            txtCantidad.TextChanged += (s, e) => calcularStockFinal();

            cInsumos = new List<Compra>();
            mConsultaCompra = new ConsultaCompra();
            cInsumo = new Compra();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            cmbIdInsumo.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtProveedor.Text = "";
            txtPrecio.Text = "";
            txtExistencia.Text ="";
            txtCantidad.Text = "";
            txtMedida.Text = "";
            txtStockFinal.Text = "";
        }

        private void brnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            cargarDatosProductos();
            if (mConsultaCompra.agregarCompra(cInsumo))
            {
                MessageBox.Show("Datos Guardado con exito.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }

        }
        private void cargarDatosProductos()
        {
            cInsumo.fecha = dateTimePicker1.Text;
            cInsumo.nombre = txtProveedor.Text;
            cInsumo.id_insumo = int.Parse(cmbIdInsumo.Text.Trim());
            cInsumo.nom_insumo = txtDescripcion.Text;
            cInsumo.precio = Convert.ToDecimal(txtPrecio.Text);
            cInsumo.cantidad = int.Parse(txtCantidad.Text);
            cInsumo.stock_final = int.Parse(txtStockFinal.Text);
            cInsumo.condicion = cmbCondicion.Text;
            cInsumo.tipo = "Entrada";
        }
        private bool validarCampos()
        {
            if (txtDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debe Seleccionar un Insumo.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPrecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingresar un nuevo Precio.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingresar una Cantidad de nuevo Ingreso.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbCondicion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione una Condicion.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!float.TryParse(txtPrecio.Text.Trim(), out float precio))
            {
                MessageBox.Show("Valor de Precio Invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return false;
            }
            if (!float.TryParse(txtCantidad.Text.Trim(), out float cant))
            {
                MessageBox.Show("Valor de Cantidad Invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
                return false;
            }
            return true;
        }
        private void cmbIdInsumo_TextChanged(object sender, EventArgs e)
        {
            // Si el ComboBox se limpia manualmente, también limpiar txtDescripcion
            if (string.IsNullOrEmpty(cmbIdInsumo.Text))
            {
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtMedida.Clear();
                txtExistencia.Clear();
                txtProveedor.Clear();
                txtStockFinal.Clear();
                txtCantidad.Clear();
                cmbCondicion.SelectedIndex = -1;
            }
        }

        private void cmbIdInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdInsumo.SelectedIndex != -1)
            {
                // Obtener el elemento seleccionado
                DataRowView selectedItem = (DataRowView)cmbIdInsumo.SelectedItem;

                // Mostrar el nom_tipo_insumo en el TextBox
                txtDescripcion.Text = selectedItem["nom_insumo"].ToString();
                txtPrecio.Text = selectedItem["precio_unit"].ToString();
                txtMedida.Text = selectedItem["unit_medida"].ToString();
                txtExistencia.Text = selectedItem["existencias_insumo"].ToString();
            }
            else
            {
                // Si no hay selección, limpio el TextBox
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtMedida.Clear();
                txtExistencia.Clear();
                txtProveedor.Clear();
                txtStockFinal.Clear();
                txtCantidad.Clear();
                cmbCondicion.SelectedIndex = -1;
            }
        }
        private void calcularStockFinal()
        {
            // Validar si los campos no están vacíos y convertir a decimales
            if (decimal.TryParse(txtExistencia.Text, out decimal existencias) && decimal.TryParse(txtCantidad.Text, out decimal cantidad))
            {
                // Calcular la sumatoria
                decimal stockFinal = existencias + cantidad;

                // Mostrar el valor formateado a miles en txtStockFinal
                txtStockFinal.Text = stockFinal.ToString("N0");
            }
            else
            {
                // Si los campos no son válidos, limpiar el campo de stock final
                txtStockFinal.Clear();
            }
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
    }
}
