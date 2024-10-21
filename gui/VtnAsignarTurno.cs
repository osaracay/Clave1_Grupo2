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
    public partial class VtnAsignarTurno : Form
    {
        private int contarChecks;
        private CheckBox[] checks;
        private char descanso1;
        private char descanso2;
        public VtnAsignarTurno()
        {
            InitializeComponent();
            Rellenador.CargarListaAComboBox(cbxVeterinario, UsuarioDAO.GetListaUsuarios(2));
            Rellenador.CargarListaAComboBox(cbxTurno, TurnoDAO.GetTurnosClinica());
            //Se crea el arreglo de checkboxes para asignar comportamiento
            checks = new CheckBox[] { chkDom, chkLun, chkMar, chkMie, chkJue, chkVie, chkSab };            
            CargarDetalleTurno();

        }

        private char GetDescanso1()
        {
            if (chkDom.Checked == true) descanso1 = 'd';
            else if (chkLun.Checked == true) descanso1 = 'l';
            else if (chkMar.Checked == true) descanso1 = 'm';
            else if (chkMie.Checked == true) descanso1 = 'x';
            else if (chkJue.Checked == true) descanso1 = 'j';
            else if (chkVie.Checked == true) descanso1 = 'v';
            else if (chkSab.Checked == true) descanso1 = 's';
            return descanso1;
        }
        private char GetDescanso2()
        {
            if (chkDom.Checked == true && descanso1 != 'd') descanso2 = 'd';
            else if (chkLun.Checked == true && descanso1 != 'l') descanso2 = 'l';
            else if (chkMar.Checked == true && descanso1 != 'm') descanso2 = 'm';
            else if (chkMie.Checked == true && descanso1 != 'x') descanso2 = 'x';
            else if (chkJue.Checked == true && descanso1 != 'j') descanso2 = 'j';
            else if (chkVie.Checked == true && descanso1 != 'v') descanso2 = 'v';
            else if (chkSab.Checked == true && descanso1 != 's') descanso2 = 's';
            return descanso2;
        }

        /// <summary>
        /// Habilitar botones asignar y reasignar segun corresponda.
        /// Al seleccionarse un veterinario debe popularse el turno,
        /// los dias de descanso y habilitarse o inhabilitarse los botones
        /// Asignar y Reasignar respectivamente.
        /// </summary>
        private void CargarDetalleTurno()
        {
            //Finalmente usando LinQ,
            //pero estoy usando una coleccion para un query que arojara un solo resultado
            //ya que los ids de veterinarios en la lista detalle turnos son valores únicos
            IEnumerable<Turno> t = from turno in TurnoDAO.GetTurnosVeterinarios() 
                                   where turno.IdVet == (int)cbxVeterinario.SelectedValue 
                                   select turno;
            if (t.Count() == 0)
            {
                //Habilitar asignar deshabilitar reasignar
                btnAsignar.Enabled = true;
                btnReasignar.Enabled = false;
                cbxTurno.SelectedIndex = -1;
                ReestablecerCheques();                
            }
            else
            {
                btnAsignar.Enabled = false;
                btnReasignar.Enabled = true;
                /*cbxTurno.SelectedValue = t.ElementAt(0).IdTurno;*/
                foreach (Turno item in t)
                {                    
                    cbxTurno.SelectedValue = item.IdTurno;
                    ReestablecerCheques();
                    SeleccionarDiaDescanso(item.Descanso1);
                    SeleccionarDiaDescanso(item.Descanso2);
                    ChecksHabilitados();                    
                }
            }
        }
        
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //Validar campos llenos
            if (cbxVeterinario.SelectedIndex > -1 && cbxTurno.SelectedIndex > -1 && ContarChecks() == 2)
            {
                TurnoDAO.AsignarTurno((int)cbxVeterinario.SelectedValue, (int)cbxTurno.SelectedValue, GetDescanso1(), GetDescanso2());
                TurnoDAO.ActualizarDetalleturnos();
            }
            else
            {
                MessageBox.Show("Asignacion incompleta\nDebe seleccionar un turno y dos dias de descanso");
            }
        }
        private void btnReasignar_Click(object sender, EventArgs e)
        {
            //Validar campos llenos
            if (cbxVeterinario.SelectedIndex > -1 && cbxTurno.SelectedIndex > -1 && ContarChecks() == 2)
            {
                TurnoDAO.ReasignarTurno((int)cbxVeterinario.SelectedValue, (int)cbxTurno.SelectedValue, GetDescanso1(), GetDescanso2());
                TurnoDAO.ActualizarDetalleturnos();
            }
            else
            {
                MessageBox.Show("Asignacion incompleta\nDebe seleccionar un turno y dos dias de descanso");
            }
        }
        /*Metodos para controlar comportamiento de checks dias de descanso*/
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
        /// <summary>
        /// Recorre el arreglo de checkboxes en el formulario y deshabilita aquellos que no esten marcados
        /// </summary>
        private void ChecksHabilitados()
        {
            foreach (CheckBox check in checks)
            {
                if (!check.Checked) check.Enabled = false;                
            }
        }
        private void SeleccionarDiaDescanso(char d)
        {

            switch (d)
            {
                case 'd':
                    chkDom.Checked = true;
                    //chkLun.Checked = false; chkMar.Checked = false; chkMie.Checked = false; chkJue.Checked = false; chkVie.Checked = false; chkSab.Checked = false;
                    break;
                case 'l':
                    chkLun.Checked = true;
                    //chkDom.Checked = false; chkMar.Checked = false; chkMie.Checked = false; chkJue.Checked = false; chkVie.Checked = false; chkSab.Checked = false;
                    break;
                case 'm':
                    chkMar.Checked = true;
                    //chkLun.Checked = false; chkDom.Checked = false; chkMie.Checked = false; chkJue.Checked = false; chkVie.Checked = false; chkSab.Checked = false;
                    break;
                case 'x':
                    chkMie.Checked = true;
                    //chkLun.Checked = false; chkMar.Checked = false; chkDom.Checked = false; chkJue.Checked = false; chkVie.Checked = false; chkSab.Checked = false;
                    break;
                case 'j':
                    chkJue.Checked = true;
                    //chkLun.Checked = false; chkMar.Checked = false; chkMie.Checked = false; chkDom.Checked = false; chkVie.Checked = false; chkSab.Checked = false;
                    break;
                case 'v':
                    chkVie.Checked = true;
                    //chkLun.Checked = false; chkMar.Checked = false; chkMie.Checked = false; chkJue.Checked = false; chkDom.Checked = false; chkSab.Checked = false;
                    break;
                case 's':
                    chkSab.Checked = true;
                    //chkLun.Checked = false; chkMar.Checked = false; chkMie.Checked = false; chkJue.Checked = false; chkVie.Checked = false; chkDom.Checked = false;
                    break;
            }
        }

        private void ReestablecerCheques()
        {
            chkDom.Checked = false;
            chkLun.Checked = false;
            chkMar.Checked = false;
            chkMie.Checked = false;
            chkJue.Checked = false;
            chkVie.Checked = false;
            chkSab.Checked = false;
            chkDom.Enabled = true;
            chkLun.Enabled = true;
            chkMar.Enabled = true;
            chkMie.Enabled = true;
            chkJue.Enabled = true;
            chkVie.Enabled = true;
            chkSab.Enabled = true;
        }
        private void cbxVeterinario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxVeterinario.SelectedValue != null && cbxVeterinario.SelectedIndex >= 0 && cbxVeterinario.SelectedValue.GetType() != Type.GetType("System.Data.DataRowView"))
                {
                    CargarDetalleTurno();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
