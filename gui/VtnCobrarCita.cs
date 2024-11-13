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
    public partial class VtnCobrarCita : Form
    {

        private List<Cita> listaCitas;
        public VtnCobrarCita()
        {
            InitializeComponent();
        }

        private void VtnCobrarCita_Load(object sender, EventArgs e)
        {
            Rellenador.CargarListaAComboBox(cmbMetPago, CatDAO.GetMetodosPago());
            Rellenador.CargarListaAComboBox(cmbEstado, CatDAO.GetEstadosPago());           
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));
            cbxPropietario.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbMetPago.SelectedIndex = -1;
            txtPagado.Enabled = false;
            lbxCitas.Items.Clear();
            listaCitas = new List<Cita>();
        }

        private void PopularCitas()
        {
            lbxCitas.Items.Clear();

            listaCitas = CitaDAO.GetCitasCompletadas((Usuario)cbxPropietario.SelectedItem);
            foreach (Cita c in listaCitas)
            {
                lbxCitas.Items.Add(c);
            }
            lbxCitas.Refresh();
            lbxCitas.Enabled = true;
            lbxCitas.SelectedIndex = -1; //No hace nada con selectedItem
            //SeleccionarCamposCita();
        }

        private void cbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LimpiarCampos();
            SeleccionarCamposCita();
            try
            {
                if (UsuarioDAO.GetSesion().TipoUsuario != 3 && cbxPropietario.SelectedValue != null && cbxPropietario.SelectedIndex >= 0 && cbxPropietario.SelectedValue.GetType() != Type.GetType("System.Data.DataRowView"))
                {
                    PopularCitas();
                }
            }
            catch (Exception)
            {
                //ACA ME DA ERROR EL SELECTED VALUE TIPO ENTERO 
                //Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasPropietario((int)cbxPropietario.SelectedValue));
                //Rellenador.CargarDataTableAListBox(listaMascotas, MascotaDAO.GetMascotasPorPropietario((int)cbxPropietario.SelectedValue));
            }
        }

        private void lbxCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CargarCampos
            SeleccionarCamposCita();
        }
        /// <summary>
        /// Rellena los campos de la cita seleccionada en el listbox
        /// </summary>
        private void SeleccionarCamposCita()
        {
            Rellenador.Cita = null; //Para evitar que quede guardado y distorsione agendar y reagendar citas
            cmbEstado.Enabled = false;
            cmbEstado.SelectedIndex = -1;
            cmbMetPago.SelectedIndex = -1;
            //txtAbono.Enabled = true;
            txtPagado.Clear();
            txtAbono.Clear();
            txtTotal.Clear();
            if (lbxCitas.SelectedIndex > -1)
            {
                Rellenador.Cita = (Cita)lbxCitas.SelectedItem;
                //cbxPropietario.SelectedValue = ((Cita)lbxCitas.SelectedItem).IdPropietario; 
                //No aplica porque las citas completadas se populan segun el propietario seleccionado. Ademas me da excepcion si pongo esta instruccion
                cmbEstado.SelectedValue = ((Cita)lbxCitas.SelectedItem).IdEstadoPago;
                txtPagado.Text = $"${((Cita)lbxCitas.SelectedItem).Pagado}";
                txtTotal.Text = $"${((Cita)lbxCitas.SelectedItem).PrecioCita}";
                //Puedo ocupar tambien Rellenador.Cita.MotivoCita;
                if ((int)cmbEstado.SelectedValue == 3)
                {
                    //Si la cita ya esta pagada que no permita el cobro
                    txtAbono.Enabled = false;
                    btnCobrar.Enabled = false;
                }
                else
                {
                    txtAbono.Enabled = true;
                    btnCobrar.Enabled = true;
                }
            }
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            Validacion.CampoDouble(txtAbono, lblValido);
            if (Validacion.CampoLleno(txtAbono)){
                if (lbxCitas.SelectedIndex > -1 && ((Cita)lbxCitas.SelectedItem).PrecioCita >= (((Cita)lbxCitas.SelectedItem).Pagado + double.Parse(txtAbono.Text)))
                {
                    btnCobrar.Enabled = true;
                }
                else
                {
                    btnCobrar.Enabled = false;
                    MessageBox.Show($"La suma del monto por abonar y el abonado no puede ser mayor al total por pagar\n" +
                        $"Debe devolver ${(((Cita)lbxCitas.SelectedItem).Pagado + double.Parse(txtAbono.Text)) - (((Cita)lbxCitas.SelectedItem).PrecioCita)}"); //AQUI ME DA EXCEPTION
                }
            }
            
        }

        /// <summary>
        /// validar Cita seleccionada, monto abono mayor a 0, y met pago seleccionado
        /// </summary>
        /// <returns>True si los campos son validos</returns>
        private bool ValidarCampos()
        {
            if (lbxCitas.SelectedIndex>-1 && cmbMetPago.SelectedIndex >-1 && Validacion.CampoLleno(txtAbono) && double.Parse(txtAbono.Text) > 0) return true;
            else return false;
        }
        /// <summary>
        /// Establece el estado del pago de acuerdo con el total a pagar, el monto ya pagado, y el monto por abonar
        /// </summary>
        /// <returns>Id Estado de pago</returns>
        private int SetEstadoPago()
        {
            //1 pendiente (default), 2 parcial, 3 pagado, 4 sobrepagado
            if (((Cita)lbxCitas.SelectedItem).PrecioCita > (((Cita)lbxCitas.SelectedItem).Pagado + double.Parse(txtAbono.Text))) return 2;
            else if (((Cita)lbxCitas.SelectedItem).PrecioCita == (((Cita)lbxCitas.SelectedItem).Pagado + double.Parse(txtAbono.Text))) return 3;
            else if (((Cita)lbxCitas.SelectedItem).PrecioCita < (((Cita)lbxCitas.SelectedItem).Pagado + double.Parse(txtAbono.Text))) return 4;
            else return 1;
        }
        private void btnCobrar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                CitaDAO.PagarCita((Cita)lbxCitas.SelectedItem, (((Cita)lbxCitas.SelectedItem).Pagado + double.Parse(txtAbono.Text)),
                (CatItem)cmbMetPago.SelectedItem, SetEstadoPago());
                PopularCitas();
                SeleccionarCamposCita();
            }
            else MessageBox.Show("Selecciona la cita, el metodo de pago y el monto por abonar");
        }
    }
}