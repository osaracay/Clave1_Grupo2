using Clave1_Grupo2.dao;
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
    public partial class VtnPerfilUsuario : Form
    {
        public VtnPerfilUsuario()
        {
            //PARA ACCEDER A ESTA VENTANA DEBE HABER INICIADO SESION ANTES
            InitializeComponent();
            
        }

        private void VtnPerfilUsuario_Load(object sender, EventArgs e)
        {
            //Cargar datos del usuario
            CargarDatosUsuario();

        }
        
        private void CargarDatosUsuario()
        {

            btnGuardar.Hide(); //Mostrar al editar perfil

            //Mostrar al actualizar contraseña y volver a ocultar al actualizar
            btnActualizarPw.Hide();
            lblActualPw.Hide();
            lblNewPw.Hide();
            lblConfirmPw.Hide();
            txtUsrPw.Hide();
            txtNewPw.Hide();
            txtConfirmPw.Hide();
            //Cargar nombre usuario
            txtNombre.Text = $"{UsuarioDAO.getSesion().Username}";
            if (UsuarioDAO.getSesion().Genero == 'M')
            {
                txtNombre.Text += "♀";
                txtNombre.ForeColor = Color.Blue;
            }
            else if (UsuarioDAO.getSesion().Genero == 'F')
            {
                txtNombre.Text += "♂";
                txtNombre.ForeColor = Color.LightPink;
            }
            else
            {
                txtNombre.ForeColor = Color.White;
            }

            //Cargar nombre
            txtNombres.Text = UsuarioDAO.getSesion().Nombre;
            txtNombres.Enabled = false;
            //Cargar apellido
            txtApellidos.Text = UsuarioDAO.getSesion().Apellido;
            txtApellidos.Enabled = false;
            //Cargar email
            txtEmail.Text = UsuarioDAO.getSesion().Email;
            txtEmail.Enabled = false; //Activar al editar perfil
            //Cargar Fecha nacimiento
            campoFechaNac.Value = UsuarioDAO.getSesion().FechaNac;
            txtEdad.Text = $"Edad {Validacion.CalcularEdad(UsuarioDAO.getSesion().FechaNac)}";
            campoFechaNac.Enabled = false;
        }
        private void btnMisMascotas_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirVtnMascotas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Show();
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtEmail.Enabled = true;
            campoFechaNac.Enabled = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //HACER VALIDACIONES DE LOS CAMPOS AL IGUAL QUE EN REGISTRO DE USUARIOS
            //Realizar un update usando la clase UsuarioDAO

            //Actualizar el usuario sesion con los nuevos datos
            //Volver a cargar datos de usuario al terminar el update
            CargarDatosUsuario();

        }

        private void btnActualizarPw_Click(object sender, EventArgs e)
        {
            //REALIZAR VALIDACIONES 

            //AL TERMINAR EL UPDATE VOLVER A CARGAR DATOS DE USUARIO
            CargarDatosUsuario();
        }
        
        //BTN ACTUALIZAR PW
        private void button1_Click(object sender, EventArgs e)
        {
            //Mostrar al actualizar contraseña y volver a ocultar al actualizar
            btnActualizarPw.Show();
            lblActualPw.Show();
            lblNewPw.Show();
            lblConfirmPw.Show();
            txtUsrPw.Show();
            txtNewPw.Show();
            txtConfirmPw.Show();
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirAgregarMascota();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirAgendarCita();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirVtnCitas();
        }
    }
}
