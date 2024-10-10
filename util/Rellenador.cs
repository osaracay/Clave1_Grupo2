using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.util
{
    class Rellenador
    {
        /*PARA DATATABLES OBTENIDOS DE LA BASE DE DATOS*/
        public static void CargarDataTableACombo(ComboBox cb, DataTable dataTable, string campoId, string mostrarCampo)
        {
            cb.DataSource = dataTable;
            cb.DisplayMember = mostrarCampo;
            cb.ValueMember = campoId;
            cb.SelectedIndex = -1; //0 o -1
        }
    }
}
