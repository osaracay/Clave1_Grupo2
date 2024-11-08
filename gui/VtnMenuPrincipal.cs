using Clave1_Grupo2.dao;
using Clave1_Grupo2.util;
using System;
using System.Windows.Forms;

namespace Clave1_Grupo2
{
    public partial class VtnMenuPrincipal : Form
    {

        public VtnMenuPrincipal()
        {
            InitializeComponent();            
        }

        private void lblRegistrarUsuario_Click(object sender, EventArgs e)
        {
            //DEBES SER VET O ADMIN PARA REGISTRAR USUARIOS? NOP, TAMBIEN CLIENTE
            GestorVentanas.SolicitarRegistroUsuario();
        }
        private void lblSesion_Click(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion() != null)
            {
                UsuarioDAO.SetSesion(null);
                GestorVentanas.SolicitarInicioSesion();
            }                       
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirAgregarMascota();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }
            
        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirAgendarCita();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }
            
        }

        private void btnMisMascotas_Click(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirVtnMascotas();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }


        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirVtnCitas();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }

        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            ////DEBES SER USUARIO VET o ADMINISTRADOR PARA ACCEDER
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirInsumo();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }

            
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            //DEBES SER USUARIO VET o ADMINISTRADOR PARA ACCEDER
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirCompra();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }
            
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            //DEBES SER USUARIO VET o ADMINISTRADOR PARA ACCEDER
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirVenta();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }            
        }

        /*QUISIERA PODER ACTUALIZAR LAS OPCIONES DEL MENU PRINCIPAL CONFORME SE ESTE LOGGEADO O NO
        SE ME OCURRE ENTONCES OCUPAR INICIO DE SESION AL CARGAR LA VENTANA PRINCIPAL        
        private void ActualizarMenuPrincipal()
        {

            if (UsuarioDAO.getSesion() == null)
            {
 
            }
            else
            {

            }
        }
        */
        private void VtnMenuPrincipal_Load(object sender, EventArgs e)
        {
            GestorVentanas.SolicitarInicioSesion();
        }

        private void lblMiPerfil_Click(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirMiPerfil();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }
        }

        private void btnVntC_Click(object sender, EventArgs e)
        {
            //DEBES SER USUARIO VET o ADMINISTRADOR PARA ACCEDER
            if (UsuarioDAO.GetSesion() != null)
            {
                GestorVentanas.AbrirConsVenta();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion para acceder a esta funcion");
                GestorVentanas.SolicitarInicioSesion();
            }
        }

        private void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            //DEBES SER USUARIO ADMINISTRADOR PARA ACCEDER
            if (UsuarioDAO.GetSesion() != null && UsuarioDAO.GetSesion().TipoUsuario == 1)
            {
                GestorVentanas.AsignarTurno();
            }
            else
            {
                MessageBox.Show("Debes iniciar sesion como administrador para acceder a esta funcion");
                //GestorVentanas.SolicitarInicioSesion();
            }
        }

        private void VtnMenuPrincipal_Activated(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion() == null || UsuarioDAO.GetSesion().TipoUsuario != 1)
            {
                btnAsignarTurno.Hide();
                lblAsignarTurno.Hide();
            }
            else
            {
                btnAsignarTurno.Show();
                lblAsignarTurno.Show();
            }
        }
    }
}
