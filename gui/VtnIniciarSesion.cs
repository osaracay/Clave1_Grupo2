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
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ABRIR FORMULARIO DE REGISTRO
            GestorVentanas.SolicitarRegistroUsuario();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if(FormularioLleno() && UsuarioDAO.AutenticarUsuario(txtUsuario.Text, CyberSec.HolaCosmos(txtPassword.Text))){
                if(UsuarioDAO.getSesion() != null) {
                    //DA ERROR SI EL USUARIO NO EXISTE
                    MessageBox.Show($"Bienvenido {UsuarioDAO.getSesion().Nombre} {UsuarioDAO.getSesion().Apellido}");
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

        private bool FormularioLleno()
        {
            bool lleno = Validacion.CampoLleno(txtUsuario) && Validacion.CampoLleno(txtPassword);
            return lleno;
        }
        int insistente;
        private void lblForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            insistente++;
            if (insistente <= 5)
            {
                MessageBox.Show("Acuérdese");
            }
            else if (insistente==6)
            {
                MessageBox.Show(CyberSec.Saracay(UsuarioDAO.Olvidaste(txtUsuario.Text.Trim())));
            }
            else
            {
                MessageBox.Show("ignorando ...");
            }
            
        }
    }
}
