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
    public partial class VtnMascotas : Form
    {
        
        public VtnMascotas()
        {
            InitializeComponent();
            CargarDatos();        
        }
        
        private void listaMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void VtnMascotas_Load(object sender, EventArgs e)
        {


        }

        private void CargarDatos()
        {
            Rellenador.CargarDataTableACombo(cbxEspecie, CatDAO.GetEspecie(), "id_especie", "nom_especie");
            Rellenador.CargarDataTableACombo(cbxPropietario, UsuarioDAO.GetTblClientes(), "id_usuario", "nombre");
            if (UsuarioDAO.getSesion().TipoUsuario == 3)
            {
                cbxPropietario.Enabled = false;
                cbxPropietario.SelectedValue = UsuarioDAO.getSesion().IdUsuario;
                Rellenador.CargarDataTableAListBox(listaMascotas, MascotaDAO.GetMascotasPorPropietario(UsuarioDAO.getSesion().IdUsuario));
                Rellenador.CargarDataTableACombo(cbxMascotas, MascotaDAO.GetMascotasPorPropietario(UsuarioDAO.getSesion().IdUsuario), "id_mascota", "nom_mascota");

            }
            else
            {
                cbxPropietario.Enabled = true;
                cbxPropietario.SelectedIndex = -1;
            }
        }

        private void cbxPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rellenador.CargarDataTableAListBox(listaMascotas, MascotaDAO.GetMascotasPorPropietario((int)cbxPropietario.SelectedValue));
        }

        private void cbxPropietario_SelectedValueChanged(object sender, EventArgs e)
        {
            
            //Rellenador.CargarDataTableAListBox(listaMascotas, MascotaDAO.GetMascotasPorPropietario((int)cbxPropietario.SelectedValue));
        }
    }
}
