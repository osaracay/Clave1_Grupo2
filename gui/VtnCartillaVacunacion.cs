﻿using Clave1_Grupo2.dao;
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
    public partial class VtnCartillaVacunacion : Form
    {
        private Mascota mascotaSeleccionada;
        private List<Cliente> clientes;
        private List<Veterinario> veterinarios;
        private List<Cupo> cuposDisponibles;

        private int duracionTipoCita;

        public VtnCartillaVacunacion()
        {
            InitializeComponent();
        }

        private void VtnCartillaVacunacion_Load(object sender, EventArgs e)
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
            nomMascota.Enabled = false;
            txtNombre.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void CargarDatos()
        {
            //Rellenador.CargarListaAComboBox(cbxMascota, CatDAO.GetEspecies());
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));
            Rellenador.CargarListaAComboBox(cbxVeterinario, UsuarioDAO.GetListaUsuarios(2));
            Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((Usuario)cbxPropietario.SelectedItem));
            Rellenador.CargarListaAComboBox(cbxTipoCita, CatDAO.GetTipoCitas());

            if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;

            }
            else
            {
                cbxPropietario.Enabled = true;
                LimpiarCampos();
            }
        }

       
        private void LimpiarCampos()
        {
            cbxMascota.Text = "Elija una mascota";
            nomMascota.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtEspecie.Clear();
            txtColorMascota.Clear();
        }

        private void cbxMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            mascotaSeleccionada = (Mascota)cbxMascota.SelectedItem;
            nomMascota.Text = mascotaSeleccionada.GetNomMascota();
            txtEspecie.Text = mascotaSeleccionada.GetEspecie().ToString();
            txtRaza.Text = mascotaSeleccionada.GetRaza();
            txtEdad.Text = mascotaSeleccionada.GetEdad().ToString();
            txtGenero.Text = mascotaSeleccionada.GetGeneroMascota().ToString();
            txtColorMascota.Text = mascotaSeleccionada.Color;
            InhabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea salir..?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }
        }
    
        private void cbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((Usuario)cbxPropietario.SelectedItem));
            txtEmail.Text = ((Usuario)cbxPropietario.SelectedItem).Email;
            txtNombre.Text = ((Usuario)cbxPropietario.SelectedItem).Username;

        }

        private void btnVacuna_Click(object sender, EventArgs e)
        {
            ListaVacunas vacunasList = new ListaVacunas();
            vacunasList.Show();
        }
    }
}
