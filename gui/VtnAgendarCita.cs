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
        public VtnAgendarCita()
        {
            InitializeComponent();
            CargarDatosFormulario();
        }

        private void CargarDatosFormulario()
        {                        
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));
            Rellenador.CargarListaAComboBox(cbxVeterinario, UsuarioDAO.GetListaUsuarios(2));
            if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;
                Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner((Usuario)cbxPropietario.SelectedItem));
                //GetListaMascotasOwner realiza consulta a la BD cada que se llama
                //MI IDEA es que se cree una lista para el usuario si es nula y luego solo se llame la ya creada como con las ventanas
                //Dicha lista se asiganra valor nulo al registrar una nueva mascota para que solo entonces se vuelva a ejecutar la consulta
            }
            else
            {
                cbxPropietario.Enabled = true;
                cbxPropietario.SelectedIndex = -1;
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
    }
}
