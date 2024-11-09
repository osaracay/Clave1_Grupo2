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
            txtEmail.Enabled = false;
            txtRaza.Enabled = false;
            txtEdad.Enabled = false;
            txtGenero.Enabled = false;
            txtEspecie.Enabled = false;
            txtColorMascota.Enabled = false;
            nomMascota.Enabled = false;
        }

        private void CargarDatos()
        {
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));
            txtEmail.Text = ((Usuario)cbxPropietario.SelectedItem).Email;

            if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;

                // Asegúrate de que este método se llame para cargar un ComboBox
                Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner(UsuarioDAO.GetSesion()));
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
            cbxFinZootecnico.Text = "Elija una opcion";
            cbxEsterilizado.Text = "Elija una opcion";
            nomMascota.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtEspecie.Clear();
            txtColorMascota.Clear();
            txtDietaALim.Clear();
            txtEnfermedadesPrev.Clear();
            txtNumeroPartos.Clear();
            txtCirugiasPrev.Clear();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, completa todos los campos requeridos.");
                return; // Si no son válidos, salir del método
            }

            string finZootecnico = cbxFinZootecnico.Text;
            string dietaAlimentaria = dietaAlimenticia.Text;
            string enfermedadesPrevias = txtEnfermedadesPrev.Text;
            string esterilizado = cbxEsterilizado.Text;
            string numeroPartos = txtNumeroPartos.Text;
            string cirugiasPrevias = txtCirugiasPrev.Text;

            // Crear el contenido a guardar
            string contenido = $"Fin Zootecnico: {finZootecnico}\n" +
                               $"Dieta Alimentaria: {dietaAlimentaria}\n" +
                               $"Enfermedades Previas: {enfermedadesPrevias}\n" +
                               $"Esterilizado: {esterilizado}\n" +
                               $"Número de Partos: {numeroPartos}\n" +
                               $"Cirugías Previas: {cirugiasPrevias}\n";
            try
            {
                // Actualizar datos de la mascota
                MascotaDAO.ActualizarDatosMascota(mascotaSeleccionada, nomMascota.Text, (int)cbxPropietario.SelectedValue, txtRaza.Text, int.Parse(txtEdad.Text), char.Parse(txtGenero.Text.ToUpper()), txtColorMascota.Text);

                // Refrescar la lista de mascotas
                Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((int)cbxPropietario.SelectedValue));
                //InhabilitarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}");
            }LimpiarCampos();
            CargarDatos();
        }


        private bool ValidarCampos()
        {
            // Ejemplo de validaciones básicas
            if (string.IsNullOrWhiteSpace(txtRaza.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text) ||
                string.IsNullOrWhiteSpace(txtEspecie.Text) ||
                string.IsNullOrWhiteSpace(txtColorMascota.Text) ||
                string.IsNullOrWhiteSpace(cbxFinZootecnico.Text) ||
                string.IsNullOrWhiteSpace(dietaAlimenticia.Text) ||
                string.IsNullOrWhiteSpace(enfermedadesPrevias.Text) ||
                string.IsNullOrWhiteSpace(cbxEsterilizado.Text) ||
                string.IsNullOrWhiteSpace(txtCirugiasPrev.Text))
            {
                return false; // Un campo requerido está vacío
            }

            // Validar que la edad sea un número
            if (!int.TryParse(txtEdad.Text, out _) ||
                string.IsNullOrWhiteSpace(txtNumeroPartos.Text))
            {
                MessageBox.Show("Los partos deben ser un número.");
                return false;
            }
            return true; // Todos los campos son válidos
        }

        private void cbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((Usuario)cbxPropietario.SelectedItem));
        }

        private void txtNumeroPartos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
