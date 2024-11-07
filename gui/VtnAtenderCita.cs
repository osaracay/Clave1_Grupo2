using Clave1_Grupo2.dao;
using Clave1_Grupo2.entity;
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
    public partial class VtnAtenderCita : Form
    {

        public VtnAtenderCita()
        {
            InitializeComponent();
            cbxTipoCita.Enabled = false;
            cbxMascota.Enabled = false;
            Rellenador.CargarListaAComboBox(cbxTipoCita, CatDAO.GetTipoCitas());
            Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner(Rellenador.Cita.IdPropietario));
            
        }

        private void VtnAtenderCita_Load(object sender, EventArgs e)
        {
            cbxTipoCita.SelectedValue = Rellenador.Cita.IdTipoCita;
            cbxMascota.SelectedValue = Rellenador.Cita.IdMascota;
            txtMotivo.Text = Rellenador.Cita.MotivoCita;
            /*
            Rellenador.CargarListaAComboBox(cbxMascota, MascotaDAO.GetListaMascotasOwner(cita.IdPropietario));
            cbxTipoCita.SelectedValue = cita.IdTipoCita;
            cbxMascota.SelectedValue = cita.IdMascota;
            */
        }
    }
}
