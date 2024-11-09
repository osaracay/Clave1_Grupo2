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
    public partial class VtnCitas : Form
    {
        private List<Cita> listaCitas;
        public VtnCitas()
        {
            InitializeComponent();
        }

        private void btnExpedienteClinico_Click(object sender, EventArgs e)
        {
            ExpedienteClinico expediente = new ExpedienteClinico();
            expediente.Show();
        }

        private void btnCartillaVacunacion_Click(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.CartillaVacunacion();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }

        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion().TipoUsuario == 2)
            {
                if (lbxCitas.SelectedIndex > -1)
                {                    
                    GestorVentanas.AtenderCita();   
                }                
            }
        }

        private void SetPermisosEdicion()
        {
            btnAtender.Hide();
            lbxCitas.Enabled = true;
            cbxTipoCita.SelectedIndex = -1;
            cbxTipoCita.Enabled = false;
            cbxVeterinario.SelectedIndex = -1;
            cbxPropietario.SelectedIndex = -1;
            cbxMascota.SelectedIndex = -1;
            txtMotivo.Enabled = false;
            //lbxCitas.SelectedIndex = -1;
            if (UsuarioDAO.GetSesion().TipoUsuario == 2)
            {
                btnAtender.Show();
                cbxVeterinario.Enabled = false;
                cbxVeterinario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;                

                /* De todas formas */
                cbxPropietario.Enabled = true;                
            }
            else if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;
                cbxVeterinario.Enabled = false;
                cbxPropietario.Enabled = false;                
                Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((int)cbxPropietario.SelectedValue));
                /*
                cbxMascota.Enabled = true;
                cbxMascota.SelectedIndex = -1;
                */
            }
            else
            {
                //Siento que no tiene caso con admins
                /*
                cbxPropietario.Enabled = true;
                cbxMascota.Enabled = true;
                cbxVeterinario.Enabled = true;
                */
            }

            PopularCitas();
        }

        private void VtnCitas_Load(object sender, EventArgs e)
        {
            //Validar que no se cargen tantas veces estas listas
            this.campoFechaAgenda.MaxDate = DateTime.Today.AddMonths(3);
            this.campoFechaAgenda.MinDate = DateTime.Today.AddDays(-3);
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));
            Rellenador.CargarListaAComboBox(cbxVeterinario, UsuarioDAO.GetListaUsuarios(2));
            Rellenador.CargarListaAComboBox(cbxTipoCita, CatDAO.GetTipoCitas());
            //Valide que la lista tipo cita se crea una sola vez y luego se llama lo que se crea la primera vez que se llama
            SetPermisosEdicion();
            //lbxCitas.SelectedItem = -1; No hace nada. Porque no es SelectedIndex
            //lbxCitas.Refresh();
        }

        private void cbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioDAO.GetSesion().TipoUsuario != 3 && cbxPropietario.SelectedValue != null && cbxPropietario.SelectedIndex >= 0 && cbxPropietario.SelectedValue.GetType() != Type.GetType("System.Data.DataRowView"))
                {
                    Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((int)cbxPropietario.SelectedValue));
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
            SeleccionarCamposCita();
        }

        private void cbxVeterinario_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                if (cbxVeterinario.SelectedIndex >= 0 && cbxVeterinario.SelectedValue.GetType() != Type.GetType("System.Data.DataRowView"))
                {
                    //lbxCitas.Items.Clear();
                    lbxCitas.Refresh();
                    lbxCitas.DataSource = CitaDAO.GetCitas((Usuario)cbxVeterinario.SelectedItem);
                    lbxCitas.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepcion cbxVet : \n{ex.Message} \n{ex.StackTrace}");
                //ACA ME DA ERROR EL SELECTED VALUE TIPO ENTERO 
                //Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasPropietario((int)cbxPropietario.SelectedValue));
                //Rellenador.CargarDataTableAListBox(listaMascotas, MascotaDAO.GetMascotasPorPropietario((int)cbxPropietario.SelectedValue));
            }
            */
        }

        private void cbxMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                if (cbxMascota.SelectedIndex >= 0 && cbxMascota.SelectedValue.GetType() != Type.GetType("System.Data.DataRowView"))
                {
                    //lbxCitas.Items.Clear();
                    lbxCitas.Refresh();
                    lbxCitas.DataSource = CitaDAO.GetCitas((Mascota)cbxMascota.SelectedItem);
                    lbxCitas.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepcion cbxMascota: \n{ex.Message} \n{ex.StackTrace}");
                //ACA ME DA ERROR EL SELECTED VALUE TIPO ENTERO 
                //Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasPropietario((int)cbxPropietario.SelectedValue));
                //Rellenador.CargarDataTableAListBox(listaMascotas, MascotaDAO.GetMascotasPorPropietario((int)cbxPropietario.SelectedValue));
            }
            */
        }

        private void lbxCitas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                lbxCitas.SelectedIndex = -1;
                Rellenador.Cita = null;
            }
        }

        private void PopularCitas()
        {
            lbxCitas.Items.Clear();

            listaCitas = CitaDAO.GetCitas(UsuarioDAO.GetSesion(), campoFechaAgenda.Value.Date);
            foreach(Cita c in listaCitas)
            {
                lbxCitas.Items.Add(c);
            }
            lbxCitas.Refresh();
            lbxCitas.Enabled = true;
            lbxCitas.SelectedIndex = -1; //No hace nada con selectedItem
            SeleccionarCamposCita();
        }
        private void SeleccionarCamposCita()
        {
            Rellenador.Cita = null; //Para evitar que quede guardado y distorsione agendar y reagendar citas
            cbxMascota.Enabled = false;
            cbxMascota.SelectedIndex = -1;
            cbxTipoCita.SelectedIndex = -1;
            txtMotivo.Clear();
            btnReagendar.Hide();
            btnCancelarCita.Hide();
            if (lbxCitas.SelectedIndex > -1)
            {
                btnReagendar.Show();
                btnCancelarCita.Show();
                Rellenador.Cita = null;
                Rellenador.Cita = (Cita)lbxCitas.SelectedItem;
                cbxPropietario.SelectedValue = ((Cita)lbxCitas.SelectedItem).IdPropietario;
                cbxMascota.SelectedValue = ((Cita)lbxCitas.SelectedItem).IdMascota;
                cbxTipoCita.SelectedValue = ((Cita)lbxCitas.SelectedItem).IdTipoCita;
                cbxVeterinario.SelectedValue = ((Cita)lbxCitas.SelectedItem).Cupo.IdVetAsignado; // NOTESE QUE EL VET ASIGNADO EN RESERVACION DEBE SER EL MISMO EN TABLA CITA
                txtMotivo.Text = ((Cita)lbxCitas.SelectedItem).MotivoCita;
                //Puedo ocupar tambien Rellenador.Cita.MotivoCita;

                cbxMascota.Enabled = false;
            }
            else if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxVeterinario.SelectedIndex = -1;
            }
            else if (UsuarioDAO.GetSesion().TipoUsuario == 2)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedIndex = -1;
            }
            else
            {
                //Si fuese admin
            }
        }
        private void campoFechaAgenda_ValueChanged(object sender, EventArgs e)
        {
            PopularCitas();            
        }

        private void VtnCitas_Activated(object sender, EventArgs e)
        {
            //PopularCitas();
        }

        private void VtnCitas_Enter(object sender, EventArgs e)
        {
            //PopularCitas();
        }

        private void btnReagendar_Click(object sender, EventArgs e)
        {
            if (lbxCitas.SelectedIndex > -1)
            {
                //lbxCitas.Enabled = false;
                Rellenador.Cita = (Cita)lbxCitas.SelectedItem;
                //lbxCitas.Enabled = false; // De esta manera yo evito que se actualice Rellenar.Cita y me distorsione las reagendas y modificaciones
                //Reagendar requiere: popular los cupos disponibles por fecha y veterinario
                //Creo que deberia abrir la ventana agendar citas y si hay un idCupo en Rellenador Cita
                GestorVentanas.AbrirAgendarCita();
                btnCancelarCita.Hide();
                //PopularCitas();
                //Que inhabilite los campos y solo permita seleccionar otro cupo
                //Al momento de agendar lo unico que hara es actualizar el cupo ya existente
            }
        }


        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                $"¿Esta segur@ de cancelar la cita {Rellenador.Cita.Cupo}?\nEsta acción no se puede deshacer.",
                "Cancelar cita",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                CupoDAO.CancelarReservacionCita(Rellenador.Cita.Cupo.IdReservacion); //(Cita)lbxCitas.SelectedItem.IdCupo
                CitaDAO.ActualizarEstadoCita(Rellenador.Cita, 3);
                //VERIFICAR EL ID DEL ESTADO COMPLETADO O HACER LOS INSERTS DE CATEGORIAS CON EL ID AL IMPORTAR LA BD
                // 3 CANCELADA
                PopularCitas();
            }
            
        }
    }
}
