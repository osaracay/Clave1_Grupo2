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
    public partial class VtnAgendarCita : Form
    {
        private List<Cliente> clientes;
        private List<Veterinario> veterinarios;
        public VtnAgendarCita()
        {
            InitializeComponent();
            CargarDatosFormulario();
            CitaDAO.GetCuposReservados();
        }

        private void CargarDatosFormulario()
        {                        
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));
            Rellenador.CargarListaAComboBox(cbxVeterinario, UsuarioDAO.GetListaUsuarios(2));
            Rellenador.CargarListaAComboBox(cbxTipoCita, CatDAO.GetTipoCitas());
            cbxPropietario.Enabled = true;
            cbxPropietario.SelectedIndex = -1;
            cbxVeterinario.Enabled = true;
            cbxVeterinario.SelectedIndex = -1;
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
            //Cuando el vet cambie se actualizan los horarios o el tipo de cita los rangos
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

            Cupo cupoApartado = new Cupo(campoFechaAgenda.Value, 
                new DateTime(campoFechaAgenda.Value.Year, campoFechaAgenda.Value.Month, campoFechaAgenda.Value.Day, 
                campoFechaAgenda.Value.Hour,0,0),
                60);
            MessageBox.Show($"la fecha seleccionada es : {cupoApartado.FechaCupo}\n" +
                $"la hora de inicio es : {cupoApartado.HoraInicio}\n" +
                $"la hora de finalizacion es : {cupoApartado.HoraFin}\n" +
                $"la duracion es : {cupoApartado.DuracionMinutos}");
        }
    }
}
