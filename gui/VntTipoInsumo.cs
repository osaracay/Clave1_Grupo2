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
    public partial class VntTipoInsumo : Form
    {
        //private List<Insumo> mInsumos;
        private Insumo mInsumo;
        private ConsultaInsumo mConsultaInsumo;
        public VntTipoInsumo()
        {
            InitializeComponent();

            //mInsumos = new List<Insumo>();
            mConsultaInsumo = new ConsultaInsumo();
            mInsumo = new Insumo();
            txtNombre.Focus();
        }

        private void brnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            cargarDatosInsumos();
            if (mConsultaInsumo.agregarTipoInsumo(mInsumo))
            {
                MessageBox.Show("Tipo de Insumo registrado.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
            }
        }
        private void cargarDatosInsumos()
        {
            mInsumo.nom_tipo_insumo = txtNombre.Text;
        }
        private bool validarCampos()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar un nombre.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }      
            return true;
        }


    }
}
