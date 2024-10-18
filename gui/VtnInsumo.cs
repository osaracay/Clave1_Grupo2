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
            cargarInsumos();
            cargarMedidas();
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
            cargarInsumos(txtBuscarProd.Text.Trim());
        }
        private void brnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            cargarDatosInsumos();
            if (mConsultaInsumo.agregarInsumo(mInsumo))
            {
                MessageBox.Show("Insumo Guardado con exito.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarInsumos();
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
        private void cargarDatosInsumos()
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
            dgvRegistros.Columns.Clear();
            dgvRegistros.Columns.Add("Id", "Id");
            dgvRegistros.Columns.Add("nombre", "Nombre de Insumo");
            dgvRegistros.Columns.Add("tipo", "TP");
            dgvRegistros.Columns.Add("precio", "Precio");
            dgvRegistros.Columns.Add("medida", "U-Medida");
            dgvRegistros.Columns.Add("cantidad", "Existencia");
            dgvRegistros.Columns.Add("stockm", "ROP");

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
        private void dgvLstRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvRegistros.Rows[e.RowIndex];

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
                cargarDatosInsumos();

                // Intentar actualizar el producto
                if (mConsultaInsumo.ActualizarInsumo(mInsumo))
                {
                    MessageBox.Show("Datos modificados con éxito.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarInsumos();  // Recargar la lista de productos
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
                    if (mConsultaInsumo.eliminarInsumo(idProducto))
                    {
                        MessageBox.Show($"El Producto: '{nombreProducto}' ha sido Eliminado con Exito.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarInsumos(); // Actualizar la lista en el DataGridView
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
            cargarInsumos(); // Actualizar la lista en el DataGridView
            LimpiarCampos(); // Limpiar los campos
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            LimpiarCampos();
            cargarInsumos();
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

        private void btnTpInsumo_Click(object sender, EventArgs e)
        {
            //DEBES SER USUARIO VET o ADMINISTRADOR PARA ACCEDER
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirTipoInsumo();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }
        }

    }
}