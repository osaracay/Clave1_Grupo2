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
            txtEmail.Text = UsuarioDAO.GetSesion().Email;
            txtNombre.Text = UsuarioDAO.GetSesion().Username;
            Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner(UsuarioDAO.GetSesion()));

            if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;

            }
            else
            {
                cbxPropietario.Enabled = true;
            }
        }

        private void LimpiarCampos()
        {
            txtRaza.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtEspecie.Clear();
            txtColorMascota.Clear();
            txtPeso.Clear();
            txtPulso.Clear();
            txtVacuna.Clear();
            lbxCupos.Items.Clear();
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
                //LimpiarCampos();
            }
        }
    
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            CatItem tipoCita = (CatItem)cbxTipoCita.SelectedItem;
            Cupo cupoApartado = new Cupo(campoFechaAgenda.Value,
                new DateTime(campoFechaAgenda.Value.Year, campoFechaAgenda.Value.Month, campoFechaAgenda.Value.Day,
                campoFechaAgenda.Value.Hour, 0, 0),
                90);
            MessageBox.Show($"la fecha seleccionada es : {cupoApartado.FechaCupo}\n" +
                $"la hora de inicio es : {cupoApartado.HoraInicio}\n" +
                $"la hora de finalizacion es : {cupoApartado.HoraFin}\n" +
                $"la duracion es : {cupoApartado.DuracionMinutos}");
            Cupo cupoSiguiente = new Cupo(campoFechaAgenda.Value,
                new DateTime(campoFechaAgenda.Value.Year, campoFechaAgenda.Value.Month, campoFechaAgenda.Value.Day,
                cupoApartado.HoraFin.Hour, cupoApartado.HoraFin.Minute, 0),
                tipoCita.DuracionMinutosCat);
            MessageBox.Show($"2 - la fecha seleccionada es : {cupoSiguiente.FechaCupo}\n" +
                $"la hora de inicio es : {cupoSiguiente.HoraInicio}\n" +
                $"la hora de finalizacion es : {cupoSiguiente.HoraFin}\n" +
                $"la duracion es : {cupoSiguiente.DuracionMinutos}");
            //CupoDAO.GetCuposDisponibles(cupoApartado.FechaCupo, tipoCita.DuracionMinutosCat);
        }

        private void campoFechaAgenda_ValueChanged(object sender, EventArgs e)
        {
            PopularCuposDisponibles();
        }

        private void PopularCuposDisponibles()
        {
            //lbxCupos.DataSource = null;
            //campoFechaAgenda.Value = new DateTime(campoFechaAgenda.Value.Year, campoFechaAgenda.Value.Month, campoFechaAgenda.Value.Day);
            lbxCupos.Items.Clear();


            foreach (Cupo c in CupoDAO.GetCuposDisponibles(campoFechaAgenda.Value,
                (CatItem)cbxTipoCita.SelectedItem))
            {

                if (c.FechaCupo == new DateTime(campoFechaAgenda.Value.Year, campoFechaAgenda.Value.Month, campoFechaAgenda.Value.Day))
                {
                    lbxCupos.Items.Add(c);
                }
            }
            /*
            lbxCupos.DataSource = CupoDAO.GetCuposDisponibles(campoFechaAgenda.Value,
                (CatItem)cbxTipoCita.SelectedItem);
            */
            lbxCupos.Refresh();
            lbxCupos.Enabled = true;
        }

        private void VtnAgendarCita_Load(object sender, EventArgs e)
        {
            //POr si acaso le mueven en Initialize component o se restaura
            //Cuando le agarre feo a vs, aqui lo setteo manualmente
            //Asi no hay necesidad de una propiedad en Cupo que la establezca
            //Y que tenga que averiguar como aplicarla a restricciones de cupo
            this.campoFechaAgenda.MaxDate = DateTime.Today.AddMonths(3);
            this.campoFechaAgenda.MinDate = DateTime.Today;
            //Aunque este en _Load, prevalece sobre lo que esta en Initialize
        }

        private void cbxTipoCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)((CatItem)cbxTipoCita.SelectedItem).DuracionMinutosCat != duracionTipoCita)
            {
                duracionTipoCita = (int)((CatItem)cbxTipoCita.SelectedItem).DuracionMinutosCat;
                //lbxCupos.Enabled = false;

                try
                {
                    if (cbxTipoCita.SelectedValue != null && cbxTipoCita.SelectedIndex >= 0 && cbxTipoCita.SelectedValue.GetType() != Type.GetType("System.Data.DataRowView"))
                    {
                        //MessageBox.Show($"El texto seleccionado es {cbxPropietario.Text} - el valor o id Usuario {cbxPropietario.SelectedValue} y el index en el que se encuentra {cbxPropietario.SelectedIndex}");
                        PopularCuposDisponibles();
                        //GetListaMascotasOwner realiza consulta a la BD cada que se llama
                        //MI IDEA es que se cree una lista para el usuario si es nula y luego solo se llame la ya creada como con las ventanas
                        //Dicha lista se asiganra valor nulo al registrar una nueva mascota para que solo entonces se vuelva a ejecutar la consulta
                    }
                }
                catch (Exception)
                {
                    //ACA ME DA ERROR EL SELECTED VALUE TIPO ENTERO 
                    //Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasPropietario((int)cbxPropietario.SelectedValue));
                    //Rellenador.CargarDataTableAListBox(listaMascotas, MascotaDAO.GetMascotasPorPropietario((int)cbxPropietario.SelectedValue));
                }
                /**/
            }
        }

        private void cbxTipoCita_SelectedValueChanged(object sender, EventArgs e)
        {
            //PopularCuposDisponibles();
        }
    }
}
