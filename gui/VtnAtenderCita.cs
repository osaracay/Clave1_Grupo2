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
    public partial class VtnAtenderCita : Form
    {

        public VtnAtenderCita()
        {
            InitializeComponent();
            cbxTipoCita.Enabled = false;
            cbxMascota.Enabled = false;
            cbxEstadoCita.Enabled = false;

        }

        private void VtnAtenderCita_Load(object sender, EventArgs e)
        {
            Rellenador.CargarListaAComboBox(cbxTipoCita, CatDAO.GetTipoCitas());
            Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner(Rellenador.Cita.IdPropietario));
            Rellenador.CargarListaAComboBox(cbxEstadoCita, CatDAO.GetEstadosCita());
            cbxTipoCita.SelectedValue = Rellenador.Cita.IdTipoCita;
            cbxMascota.SelectedValue = Rellenador.Cita.IdMascota;
            txtMotivo.Text = Rellenador.Cita.MotivoCita;
            CargarDatos();
            /*
            Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner(cita.IdPropietario));
            cbxTipoCita.SelectedValue = cita.IdTipoCita;
            cbxMascota.SelectedValue = cita.IdMascota;
            */
        }
        /// <summary>
        /// Cargar datos preguardados de la cita
        /// </summary>
        private void CargarDatos()
        {
            CitaDAO.CargarDetallesAtencionCita(Rellenador.Cita);
            lblNombreVet.Text = $"Dr. {UsuarioDAO.GetSesion().Apellido}, {UsuarioDAO.GetSesion().Nombre}";
            txtSintomas.Text = Rellenador.Cita.SintomasMascota;
            txtDiagnostico.Text = Rellenador.Cita.Diagnostico;
            txtTratamiento.Text = Rellenador.Cita.Tratamiento;
            txtObservaciones.Text = Rellenador.Cita.Observaciones;
            cbxEstadoCita.SelectedValue = Rellenador.Cita.IdEstadoCita;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMotivo.Text)) Rellenador.Cita.MotivoCita = "";
            else Rellenador.Cita.MotivoCita = txtMotivo.Text;

            if (String.IsNullOrEmpty(txtSintomas.Text)) Rellenador.Cita.SintomasMascota = "";
            else Rellenador.Cita.SintomasMascota = txtSintomas.Text;
            
            if (String.IsNullOrEmpty(txtDiagnostico.Text)) Rellenador.Cita.Diagnostico = "";
            else Rellenador.Cita.Diagnostico = txtDiagnostico.Text;

            if (String.IsNullOrEmpty(txtTratamiento.Text)) Rellenador.Cita.Tratamiento = "";
            else Rellenador.Cita.Tratamiento = txtTratamiento.Text;

            if (String.IsNullOrEmpty(txtObservaciones.Text)) Rellenador.Cita.Observaciones = "";
            else Rellenador.Cita.Observaciones = txtObservaciones.Text;

            CitaDAO.ActualizarAtencionCita(Rellenador.Cita);
        }

        private void btnCompletarCita_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            $"¿Esta segur@ de completar la cita {Rellenador.Cita.Cupo}?\nEsta acción no se puede deshacer.",
            "COMPLETAR CITA",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                CitaDAO.ActualizarEstadoCita(Rellenador.Cita,4);
                //VERIFICAR EL ID DEL ESTADO COMPLETADO O HACER LOS INSERTS DE CATEGORIAS CON EL ID AL IMPORTAR LA BD
                // 4 COMPLETADA
                this.Close();
                
            }
        }
    }
}
