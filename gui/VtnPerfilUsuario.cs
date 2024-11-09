using Clave1_Grupo2.dao;
using Clave1_Grupo2.util;
using System;
using System.Drawing;
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
            btnCancelar.Hide();
            btnActualizarPic.Hide();
            btnSelecPic.Hide();
            //Cargar nombre usuario
            txtNombre.Text = UsuarioDAO.GetSesion().Username;
            if (UsuarioDAO.GetSesion().Genero == 'M')
            {
                txtNombre.Text += "♂";
                txtNombre.ForeColor = Color.Blue;
            }
            else if (UsuarioDAO.GetSesion().Genero == 'F')
            {
                txtNombre.Text += "♀";
                txtNombre.ForeColor = Color.LightPink;
            }
            else
            {
                txtNombre.ForeColor = Color.White;
            }

            //Cargar nombre
            txtNombres.Text = UsuarioDAO.GetSesion().Nombre;
            txtNombres.Enabled = false;
            //Cargar apellido
            txtApellidos.Text = UsuarioDAO.GetSesion().Apellido;
            txtApellidos.Enabled = false;
            //Cargar email
            txtEmail.Text = UsuarioDAO.GetSesion().Email;
            txtEmail.Enabled = false; //Activar al editar perfil
            //Cargar Fecha nacimiento
            campoFechaNac.Value = UsuarioDAO.GetSesion().FechaNac;
            txtEdad.Text = $"Edad {Validacion.CalcularEdad(UsuarioDAO.GetSesion().FechaNac)}";
            campoFechaNac.Enabled = false;

            //Cargar imagen SI EXISTE:
            if(UsuarioDAO.CargarImagenAPictureBox(pbxFotoPerfil, UsuarioDAO.GetSesion().IdUsuario)){

            }
            else {
                this.pbxFotoPerfil.Image = Image.FromFile("../../assets/Usuario.png");
            }          
            //Si no existe que carge por defecto
            

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
            lblConfirmPw.Show();
            txtConfirmPw.Show();
            btnCancelar.Show();
            btnActualizarPic.Show();
            btnSelecPic.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //HACER VALIDACIONES DE LOS CAMPOS AL IGUAL QUE EN REGISTRO DE USUARIOS
            bool camposValidos = Validacion.CampoLleno(txtNombres) && Validacion.CampoLleno(txtApellidos) && Validacion.CampoLleno(txtEmail)
                && Validacion.CampoEmail(txtEmail) && Validacion.EsMayorDeEdad(campoFechaNac.Value); //AGREGAR VALIDACION PARA CONFIRMAR CONTASEna

            //!!! SOLICITAR CONTRASEñA
            camposValidos = camposValidos && contraCoincide(txtConfirmPw);
            if (camposValidos) {
                //Realizar un update usando la clase UsuarioDAO
                UsuarioDAO.ActualizarDatosUsuario(UsuarioDAO.GetSesion(), txtNombres.Text, txtApellidos.Text, txtEmail.Text, campoFechaNac.Value);


                //Actualizar el usuario sesion con los nuevos datos
                //MessageBox.Show("Informacion de usuario actualizada exitosamente\nPara visualizar los cambios vuelva a iniciar sesion");                
                //Aprovechando que tengo la . del usuario en txtConfirmPw y que el metodo autenticar usuario actualiza las propiedades del Usuario
                //ya no hace falta cerrar sesion y volverla a abrir
                UsuarioDAO.AutenticarUsuario(UsuarioDAO.GetSesion().Username,CyberSec.HolaCosmos(txtConfirmPw.Text));                 
                txtConfirmPw.Clear(); //Luego limpio el campo
                //Volver a cargar datos de usuario al terminar el update
                CargarDatosUsuario();
            }
            else
            {
                MessageBox.Show("Revise que los campos sean correctos");
            }                      
        }

        private bool NuevaPwCoincide()
        {
            //Validar que contrasenas coincidan
            if (txtNewPw.Text.Equals(txtConfirmPw.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("La contraseña no coincide en el campo de confirmar");
                txtConfirmPw.Focus();
                return false;
            }
        }
        //RECIBE el textbox con . a evaluar 
        private bool contraCoincide(TextBox tbpw)
        {
            if (CyberSec.HolaCosmos(tbpw.Text).Equals(UsuarioDAO.Olvidaste(UsuarioDAO.GetSesion().Username)))
            { //El metodo olvidaste le pasas el nombre de usuario como argumento y te devuelve la pw en la BD, por eso la llamamos desde UsuarioDAO
                return true;
            }
            else
            {
                MessageBox.Show("La contraseña actual es incorrecta");
                tbpw.Focus();
                return false;
            }
        }

        private void btnActualizarPw_Click(object sender, EventArgs e)
        {
            //REALIZAR VALIDACIONES 
            bool camposValidos = Validacion.CampoLleno(txtUsrPw) && Validacion.CampoLleno(txtNewPw) && Validacion.CampoLleno(txtConfirmPw);
            camposValidos = camposValidos && contraCoincide(txtUsrPw);
            camposValidos = camposValidos && NuevaPwCoincide();            
            //Si la contrasena ingresada es igual a la registrada por el usuario activo
            if (camposValidos)
            {
                UsuarioDAO.ActualizarLlaveCliente(UsuarioDAO.GetSesion(), CyberSec.HolaCosmos(txtNewPw.Text));
                //AL TERMINAR EL UPDATE VOLVER A CARGAR DATOS DE USUARIO
                txtUsrPw.Clear();
                txtNewPw.Clear();
                txtConfirmPw.Clear();
                CargarDatosUsuario();
            }
            
            
        }
        
        //BTN ACTUALIZAR PW
        private void btnHabilitarCambioPw_Click(object sender, EventArgs e)
        {
            //Mostrar al actualizar contraseña y volver a ocultar al actualizar
            btnActualizarPw.Show();
            lblActualPw.Show();
            lblNewPw.Show();
            lblConfirmPw.Show();
            txtUsrPw.Show();
            txtNewPw.Show();
            txtConfirmPw.Show();
            btnCancelar.Show();
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirAgregarMascota();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Rellenador.Cita = null;
            GestorVentanas.AbrirAgendarCita();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirVtnCitas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }

        private void pbxFotoPerfil_Click(object sender, EventArgs e)
        {
            GestorVentanas.VerImagen();
        }

        private void btnActualizarPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Rellenador.GetByteArrayDePicBox(pbxFotoPerfil).ToString());
            UsuarioDAO.GuardarImagen(Rellenador.GetByteArrayDePicBox(pbxFotoPerfil),UsuarioDAO.GetSesion().IdUsuario);
            CargarDatosUsuario();
        }

        private void btnSelecPic_Click(object sender, EventArgs e)
        {
            Rellenador.SeleccionarImagen(pbxFotoPerfil);
        }
    }
}
