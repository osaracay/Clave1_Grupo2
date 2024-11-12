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
            dataGridViewVacunacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewVacunacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVacunacion.MultiSelect = false;
            dataGridViewVacunacion.AllowUserToAddRows = false;

            // Agregar columnas
            dataGridViewVacunacion.Columns.Add("Vacuna", "Vacuna");
            dataGridViewVacunacion.Columns.Add("Descripción", "Descripción");
            dataGridViewVacunacion.Columns.Add("Edad", "Edad");
            dataGridViewVacunacion.Columns.Add("Dosis", "Dosis");

            // Agregar filas con los datos de la cartilla de vacunación
            dataGridViewVacunacion.Rows.Add("Vacuna Antirrábica", "Previene la rabia", "3 meses", "Anual");
            dataGridViewVacunacion.Rows.Add("Vacuna Parvovirus", "Protege contra el parvovirus", "6-8 semanas", "Cada 3 años");
            dataGridViewVacunacion.Rows.Add("Vacuna Moquillo", "Protege contra el moquillo", "6-8 semanas", "Cada 3 años");
            dataGridViewVacunacion.Rows.Add("Vacuna Leptospirosis", "Previene infecciones por leptospiras", "8-9 semanas", "Anual");
            dataGridViewVacunacion.Rows.Add("Vacuna Bordetella", "Previene la 'tos de las perreras'", "8-12 semanas", "Cada 6 meses o anual");
            dataGridViewVacunacion.Rows.Add("Vacuna Hepatitis", "Protege contra la hepatitis infecciosa canina", "6-8 semanas", "Cada 3 años");
            dataGridViewVacunacion.Rows.Add("Vacuna Coronavirus", "Previene infecciones por coronavirus en cachorros", "6-8 semanas", "Anual");
            dataGridViewVacunacion.Rows.Add("Vacuna contra Lyme", "Protege contra la enfermedad de Lyme", "12 semanas", "Anual");
            dataGridViewVacunacion.Rows.Add("Vacuna Gripe Canina", "Previene contra el virus de la gripe canina", "12 semanas", "Anual");
            dataGridViewVacunacion.Rows.Add("Vacuna Leucemia Felina", "Protege contra el virus de leucemia felina", "8 semanas (en gatos)", "Anual");
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
