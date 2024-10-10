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
        public VtnCompra()
        {
            InitializeComponent();
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
    }
}
