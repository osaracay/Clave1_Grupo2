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
        public int id_factura { get; set; } // Mismo para Detalle de Venta // Quitar
        public string fecha { get; set; }
        public decimal monto_total { get; set; }
        public int id_met_pago { get; set; } // Falta que sea por Id, actual se carga el nombre
        public int estado_factura { get; set; }

        // Detalle de Venta
        public int id_detalle_factura { get; set; } // Quitar
        public int id_insumo { get; set; } // Quitar
        public int q_insumo { get; set; } // Quitar
        public decimal subtotal { get; set; } // Quitar
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

        //internal bool agregarVenta(Venta mProducto)
        //{
        //    try
        //    {
        //        string INSERT = "INSERT INTO factura (fecha, monto_total, id_met_pago, estado_factura) VALUES (@fecha, @monto, @pago, @estado);";

        //        using (MySqlCommand mCommand = new MySqlCommand(INSERT, vConexion.GetConexion()))
        //        {
        //            mCommand.Parameters.Add(new MySqlParameter("@fecha", DateTime.Parse(mProducto.fecha)));
        //            mCommand.Parameters.Add(new MySqlParameter("@monto", mProducto.monto_total));
        //            mCommand.Parameters.Add(new MySqlParameter("@pago", mProducto.id_met_pago));
        //            mCommand.Parameters.Add(new MySqlParameter("@estado", mProducto.estado_factura));

        //            return mCommand.ExecuteNonQuery() > 0;
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show($"Error al guardar en la base de datos: {ex.Message}");
        //        return false;
        //    }
        //}

        // Ventana de Registro de Ventas.
        // Registra los datos de Salidas de Inventario
        // Metodo para enviar los Datos de la Lista a la Tabla Factura y Detalle
        internal bool agregarDetalleVenta(Venta mProducto, DataGridView dgvRegistros)
        {
            MySqlTransaction transaction = null;

            try
            {
                MySqlConnection connection = vConexion.GetConexion();
                transaction = connection.BeginTransaction(); // Inicia una transacción

                    // Insertar la factura
                    string INSERT_FACTURA = "INSERT INTO factura (fecha, monto_total, id_met_pago, estado_factura) " +
                                            "VALUES (@fecha, @monto, @pago, @estado);";
                MySqlCommand mCommand = new MySqlCommand(INSERT_FACTURA, connection, transaction);
                mCommand.Parameters.AddWithValue("@fecha", DateTime.Parse(mProducto.fecha));
                mCommand.Parameters.AddWithValue("@monto", mProducto.monto_total);
                mCommand.Parameters.AddWithValue("@pago", mProducto.id_met_pago);
                mCommand.Parameters.AddWithValue("@estado", mProducto.estado_factura);
                mCommand.ExecuteNonQuery();

                    // Obtener el ID de la factura insertada
                    long idFactura = mCommand.LastInsertedId;

                    // Ahora, insertar los detalles de los productos en detalle_factura
                    string INSERT_DETALLE = "INSERT INTO detalle_factura (id_factura, id_insumo, q_insumo, subtotal) " +
                                             "VALUES (@idFactura, @idInsumo, @cantidad, @subtotal);";

                    foreach (DataGridViewRow row in dgvRegistros.Rows)
                    {
                        if (row.Cells["Id"].Value != null)
                        {
                            MySqlCommand detalleCommand = new MySqlCommand(INSERT_DETALLE, connection, transaction);
                            detalleCommand.Parameters.AddWithValue("@idFactura", idFactura);
                            detalleCommand.Parameters.AddWithValue("@idInsumo", Convert.ToInt32(row.Cells["Id"].Value));
                            detalleCommand.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["cantidad"].Value));
                            detalleCommand.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(row.Cells["total"].Value));

                            detalleCommand.ExecuteNonQuery(); // Ejecutar el comando de inserción de detalles
                        }
                    }
                    transaction.Commit(); // Confirmar la transacción
                    return true;                
            }
            catch (MySqlException ex)
            {
                transaction?.Rollback(); // En caso de error, deshacer la transacción
                MessageBox.Show($"Error al guardar la venta: {ex.Message}");
                return false;
            }
            // Fin del Codigo.....
        }
        // Actualizar el Invetario de los Insumos
        internal bool ActualizarStockVenta(int idInsumo, int cantidadVendida)
        {
            string UPDATE = "UPDATE insumo SET existencias_insumo = existencias_insumo - @cantidadVendida WHERE id_insumo = @idInsumo";

            try
            {
                MySqlCommand mCommand = new MySqlCommand(UPDATE, vConexion.GetConexion());
                mCommand.Parameters.AddWithValue("@cantidadVendida", cantidadVendida);
                mCommand.Parameters.AddWithValue("@idInsumo", idInsumo);

                return mCommand.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al actualizar el inventario por venta: {ex.Message}");
                return false;
            }
        }
        // Fin de la Actualizacion

    }
}
