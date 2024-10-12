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
    public partial class VtnInsumo : Form
    {
        private List<Insumo> mInsumos;
        private Insumo mInsumo;
        private ConsultaInsumo mConsultaInsumo;
        public VtnInsumo()
        {
            InitializeComponent();
            Rellenador.CargarDataTableACombo(cmbTipoInsumo, CatDAO.GetTipoInsumo(), "nom_tipo_insumo", "id_tipo_insumo");

            mInsumos = new List<Insumo>();
            mConsultaInsumo = new ConsultaInsumo();
            mInsumo = new Insumo();
            txtDescripcion.Focus();
            ConfigurarDGV();
            cargarProductos();
            cargarMedidas();
        }
        private void cargarProductos(string filtro = "")
        {
            dgvLstProductos.Rows.Clear();
            dgvLstProductos.Refresh();
            mInsumos.Clear();
            mInsumos = mConsultaInsumo.getProductos(filtro);

            for (int i = 0; i < mInsumos.Count(); i++)
            {

                dgvLstProductos.Rows.Add(
                    mInsumos[i].id_insumo,
                    mInsumos[i].nom_insumo,
                    mInsumos[i].id_tipo_insumo,
                    mInsumos[i].precio_unit.ToString("N2"),
                    mInsumos[i].unit_medida,
                    mInsumos[i].existencias_insumo,
                    mInsumos[i].punto_reorden_insumo);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txtBuscarProd_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(txtBuscarProd.Text.Trim());
        }
        private void brnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            cargarDatosProductos();
            if (mConsultaInsumo.agregarProducto(mInsumo))
            {
                MessageBox.Show("Insumo Guardado con exito.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarProductos();
                LimpiarCampos();
            }
        }
        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtBuscarProd.Text = "";
            txtPuntoR.Text = "";
            txtDescripcion.Focus();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cmbMedida.SelectedIndex = -1;
            cmbTipoInsumo.SelectedIndex = -1;
        }
        private void cargarDatosProductos()
        {
            mInsumo.nom_insumo = txtDescripcion.Text;
            mInsumo.id_tipo_insumo = int.Parse(cmbTipoInsumo.Text.Trim());
            mInsumo.desc_insumo = txtDescripInsumo.Text;
            mInsumo.precio_unit = Convert.ToDecimal(txtPrecio.Text);
            mInsumo.unit_medida = cmbMedida.Text;
            mInsumo.existencias_insumo = int.Parse(txtCantidad.Text);
            mInsumo.punto_reorden_insumo = int.Parse(txtPuntoR.Text);
        }
        private bool validarCampos()
        {
            if (txtDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese un Nombre.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPrecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingresar un Precio.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingresar una Cantidad de Stock.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            dgvLstProductos.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular);
            dgvLstProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            dgvLstProductos.Columns["precio"].DefaultCellStyle.Format = "N2"; // N2 Aplicar formato con 2 decimales
            dgvLstProductos.Columns["cantidad"].DefaultCellStyle.Format = "N0";
            dgvLstProductos.Columns["stockm"].DefaultCellStyle.Format = "N0";

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
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
        private void dgvLstProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvLstProductos.Rows[e.RowIndex];

                // Pasar los datos a los TextBox
                txtCodigo.Text = row.Cells["Id"].Value.ToString();
                txtDescripcion.Text = row.Cells["nombre"].Value.ToString();
                cmbTipoInsumo.Text = row.Cells["tipo"].Value.ToString();
                //txtPrecio.Text = row.Cells["precio"].Value.ToString();
                txtPrecio.Text = Convert.ToDecimal(row.Cells["precio"].Value).ToString("N2");
                cmbMedida.Text = row.Cells["medida"].Value.ToString();
                txtCantidad.Text = row.Cells["cantidad"].Value.ToString();
                txtPuntoR.Text = row.Cells["stockm"].Value.ToString();

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validar los campos primero
            if (!validarCampos())
            {
                return;
            }

            // Mostrar un cuadro de diálogo para confirmar la modificación
            DialogResult confirmacion = MessageBox.Show(
                $"¿Esta segur@ de Modificar el Producto: '{txtDescripcion.Text}'?",
                "Datos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario selecciona "Sí", proceder con la modificación
            if (confirmacion == DialogResult.Yes)
            {
                // Cargar el ID del producto
                mInsumo.id_insumo = int.Parse(txtCodigo.Text);

                // Cargar otros datos del producto
                cargarDatosProductos();

                // Intentar actualizar el producto
                if (mConsultaInsumo.ActualizarProducto(mInsumo))
                {
                    MessageBox.Show("Datos modificados con éxito.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarProductos();  // Recargar la lista de productos
                    LimpiarCampos();    // Limpiar los campos del formulario
                }
                else
                {
                    MessageBox.Show("Error al modificar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el usuario cancela la modificación, limpiar los campos
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un producto seleccionado
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Favor de Seleccionar un Producto.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Confirmar la eliminación
            string nombreProducto = txtDescripcion.Text;
            DialogResult resultado = MessageBox.Show(
                $"¿Esta segur@ de Eliminar el Producto '{nombreProducto}'?\n\nEsta acción no se puede deshacer.",
                "Datos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int idProducto = int.Parse(txtCodigo.Text);

                    // Intentar eliminar de la base de datos
                    if (mConsultaInsumo.eliminarProducto(idProducto))
                    {
                        MessageBox.Show($"El Producto: '{nombreProducto}' ha sido Eliminado con Exito.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarProductos(); // Actualizar la lista en el DataGridView
                        LimpiarCampos(); // Limpiar los campos
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar la eliminación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            cargarProductos(); // Actualizar la lista en el DataGridView
            LimpiarCampos(); // Limpiar los campos
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            LimpiarCampos();
            cargarProductos();
        }

        private void Form_Productos_Load(object sender, EventArgs e)
        {
        }
        private void cargarMedidas()
        {
            // Limpiar el ComboBox antes de agregar las unidades.
            cmbMedida.Items.Clear();

            // Agregar las opciones de medida al ComboBox.
            cmbMedida.Items.Add("UND");
            cmbMedida.Items.Add("SACO");
            cmbMedida.Items.Add("LIBRA");

            // Ninguna opción seleccionada por defecto.
            cmbMedida.SelectedIndex = -1;
        }
        private void cmbTipoInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoInsumo.SelectedIndex != -1)
            {
                // Obtener el elemento seleccionado
                DataRowView selectedItem = (DataRowView)cmbTipoInsumo.SelectedItem;

                // Mostrar el nom_tipo_insumo en el TextBox
                txtDescripInsumo.Text = selectedItem["nom_tipo_insumo"].ToString();
            }
            else
            {
                // Si no hay selección, limpio el TextBox
                txtDescripInsumo.Clear();
            }
        }
        private void cmbTipoInsumo_TextChanged(object sender, EventArgs e)
        {
            // Si el ComboBox se limpia manualmente, también limpiar txtDescripcion
            if (string.IsNullOrEmpty(cmbTipoInsumo.Text))
            {
                txtDescripInsumo.Clear();
            }
        }
    }
}