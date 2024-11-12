using Clave1_Grupo2.dao;
using Clave1_Grupo2.util;
using System.Windows.Forms;

namespace Clave1_Grupo2.gui
{
    public partial class VtnIniciarSesion : Form
    {
        public VtnIniciarSesion()
        {
            InitializeComponent();
            txtUsuario.Focus();

            //PERMITE SELECCIONAR LA BASE DE DATOS AL INICIO DEL PROGRAMA
            ConexionBD.SeleccionarTipoConexion();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ABRIR FORMULARIO DE REGISTRO
            GestorVentanas.SolicitarRegistroUsuario();
        }

        private void Autenticar()
        {
            if (FormularioLleno() && UsuarioDAO.AutenticarUsuario(txtUsuario.Text, CyberSec.HolaCosmos(txtPassword.Text)))
            {
                if (UsuarioDAO.GetSesion() != null)
                {
                    //DA ERROR SI EL USUARIO NO EXISTE
                    MessageBox.Show($"Bienvenido {UsuarioDAO.GetSesion().Nombre} {UsuarioDAO.GetSesion().Apellido}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }

                //PENDIENTE
                //Actualizar el menu de inicio para mostrar las funciones de acuerdo con el tipo de usuario
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            Autenticar();
        }

        private bool FormularioLleno()
        {
            bool lleno = Validacion.CampoLleno(txtUsuario) && Validacion.CampoLleno(txtPassword);
            return lleno;
        }
        int insistente;
        private void lblForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            insistente++;
            if (insistente <= 2)
            {
                MessageBox.Show($"Acuérdese ({insistente})");
            }
            else if (insistente==3)
            {
                MessageBox.Show(CyberSec.Saracay(UsuarioDAO.Olvidaste(txtUsuario.Text.Trim())));
            }
            else
            {
                MessageBox.Show("No la repetiré ...");
            }            
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Autenticar();
        }
    }
}
