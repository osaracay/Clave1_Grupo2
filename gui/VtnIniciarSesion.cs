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
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ABRIR FORMULARIO DE REGISTRO
            GestorVentanas.SolicitarRegistroUsuario();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if(UsuarioDAO.AutenticarUsuario(txtUsuario.Text, CyberSec.HolaCosmos(txtPassword.Text))){
                
                //DA ERROR SI EL USUARIO NO EXISTE
                MessageBox.Show($"Bienvenido {UsuarioDAO.getSesion().Nombre} {UsuarioDAO.getSesion().Apellido}");
                this.Close();                
                //PENDIENTE
                //Actualizar el menu de inicio para mostrar las funciones de acuerdo con el tipo de usuario
            }           
        }

        private bool FormularioLleno()
        {
            bool lleno = Validacion.CampoLleno(txtUsuario) && Validacion.CampoLleno(txtPassword);
            return lleno;
        }

        private void lblForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //MessageBox.Show(CyberSec.Saracay(UsuarioDAO.OlvidePw(txtUsuario.Text.Trim())));
            MessageBox.Show("Acuerdese");
        }
    }
}
