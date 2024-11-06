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
    public partial class VtnCitas : Form
    {
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
            if(UsuarioDAO.GetSesion().TipoUsuario == 2)
            {
                GestorVentanas.AtenderCita();
            }
        }

        private void VtnCitas_Load(object sender, EventArgs e)
        {
            if (UsuarioDAO.GetSesion().TipoUsuario == 2)
            {
                btnAtender.Show();
            }
            else
            {
                btnAtender.Hide();
            }
        }
    }
}
