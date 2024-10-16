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
    public partial class VtnMascotas : Form
    {

        private Mascota mascotaSeleccionada;
        public VtnMascotas()
        {
            InitializeComponent();                    
        }        
        private void VtnMascotas_Load(object sender, EventArgs e)
        {
            InhabilitarCampos();
            CargarDatos();
        }
        private void InhabilitarCampos()
        {
            btnGuardar.Hide();
            btnCancelar.Hide();
            txtNombres.Enabled = false;
            txtRaza.Enabled = false;
            txtEdad.Enabled = false;
            lblEdadValida.Hide();
            txtGenero.Enabled = false;
            cbxEspecie.Enabled = false;
            txtColorMascota.Enabled = false;
        }
        private void CargarDatos()
        {            
            Rellenador.CargarDataTableACombo(cbxEspecie, CatDAO.GetEspecie(), "id_especie", "nom_especie");
            Rellenador.CargarDataTableACombo(cbxPropietario, UsuarioDAO.GetTblClientes(), "id_usuario", "nombre");
            txtNombre.Text = UsuarioDAO.GetSesion().Username;
            if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;
                Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasOwner(UsuarioDAO.GetSesion())); 
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
        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            cbxEspecie.SelectedIndex = -1;
            txtColorMascota.Clear();
        }
        private void cbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioDAO.GetSesion().TipoUsuario != 3 && cbxPropietario.SelectedValue != null && cbxPropietario.SelectedIndex >=0 && cbxPropietario.SelectedValue.GetType() != Type.GetType("System.Data.DataRowView"))
                {
                    //MessageBox.Show($"El texto seleccionado es {cbxPropietario.Text} - el valor o id Usuario {cbxPropietario.SelectedValue} y el index en el que se encuentra {cbxPropietario.SelectedIndex}");
                    Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasOwner((int)cbxPropietario.SelectedValue));
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
        private void listaMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {            
            mascotaSeleccionada = (Mascota)listaMascotas.SelectedItem;
            txtNombres.Text = mascotaSeleccionada.GetNomMascota();
            cbxEspecie.SelectedValue = mascotaSeleccionada.GetEspecie();
            txtRaza.Text = mascotaSeleccionada.GetRaza();
            txtEdad.Text = mascotaSeleccionada.GetEdad().ToString();
            txtGenero.Text = mascotaSeleccionada.GetGeneroMascota().ToString();
            txtColorMascota.Text = mascotaSeleccionada.Color;
            InhabilitarCampos();
            //Intente limpiar cuando no hubiera items en la lista con selecteditem distinto de null
            //y lista items count mayor que 0 pero no se limpiaron los campos
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Show();
            btnCancelar.Show();
            txtNombres.Enabled = true;
            txtRaza.Enabled = true;
            txtEdad.Enabled = true;
            lblEdadValida.Show();
            txtGenero.Enabled = true;
            cbxEspecie.Enabled = true;
            txtColorMascota.Enabled = true;            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InhabilitarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Realizar update con MascotaDAO
            MascotaDAO.ActualizarDatosMascota(mascotaSeleccionada,txtNombres.Text,cbxEspecie.SelectedIndex,
                txtRaza.Text,int.Parse(txtEdad.Text),char.Parse(txtGenero.Text),txtColorMascota.Text);
            //LimpiarCampos(); de momento si cambio el item seleccionado y selecciono el que modifique no muestra los cambios hasta reabrir la ventana
            Rellenador.CargarListaPetAListBox(listaMascotas, MascotaDAO.GetListaMascotasOwner((int)cbxPropietario.SelectedValue)); //Ahora si
            InhabilitarCampos();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            Validacion.CampoNumEntero(txtEdad, lblEdadValida);
        }
    }
}
