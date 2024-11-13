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
            txtVacunaSeleccionada.Clear();
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
            LimpiarCampos();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, completa todos los campos requeridos.");
                return; // Si no son válidos, salir del método
            }

            string vacunaSeleccionada = txtVacunaSeleccionada.Text;
            string tipoCita = cbxTipoCita.Text;
            string veterinario = cbxVeterinario.Text;

            // Crear el contenido a guardar
            string contenido = $"Vacuna Seleccionada: {vacunaSeleccionada}\n" +
                               $"Tipo de Cita: {tipoCita}\n" +
                               $"Veterinario: {veterinario}\n";

            // Simulación de guardado (reemplaza esto con la lógica real de guardado)
            // Aquí iría el código para guardar los datos en una base de datos, archivo, etc.
            // Por ahora, simplemente mostraremos un mensaje de confirmación

            MessageBox.Show("Datos guardados correctamente.");

            LimpiarCampos();
            // Limpiar los campos
            //txtVacunaSeleccionada.Text = "";
            //cbxTipoCita.SelectedIndex = -1;
            //cbxVeterinario.SelectedIndex = -1;


        }



        private bool ValidarCampos()
        {
            // Ejemplo de validaciones básicas
            if (cbxMascota.SelectedIndex <= 0 ||
                string.IsNullOrWhiteSpace(txtRaza.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text) ||
                string.IsNullOrWhiteSpace(txtEspecie.Text) ||
                string.IsNullOrWhiteSpace(txtColorMascota.Text) ||
                string.IsNullOrWhiteSpace(nomMascota.Text) ||
                string.IsNullOrWhiteSpace(txtVacunaSeleccionada.Text) ||
                string.IsNullOrWhiteSpace(cbxTipoCita.Text) ||
                string.IsNullOrWhiteSpace(cbxVeterinario.Text))
            {
                return false; // Un campo requerido está vacío
            }

            return true; // Todos los campos están completos
        }
    }
}
