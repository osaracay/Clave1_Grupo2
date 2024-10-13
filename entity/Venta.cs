using Clave1_Grupo2.dao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.entity
{
    class Venta
    {
        // Venta
        public int id_factura { get; set; } // Mismo para Detalle de Venta
        public string fecha { get; set; }
        public decimal monto_total { get; set; }
        public string id_met_pago { get; set; } // Falta que sea por Id, actual se carga el nombre
        public string estado_factura { get; set; }

        // Detalle de Venta
        public int id_detalle_factura { get; set; }
        public int id_insumo { get; set; }
        public int q_insumo { get; set; }
        public decimal subtotal { get; set; }
    }
    class ConsultaVenta
    {
        private ConexionMysql vConexion;
        private List<Venta> vInsumo;

        public ConsultaVenta()
        {
            vConexion = new ConexionMysql();
            vInsumo = new List<Venta>();
        }

        // Ventana de Registro de Ventas.
        // Registrar los datos de Salidas de Inventario

        internal bool agregarVenta(Venta mProducto)
        {
            try
            {
                string INSERT = "INSERT INTO factura (fecha, monto_total, id_met_pago, estado_factura) VALUES (@fecha, @monto, @pago, @estado);";

                using (MySqlCommand mCommand = new MySqlCommand(INSERT, vConexion.GetConexion()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@fecha", DateTime.Parse(mProducto.fecha)));
                    mCommand.Parameters.Add(new MySqlParameter("@monto", mProducto.monto_total));
                    mCommand.Parameters.Add(new MySqlParameter("@pago", mProducto.id_met_pago));
                    mCommand.Parameters.Add(new MySqlParameter("@estado", mProducto.estado_factura));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar en la base de datos: {ex.Message}");
                return false;
            }
        }



    }
}
