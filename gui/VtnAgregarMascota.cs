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
    public partial class VtnAgregarMascota : Form
    {
        public VtnAgregarMascota()
        {
            InitializeComponent();
            Rellenador.CargarDataTableACombo(cbxEspecie, CatDAO.GetEspecie(), "id_especie", "nom_especie");
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {

        }
    }
}
