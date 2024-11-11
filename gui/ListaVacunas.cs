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
    public partial class ListaVacunas : Form
    {
        public ListaVacunas()
        {
            InitializeComponent();
            dataGridViewVacunacion.CellClick += dataGridViewVacunacion_CellClick;
        }

        private void ListaVacunas_Load(object sender, EventArgs e)
        {
            // Configuración del DataGridView
            dataGridViewVacunacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVacunacion.MultiSelect = false;
            dataGridViewVacunacion.AllowUserToAddRows = false;

            // Agregar columnas
            dataGridViewVacunacion.Columns.Add("Vacuna", "Vacuna");
            dataGridViewVacunacion.Columns.Add("Edad", "Edad");
            dataGridViewVacunacion.Columns.Add("Dosis", "Dosis");
            dataGridViewVacunacion.Columns.Add("ViaAdministracion", "Vía de administración");
            dataGridViewVacunacion.Columns.Add("EnfermedadPreviene", "Enfermedad que previene");

            // Agregar filas con los datos de la cartilla de vacunación
            dataGridViewVacunacion.Rows.Add("BCG", "Nacimiento", "Única", "Intradérmica, región deltoidea derecha", "Tuberculosis meníngea y miliar");
            dataGridViewVacunacion.Rows.Add("Hepatitis B", "Nacimiento", "Primera", "Intramuscular, muslo izquierdo", "Hepatitis B");
            dataGridViewVacunacion.Rows.Add("Hexavalente acelular", "2 meses", "Primera", "Intramuscular, muslo izquierdo", "Difteria, tos ferina, tétanos, polio, hepatitis B, enfermedades por H. influenzae tipo B");
            dataGridViewVacunacion.Rows.Add("Hexavalente acelular", "4 meses", "Segunda", "Intramuscular, muslo izquierdo", "Difteria, tos ferina, tétanos, polio, hepatitis B, enfermedades por H. influenzae tipo B");
            dataGridViewVacunacion.Rows.Add("Hexavalente acelular", "6 meses", "Tercera", "Intramuscular, muslo izquierdo", "Difteria, tos ferina, tétanos, polio, hepatitis B, enfermedades por H. influenzae tipo B");
            dataGridViewVacunacion.Rows.Add("Rotavirus", "2 meses", "Primera", "Oral", "Enfermedades por rotavirus");
            dataGridViewVacunacion.Rows.Add("Rotavirus", "4 meses", "Segunda", "Oral", "Enfermedades por rotavirus");
            dataGridViewVacunacion.Rows.Add("Neumococica conjugada", "2 meses", "Primera", "=< 18 meses de edad en musculo derecho", "Neumonia, memimgitis y otras");
            dataGridViewVacunacion.Rows.Add("Neumococica conjugada", "4 meses", "Segunda", "=< 18 meses de edad en musculo derecho", "Neumonia, memimgitis y otras");
            dataGridViewVacunacion.Rows.Add("Neumococica conjugada", "12 meses", "Refuerza", "=< 18 meses de edad en musculo derecho", "Neumonia, memimgitis y otras");
            // ... Agregar el resto de las filas de la tabla
        }

        public void dataGridViewVacunacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewVacunacion.Rows.Count &&
               e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewVacunacion.Columns.Count)
            {
                var cellValue = dataGridViewVacunacion.Rows[e.RowIndex].Cells[0].Value;

                if (cellValue != null)
                {
                    string vacunaSeleccionada = cellValue.ToString();

                    // Crea una referencia al formulario principal
                    VtnCartillaVacunacion formularioPrincipal = Application.OpenForms["VtnCartillaVacunacion"] as VtnCartillaVacunacion;

                    // Asigna el valor al TextBox en el formulario principal
                    if (formularioPrincipal != null && !string.IsNullOrEmpty(vacunaSeleccionada))
                    {
                        formularioPrincipal.txtVacunaSeleccionada.Text = vacunaSeleccionada;

                        // Cierra el formulario secundario (ListaVacuna)
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("La celda seleccionada está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //MessageBox.Show("Índice de celda fuera de rango.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
