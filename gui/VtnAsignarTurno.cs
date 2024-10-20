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
    public partial class VtnAsignarTurno : Form
    {
        private int contarChecks;
        private CheckBox[] checks;
        public VtnAsignarTurno()
        {
            InitializeComponent();
            Rellenador.CargarListaAComboBox(cbxVeterinario, UsuarioDAO.GetListaUsuarios(2));
            Rellenador.CargarListaAComboBox(cbxTurno, TurnoDAO.GetTurnosClinica());
            //Se crea el arreglo de checkboxes para asignar comportamiento
            checks = new CheckBox[] { chkDom, chkLun, chkMar, chkMie, chkJue, chkVie, chkSab };

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (ContarChecks() == 2) ChecksHabilitados();
            else if (ContarChecks() < 2)
            {
                foreach (CheckBox check in checks)
                {
                    if (!check.Checked) check.Enabled = true;

                }
            }

        }
        private int ContarChecks()
        {
            contarChecks = 0;
            foreach (CheckBox check in checks)
            {
                if (check.Checked) contarChecks++;
            }
            return contarChecks;
        }
        private void ChecksHabilitados()
        {
            foreach (CheckBox check in checks)
            {
                if (!check.Checked) check.Enabled = false;                
            }
        }
    }
}
