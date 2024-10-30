using Clave1_Grupo2.dao;
using Clave1_Grupo2.entity;
using Clave1_Grupo2.util;
using System;
using System.Windows.Forms;

namespace Clave1_Grupo2.gui
{
    public partial class ExpedienteClinico : Form
    {
        private Mascota mascotaSeleccionada;
        public ExpedienteClinico()
        {
            InitializeComponent();
        }

        private void ExpedienteClinico_Load(object sender, EventArgs e)
        {
            InhabilitarCampos();
            CargarDatos();
        }
        private void InhabilitarCampos()
        {
            txtRaza.Enabled = false;
            txtEdad.Enabled = false;
            txtGenero.Enabled = false;
            txtEspecie.Enabled = false;
            txtColorMascota.Enabled = false;
        }

        private void CargarDatos()
        {
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));
            txtEmail.Text = UsuarioDAO.GetSesion().Email;

            if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;

                // Asegúrate de que este método se llame para cargar un ComboBox
                //Rellenador.CargarListaAPetAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner(UsuarioDAO.GetSesion()));
            }
            else
            {
                cbxPropietario.Enabled = true;
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtRaza.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtEspecie.Clear();
            txtColorMascota.Clear();
        }

        private void cbxMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            mascotaSeleccionada = (Mascota)cbxMascota.SelectedItem;
            nomMascota.Text = mascotaSeleccionada.GetNomMascota().ToString();
            txtEspecie.Text = mascotaSeleccionada.GetEspecie().ToString();
            txtRaza.Text = mascotaSeleccionada.GetRaza();
            txtEdad.Text = mascotaSeleccionada.GetEdad().ToString();
            txtGenero.Text = mascotaSeleccionada.GetGeneroMascota().ToString();
            txtColorMascota.Text = mascotaSeleccionada.Color;
            InhabilitarCampos();
            //Intente limpiar cuando no hubiera items en la lista con selecteditem distinto de null
            //y lista items count mayor que 0 pero no se limpiaron los campos
        }
    }
}
