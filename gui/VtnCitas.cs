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

        private void CargarDatos()
        {
            btnAtender.Hide();
            //Validar que no se cargen tantas veces estas listas
            Rellenador.CargarListaAComboBox(cbxPropietario, UsuarioDAO.GetListaUsuarios(3));            
            Rellenador.CargarListaAComboBox(cbxVeterinario, UsuarioDAO.GetListaUsuarios(2));
            Rellenador.CargarListaAComboBox(cbxTipoCita, CatDAO.GetTipoCitas());
            //Valide que la lista tipo cita se crea una sola vez y luego se llama lo que se crea la primera vez que se llama

            cbxTipoCita.SelectedIndex = -1;
            cbxTipoCita.Enabled = false;
            cbxVeterinario.SelectedIndex = -1;
            cbxPropietario.SelectedIndex = -1;
            cbxMascota.SelectedIndex = -1;
            //lbxCitas.SelectedIndex = -1;
            if (UsuarioDAO.GetSesion().TipoUsuario == 2)
            {
                btnAtender.Show();
                cbxVeterinario.Enabled = false;
                cbxVeterinario.SelectedValue = UsuarioDAO.GetSesion().IdUsuario;
                listaCitas = CitaDAO.GetCitas(UsuarioDAO.GetSesion()); //Lista Citas

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

            listaCitas = CitaDAO.GetCitas(UsuarioDAO.GetSesion()); //Lista Citas
            //lbxCitas.Items.Clear();
            lbxCitas.DataSource = listaCitas;
            lbxCitas.SelectedItem = -1;
            /*
            foreach (Cita c in listaCitas)
            {
                MessageBox.Show($"{c.Cupo.FechaCupo} : {c.Cupo.HoraInicio} - {c.Cupo.HoraFin}\n{c.MotivoCita}");
                                                
            } 
            */
        }

        private void VtnCitas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            lbxCitas.SelectedItem = -1;
            lbxCitas.Refresh();
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
            if (lbxCitas.SelectedIndex > -1)
            {
                cbxPropietario.SelectedValue = ((Cita)lbxCitas.SelectedItem).IdPropietario;
                cbxMascota.SelectedValue = ((Cita)lbxCitas.SelectedItem).IdMascota;
                cbxTipoCita.SelectedValue = ((Cita)lbxCitas.SelectedItem).IdTipoCita;
                cbxVeterinario.SelectedValue = ((Cita)lbxCitas.SelectedItem).IdVet;
                Rellenador.Cita = (Cita)lbxCitas.SelectedItem;
                cbxMascota.Enabled = false;
            }
            else
            {
                cbxMascota.Enabled = true;
                cbxTipoCita.SelectedIndex = -1;
            }
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
        /*
private void lbxCitas_KeyPress(object sender, KeyPressEventArgs e)
{
if (e.KeyChar == (char)Keys.Escape)
{
lbxCitas.SelectedItem = -1;
}
}
*/
    }
}
