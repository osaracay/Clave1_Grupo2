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
    public partial class VtnMascotas : Form
    {

        private Mascota mascotaSeleccionada;
        public VtnMascotas()
        {
            InitializeComponent();                    
        }
        
        private void listaMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            mascotaSeleccionada = (Mascota)listaMascotas.SelectedItem;
            txtNombres.Text = mascotaSeleccionada.GetNomMascota();
            cbxEspecie.SelectedValue = mascotaSeleccionada.GetEspecie();
            txtRaza.Text = mascotaSeleccionada.GetRaza();
            txtEdad.Text = mascotaSeleccionada.GetEdad().ToString();
            txtGenero.Text = mascotaSeleccionada.GetGeneroMascota().ToString();

        }

        private void VtnMascotas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            Rellenador.CargarDataTableACombo(cbxEspecie, CatDAO.GetEspecie(), "id_especie", "nom_especie");
            Rellenador.CargarDataTableACombo(cbxPropietario, UsuarioDAO.GetTblClientes(), "id_usuario", "nombre");
            if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;
                Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasOwner(UsuarioDAO.GetSesion()));
                //Rellenador.CargarListaPetAComboBox(cbxMascotas, MascotaDAO.GetListaMascotasOwner(UsuarioDAO.GetSesion()));

            }
            else
            {
                cbxPropietario.Enabled = true;
                cbxPropietario.SelectedIndex = -1;
            }
        }

        private void cbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rellenador.CargarDataTableAListBox(listaMascotas, MascotaDAO.GetMascotasPorPropietario((int)cbxPropietario.SelectedValue));
        }

        private void cbxPropietario_SelectedValueChanged(object sender, EventArgs e)
        {
            //ACA ME DA ERROR EL SELECTED VALUE TIPO ENTERO 
            //Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasPropietario((int)cbxPropietario.SelectedValue));
        }
    }
}
