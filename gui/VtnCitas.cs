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
            CartillaVacunacion cartilla = new CartillaVacunacion();
            cartilla.Show();
        }
    }
}
