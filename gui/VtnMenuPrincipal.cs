using Clave1_Grupo2.entity;
using Clave1_Grupo2.gui;
using System;
using System.Windows.Forms;

namespace Clave1_Grupo2
{
    public partial class VtnMenuPrincipal : Form
    {
        VtnIniciarSesion vtnIniciarSesion;
        VtnRegistrarUsuario vtnRegistrar;
        public VtnMenuPrincipal()
        {
            InitializeComponent();
        }

        private void lblRegistrarUsuario_Click(object sender, EventArgs e)
        {
            SolicitarRegistroUsuario();
        }
        private void lblSesion_Click(object sender, EventArgs e)
        {
            SolicitarInicioSesion();
        }
        private void SolicitarRegistroUsuario()
        {
            if (vtnRegistrar == null || vtnRegistrar.IsDisposed)
            {
                vtnRegistrar = null;
                vtnRegistrar = new VtnRegistrarUsuario();
            }
            vtnRegistrar.Show();
            vtnRegistrar.Focus();
        }
        private void SolicitarInicioSesion()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vtnIniciarSesion == null || vtnIniciarSesion.IsDisposed)
            {
                vtnIniciarSesion = null;
                vtnIniciarSesion = new VtnIniciarSesion();
            }
            vtnIniciarSesion.Show();
            vtnIniciarSesion.Focus();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            //Ejemplo de usuarios
            Usuario u = new Usuario();
            u.SetIdUsuario(1);
            MessageBox.Show(u.GetIdUsuario().ToString());

            Cliente c = new Cliente();
            c.GetIdUsuario();
            Usuario a = new Cliente();
            Cliente b = (Cliente)a;
            //Administrador d = (Administrador)a;
        }
    }
}
