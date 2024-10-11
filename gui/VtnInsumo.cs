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
        private List<Producto> mProductos;
        private Producto mProducto;
        private Insumo mConsultaProductos;
        public VtnInsumo()
        {
            InitializeComponent();
            mProductos = new List<Producto>();
            mConsultaProductos = new Insumo();
            mProducto = new Producto();
            txtDescripcion.Focus();
            ConfigurarDGV();
            cargarProductos();
            cargarMedidas();
            Rellenador.CargarDataTableACombo(cmbTipoInsumo, CatDAO.GetTipoInsumo(), "nom_tipo_insumo", "id_tipo_insumo");
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
        private void cargarMedidas()
        {
            // Limpiar el ComboBox antes de agregar elementos.
            cmbMedida.Items.Clear();

            // Agregar las opciones de medida al ComboBox.
            cmbMedida.Items.Add("UND");
            cmbMedida.Items.Add("SACO");
            cmbMedida.Items.Add("LIBRA");

            // Si quieres que no haya ninguna opción seleccionada por defecto.
            cmbMedida.SelectedIndex = -1;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void brnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            cargarDatosProductos();
            if (mConsultaProductos.agregarProducto(mProducto))
            {
                MessageBox.Show("Insumo Guardado con exito.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarProductos();
                LimpiarCampos();
            }
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
        private void cargarDatosProductos()
        {
            try
            {
                // Asignar nombre insumo
                mProducto.nom_insumo = txtDescripcion.Text.Trim();

                // Asignar id_tipo_insumo asegurando que se extrae correctamente el ID
                string[] tipoInsumoParts = cmbTipoInsumo.Text.Split('-');
                if (tipoInsumoParts.Length > 0)
                {
                    mProducto.id_tipo_insumo = int.Parse(tipoInsumoParts[0].Trim()); // Convertir la primera parte
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de insumo válido.");
                    return; // Detener si el tipo de insumo no es válido
                }

                // Asignar el resto de los campos asegurando su conversión
                mProducto.desc_insumo = txtDescripInsumo.Text.Trim();
                mProducto.precio_unit = decimal.Parse(txtPrecio.Text.Trim());
                mProducto.unit_medida = cmbMedida.Text.Trim();
                mProducto.existencias_insumo = int.Parse(txtCantidad.Text.Trim());
                mProducto.punto_reorden_insumo = int.Parse(txtPuntoR.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en los datos ingresados: " + ex.Message);
            }
        }
        //private void cargarDatosProductos()
        //{
        //    mProducto.nom_insumo = txtDescripcion.Text.Trim();
        //    mProducto.id_tipo_insumo = int.Parse(cmbTipoInsumo.Text.Trim());
        //    mProducto.desc_insumo = txtDescripInsumo.Text.Trim();
        //    mProducto.precio_unit = decimal.Parse(txtPrecio.Text.Trim());
        //    mProducto.unit_medida = cmbMedida.Text.Trim();
        //    mProducto.existencias_insumo = int.Parse(txtCantidad.Text.Trim());
        //    mProducto.punto_reorden_insumo = int.Parse(txtPuntoR.Text.Trim());
        //}
        private void cargarProductos(string filtro = "")
        {
            try
            {
                // Limpiar el DataGridView
                dgvLstProductos.Rows.Clear();
                dgvLstProductos.Refresh();

                // Limpiar la lista de productos
                mProductos.Clear();

                // Llamar al método que obtiene los productos de la base de datos usando ODBC
                mProductos = mConsultaProductos.getProductos(filtro);

                // Cargar los productos en el DataGridView
                for (int i = 0; i < mProductos.Count(); i++)
                {
                    dgvLstProductos.Rows.Add(
                        mProductos[i].id_insumo,
                        mProductos[i].nom_insumo,
                        mProductos[i].id_tipo_insumo,
                        mProductos[i].precio_unit,
                        mProductos[i].unit_medida,
                        mProductos[i].existencias_insumo,
                        mProductos[i].punto_reorden_insumo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }
        //private void cargarProductos(string filtro = "")
        //{
        //    dgvLstProductos.Rows.Clear();
        //    dgvLstProductos.Refresh();
        //    mProductos.Clear();
        //    mProductos = mConsultaProductos.getProductos(filtro);

        //    for (int i = 0; i < mProductos.Count(); i++)
        //    {
        //        dgvLstProductos.Rows.Add(
        //            mProductos[i].id_insumo,
        //            mProductos[i].nom_insumo,
        //            mProductos[i].id_tipo_insumo,
        //            mProductos[i].precio_unit,
        //            mProductos[i].unit_medida,
        //            mProductos[i].existencias_insumo,
        //            mProductos[i].punto_reorden_insumo);
        //    }
        //}
        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            cmbTipoInsumo.SelectedIndex = -1;
            txtPrecio.Text = "";
            cmbMedida.SelectedIndex = -1;
            txtCantidad.Text = "";
            txtPuntoR.Text = "";
            txtBuscarProd.Text = "";
            txtDescripcion.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void cmbTipoInsumo_TextChanged(object sender, EventArgs e)
        {
            // Si el ComboBox se limpia manualmente, también limpiar txtDescripcion
            if (string.IsNullOrEmpty(cmbTipoInsumo.Text))
            {
                txtDescripInsumo.Clear();
            }
        }
        private void cmbTipoInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
