using Clave1_Grupo2.dao;
using Clave1_Grupo2.entity;
using Clave1_Grupo2.gui;
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
            GestorVentanas.SolicitarRegistroUsuario();
        }
        private void lblSesion_Click(object sender, EventArgs e)
        {
            GestorVentanas.SolicitarInicioSesion();
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirAgregarMascota();
        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirAgendarCita();
            /*Ejemplo de usuarios
            Usuario u = new Usuario();
            u.SetIdUsuario(1);
            MessageBox.Show(u.GetIdUsuario().ToString());

            Cliente c = new Cliente();
            c.GetIdUsuario();
            Usuario a = new Cliente();
            Cliente b = (Cliente)a;
            //Administrador d = (Administrador)a;
            */
        }

        private void btnMisMascotas_Click(object sender, EventArgs e)
        {
            //ConexionBD.GetConexionBD();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirInsumo();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirCompra();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            GestorVentanas.AbrirVenta();
        }
    }
}
