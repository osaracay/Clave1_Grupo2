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
    }
}
