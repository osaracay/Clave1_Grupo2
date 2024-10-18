using Clave1_Grupo2.dao;
using MySql.Data.MySqlClient;
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
    public partial class VtnConsultaVenta : Form
    {
        private string connectionString;

        public VtnConsultaVenta()
        {
            InitializeComponent();
            ConfigurarDGV();
        }
        private void ConfigurarDGV()
        {
            dgvRegistros.Columns.Clear();
            dgvRegistros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRegistros.DefaultCellStyle.SelectionBackColor = Color.Aquamarine;
            dgvRegistros.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvRegistros.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular);
            dgvRegistros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            txtFechaIni.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtFechaFin.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void FormatearColumnas(DataGridView dgv)
        {
            // Formatear las columnas numéricas
            dgv.Columns["Cantidad"].DefaultCellStyle.Format = "N0";  // Formato numérico con 2 decimales
            dgv.Columns["Total"].DefaultCellStyle.Format = "F2"; // Formato numérico con 2 decimales

            // Cambiar los títulos de las columnas
            dgv.Columns["ID"].HeaderText = "ID";
            dgv.Columns["Fecha"].HeaderText = "Fecha";
            dgv.Columns["Codigo"].HeaderText = "Codigo";
            dgv.Columns["Nombre Insumo"].HeaderText = "Nombre Insumo";
            dgv.Columns["Medida"].HeaderText = "Medida";
            dgv.Columns["Cantidad"].HeaderText = "Cantidad";
            dgv.Columns["Total"].HeaderText = "Total";
            dgv.Columns["Pago"].HeaderText = "Pago";
            dgv.Columns["Condicion"].HeaderText = "Condicion";

            // Establecer el ancho de las columnas
            dgv.Columns["ID"].Width = 60;      // Ancho para ID Factura
            dgv.Columns["Fecha"].Width = 100;          // Ancho para Fecha
            dgv.Columns["Codigo"].Width = 80;       // Ancho para ID Insumo
            dgv.Columns["Nombre Insumo"].Width = 300;  // Ancho para Nombre Insumo
            dgv.Columns["Medida"].Width = 80;         // Ancho para Medida
            dgv.Columns["Cantidad"].Width = 90;        // Ancho para Cantidad
            dgv.Columns["Total"].Width = 110;   // Ancho para Total Insumo
            dgv.Columns["Pago"].Width = 70;  // Ancho para Forma de Pago
            dgv.Columns["Condicion"].Width = 70;      // Ancho para Condición
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                DateTime fechaI = DateTime.Parse(txtFechaIni.Text);
                DateTime fechaF = DateTime.Parse(txtFechaFin.Text);

                string query = @"
                                SELECT 
                                f.id_factura AS 'ID',
                                f.fecha AS 'Fecha',
                                d.id_insumo AS 'Codigo',
                                i.nom_insumo AS 'Nombre Insumo',
                                i.unit_medida AS 'Medida',
                                d.q_insumo AS 'Cantidad',
                                d.subtotal AS 'Total',
                                f.id_met_pago AS 'Pago',
                                f.estado_factura AS 'Condicion'
                                FROM 
                                    factura f
                                JOIN 
                                    detalle_factura d ON f.id_factura = d.id_factura
                                JOIN 
                                    insumo i ON d.id_insumo = i.id_insumo
                                WHERE 
                                    f.fecha BETWEEN @fechaI AND @fechaF;";
                try
                {
                    using (MySqlConnection conn = new ConexionMysql().GetConexion())
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@fechaI", fechaI);
                            cmd.Parameters.AddWithValue("@fechaF", fechaF);

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt); // Verificar si el error ocurre, con la conexion

                                dgvRegistros.DataSource = dt;

                                // Aplicar formato, cambiar títulos y ajustar ancho de columnas
                                FormatearColumnas(dgvRegistros);

                                // Calcular el total de ventas
                                decimal totalVentas = dt.AsEnumerable().Sum(row => row.Field<decimal>("Total"));
                                txtTotalVnt.Text = totalVentas.ToString("F2");

                                // Mostrar número de registros
                                txtRegistros.Text = dt.Rows.Count.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al buscar los registros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
