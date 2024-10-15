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
    public partial class VtnAgregarMascota : Form
    {
        public VtnAgregarMascota()
        {
            InitializeComponent();
            Rellenador.CargarDataTableACombo(cbxEspecie, CatDAO.GetEspecie(), "id_especie", "nom_especie");
            Rellenador.CargarDataTableACombo(cbxPropietario, UsuarioDAO.GetTblClientes(), "id_usuario", "nombre");
            //Si el usuario es Cliente el cbxPropietario quedara deshabilitado y el cliente seleccionado
            if (UsuarioDAO.GetSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;
            } else {
                //si el usuario es vet o admin el cbxPropietario estara habilitados
                cbxPropietario.Enabled = true;
                cbxPropietario.SelectedIndex = -1;
            }
            

        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {            
            if (ValidarFormularioLleno() && Validacion.CampoNumEntero(txtEdadMascota, lblEdadValida, 0, 200))
            {
                char genero;
                if (chkFem.Checked)
                {
                    genero = 'F';
                }
                else if (chkMsc.Checked)
                {
                    genero = 'M';
                }
                else
                {
                    genero = 'X';
                }
                Mascota pet = new Mascota(txtNombreMascota.Text, (int)cbxEspecie.SelectedValue, txtRaza.Text, int.Parse(txtEdadMascota.Text), genero, (int)cbxPropietario.SelectedValue);//,txtColor.Text);
                MessageBox.Show($"Se creo una nueva mascota: {pet.GetNomMascota()}\n" +
                    $"especie {pet.GetEspecie()}\n" +
                    $"raza {pet.GetRaza()}\n" +
                    $"edad {pet.GetEdad()}\n" +
                    $"genero {pet.GetGeneroMascota()}\n" +
                    //$"color  {pet.Color}\n" +
                    $"propietario {pet.GetIdPropietario()}\n");
                MascotaDAO.RegistrarMascota(pet);
                
                //TAMBIEN QUIERO VOLVER A CARGAR LA LISTA DE MASCOTAS DEL DUENO
                LimpiarCampos();

                //this.Close();
            }
            else
            {
                MessageBox.Show("Revise que los campos esten correctos");
            }
        }

        private bool ValidarFormularioLleno()
        {
            bool lleno = Validacion.CampoLleno(txtNombreMascota)
                && Validacion.CampoLleno(txtEdadMascota)
                && Validacion.CampoLleno(txtColor)
                && Validacion.CampoLleno(txtRaza)
                && (cbxEspecie.SelectedIndex > -1)
                && cbxPropietario.SelectedIndex > -1;
            return lleno;
        }
        private void LimpiarCampos()
        {
            txtNombreMascota.Clear();
            txtColor.Clear();
            txtEdadMascota.Clear();
            txtRaza.Clear();
            cbxEspecie.SelectedIndex = -1;
        }

        private void txtEdadMascota_TextChanged(object sender, EventArgs e)
        {
            Validacion.CampoNumEntero(txtEdadMascota, lblEdadValida, 0, 200);
        }
    }
}
