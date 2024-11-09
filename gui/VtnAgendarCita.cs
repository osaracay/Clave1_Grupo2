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
    public partial class VtnAgendarCita : Form
    {
        private List<Cliente> clientes;
        private List<Veterinario> veterinarios;
        private List<Cupo> cuposDisponibles;
        private static Cupo seleccionado;
        private int duracionTipoCita;
        public VtnAgendarCita()
        {
            InitializeComponent();
            CargarDatosFormulario();
            //CupoDAO.GetCuposReservados();
            duracionTipoCita = ((CatItem)cbxTipoCita.SelectedItem).DuracionMinutosCat;

            /*CREAR UN METODO A PARTE YA QUE SE REPITE TRES VECES
            lbxCupos.Items.Clear();
            foreach (Cupo c in CupoDAO.GetCuposDisponibles(campoFechaAgenda.Value,
                duracionTipoCita))
            {
                lbxCupos.Items.Add(c);
            }
            lbxCupos.Enabled = true;
            */
        }

        private void CargarDatosFormulario()
        {   
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));
            Rellenador.CargarListaAComboBox(cbxVeterinario, UsuarioDAO.GetListaUsuarios(2));
            Rellenador.CargarListaAComboBox(cbxTipoCita, CatDAO.GetTipoCitas());
            Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((int)cbxPropietario.SelectedValue));
            SetEdicionCampos();
            if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;
                Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((Usuario)cbxPropietario.SelectedItem));                
                //GetListaMascotasOwner realiza consulta a la BD cada que se llama
                //MI IDEA es que se cree una lista para el usuario si es nula y luego solo se llame la ya creada como con las ventanas
                //Dicha lista se asiganra valor nulo al registrar una nueva mascota para que solo entonces se vuelva a ejecutar la consulta
            }
            else if(UsuarioDAO.GetSesion().TipoUsuario == 2)
            {
                cbxVeterinario.Enabled = false;
                cbxVeterinario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;
            }
        }

        private void SetEdicionCampos()
        {
            if (Rellenador.Cita == null)
            {
                cbxPropietario.Enabled = true;
                cbxPropietario.SelectedIndex = -1;
                cbxVeterinario.Enabled = true;
                cbxVeterinario.SelectedIndex = -1;
                cbxTipoCita.Enabled = true;
                //cbxTipoCita.SelectedIndex = -1;
                txtMotivo.Enabled = true;
                txtMotivo.Clear();
            }
            else
            {
                //REAGENDAR CITA si existe un cupo y una cita seleccionada
                cbxPropietario.Enabled = false;

                cbxMascota.Enabled = true;
                cbxVeterinario.Enabled = true;

                cbxTipoCita.Enabled = true;
                txtMotivo.Enabled = true;
                cbxVeterinario.SelectedValue = Rellenador.Cita.IdVet;
                cbxTipoCita.SelectedValue = Rellenador.Cita.IdTipoCita;
                cbxPropietario.SelectedValue = Rellenador.Cita.IdPropietario;
                cbxMascota.SelectedValue = Rellenador.Cita.IdMascota;
                txtMotivo.Text = Rellenador.Cita.MotivoCita;
                //PUEDE QUE REQUIERA MOSTRAR UN BOTON PARA ACTUALIZAR DATOS DE LA CITA
            }
        }

        private void cbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioDAO.GetSesion().TipoUsuario != 3 && cbxPropietario.SelectedValue != null && cbxPropietario.SelectedIndex >= 0 && cbxPropietario.SelectedValue.GetType() != Type.GetType("System.Data.DataRowView"))
                {
                    //MessageBox.Show($"El texto seleccionado es {cbxPropietario.Text} - el valor o id Usuario {cbxPropietario.SelectedValue} y el index en el que se encuentra {cbxPropietario.SelectedIndex}");
                    Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((int)cbxPropietario.SelectedValue));
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
        }

        private void cbxVeterinario_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopularCuposDisponibles();
            /*
            //Cuando el vet cambie se actualizan los horarios o el tipo de cita los rangos           
            try
            {
                if (cbxVeterinario.SelectedValue != null && cbxVeterinario.SelectedIndex >= 0 && cbxVeterinario.SelectedValue.GetType() != Type.GetType("System.Data.DataRowView"))
                {
                    //Obtengo los cupos disponibles
                    PopularCuposDisponibles();
                }
                else
                {
                    PopularCuposDisponibles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aqui ocurrio una excepcion\n{ex.Message}");
                //ACA ME DA ERROR EL SELECTED VALUE TIPO ENTERO 
                //Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasPropietario((int)cbxPropietario.SelectedValue));
                //Rellenador.CargarDataTableAListBox(listaMascotas, MascotaDAO.GetMascotasPorPropietario((int)cbxPropietario.SelectedValue));
            }
            */
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            
            /*QUIERO VALIDAR QUE TODOS LOS CAMPOS ESTEN LLENOS INCLUYENDO EL DE VET*/
            bool camposValidos;
            camposValidos = cbxVeterinario.SelectedIndex > -1 && cbxMascota.SelectedIndex > -1 && cbxTipoCita.SelectedIndex > -1;
            //No me interesa saber si esta seleccionado el prop. Si esta seleccionada la mascota esta seleccionado el propietario

            if(cbxVeterinario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un veterinario");
                //camposValidos = false; Que no incida aun.
            }
            if (lbxCupos.SelectedIndex == -1) { 
                MessageBox.Show("No has seleccionado un cupo");
                lbxCupos.Focus();
                camposValidos = camposValidos && lbxCupos.SelectedIndex>-1;
            }
            if(txtMotivo.Text == "")
            {
                MessageBox.Show("indicanos el motivo de tu cita");
                txtMotivo.Focus();
                camposValidos = false;
            }
            if (camposValidos)
            {
                MessageBox.Show($"Los detalles de su cita son : \n" +
                    $"{cbxTipoCita.SelectedItem}\n" +
                    $"Fecha : {campoFechaAgenda.Value.ToString("d")}\n" +
                    $"Cupo : {lbxCupos.SelectedItem}\n" +
                    $"Veterinario : {cbxVeterinario.SelectedItem}\n" +
                    $" \n" +
                    $"Propietario : {cbxPropietario.SelectedItem}\n" +
                    $"Mascota : {cbxMascota.SelectedItem}\n" +
                    $"Motivo de su visita: \n{txtMotivo.Text}");
                Cita c = new Cita();
                c.IdTipoCita = (int)cbxTipoCita.SelectedValue;
                //MessageBox.Show("El id de la mascota es "+ (int)cbxMascota.SelectedValue);
                c.IdMascota = (int)cbxMascota.SelectedValue;
                c.IdVet = (int)cbxVeterinario.SelectedValue;
                c.MotivoCita = txtMotivo.Text;
                
                seleccionado = (Cupo)lbxCupos.SelectedItem;
                if(Rellenador.Cita == null)
                {
                    if (CupoDAO.ApartarCupo((int)cbxVeterinario.SelectedValue, campoFechaAgenda.Value.Date, seleccionado.HoraInicio, seleccionado.HoraFin))
                    {
                        int idReservacion = CupoDAO.IdInsert;
                        //REGISTRAR CITA
                        CitaDAO.RegistrarCita(c, (CatItem)cbxTipoCita.SelectedItem, idReservacion);
                        cbxMascota.SelectedIndex = -1;
                        cbxVeterinario.SelectedIndex = -1;
                    }
                }
                else
                {
                    CupoDAO.ActualizarCupo(Rellenador.Cita.Cupo.IdReservacion,(int)cbxVeterinario.SelectedValue, campoFechaAgenda.Value.Date, seleccionado.HoraInicio, seleccionado.HoraFin);
                    //Actualizar cita tambien
                    CitaDAO.ActualizarCita(Rellenador.Cita, (int)cbxTipoCita.SelectedValue, (int)cbxMascota.SelectedValue, (int)cbxVeterinario.SelectedValue, txtMotivo.Text);
                    this.Close();
                }
                

                //A Partir de aqui ya toca hacer el insert a detalle_reservacion y a citas
            }

            /*PRUEBAS: 
            CatItem tipoCita = (CatItem)cbxTipoCita.SelectedItem;
            Cupo cupoApartado = new Cupo(campoFechaAgenda.Value, 
                new DateTime(campoFechaAgenda.Value.Year, campoFechaAgenda.Value.Month, campoFechaAgenda.Value.Day, 
                campoFechaAgenda.Value.Hour,0,0),
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
                $"la duracion es : {cupoSiguiente.DuracionMinutos}"); */
            //CupoDAO.GetCuposDisponibles(cupoApartado.FechaCupo, tipoCita.DuracionMinutosCat); //Solo en el caso de ejemplo estaba ocupando con duracion en min
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

        private void campoFechaAgenda_ValueChanged(object sender, EventArgs e)
        {

            /*lbxCupos.DataSource = CupoDAO.GetCuposDisponibles(campoFechaAgenda.Value,
                duracionTipoCita);*/
            PopularCuposDisponibles();
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

        private void PopularCuposDisponibles()
        {
            //lbxCupos.DataSource = null;
            //campoFechaAgenda.Value = new DateTime(campoFechaAgenda.Value.Year, campoFechaAgenda.Value.Month, campoFechaAgenda.Value.Day);
            lbxCupos.Items.Clear();

            if (cbxVeterinario.SelectedIndex > -1)
            {
                foreach (Cupo c in CupoDAO.GetCuposDisponibles(campoFechaAgenda.Value, (CatItem)cbxTipoCita.SelectedItem, (Veterinario)cbxVeterinario.SelectedItem))
                {

                    //if (c.FechaCupo == new DateTime(campoFechaAgenda.Value.Year, campoFechaAgenda.Value.Month, campoFechaAgenda.Value.Day))
                    if (c.FechaCupo == campoFechaAgenda.Value.Date)
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
            else
            {
                foreach (Cupo c in CupoDAO.GetCuposDisponibles(campoFechaAgenda.Value,
                (CatItem)cbxTipoCita.SelectedItem))
                {
                    //Recien aprendiendo a ocupar fechas puedo ocupar la propiedad Date para sacar fecha con 0h0m0s
                    //if (c.FechaCupo == new DateTime(campoFechaAgenda.Value.Year, campoFechaAgenda.Value.Month, campoFechaAgenda.Value.Day))
                    if (c.FechaCupo == campoFechaAgenda.Value.Date)
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
        }

        private void btnGetCupos_Click(object sender, EventArgs e)
        {
            PopularCuposDisponibles();
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            cbxVeterinario.SelectedIndex = -1;
        }
    }
}
