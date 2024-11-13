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
            //Rellenador.CargarDataTableACombo(cmbIdCliente, CatDAO.GetUsuarios(), "nombre", "id_usuario");
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));
            cbxPropietario.SelectedIndex = -1;
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
    }
}
