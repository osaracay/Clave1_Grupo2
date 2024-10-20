using Clave1_Grupo2.dao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.entity
{
    class Compra
    {
        public string fecha { get; set; }
        public string nombre { get; set; }
        public int id_insumo { get; set; }
        public string nom_insumo { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public int stock_final { get; set; }
        public string condicion { get; set; }
        public string tipo { get; set; }
    }

    class ConsultaCompra
    {
        private ConexionMysql cConexion;
        private List<Compra> cInsumo;

        public ConsultaCompra()
        {
            cConexion = new ConexionMysql();
            cInsumo = new List<Compra>();
        }

        // Ventana de Registro de Compras.
        // Registrar los datos de Ingreso a Inventario
        internal bool agregarCompra(Compra mProducto)
        {
            try
            {
                string INSERT = "INSERT INTO detalle_compra (fecha, nombre, id_insumo, nom_insumo, precio, cantidad, stock_final, condicion, tipo) VALUES (@fecha, @nombre, @id, @insumo, @precio, @cantidad, @stock, @condicion, @tipo);";

                using (MySqlCommand mCommand = new MySqlCommand(INSERT, cConexion.GetConexion()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@fecha", DateTime.Parse(mProducto.fecha)));
                    mCommand.Parameters.Add(new MySqlParameter("@nombre", mProducto.nombre));
                    mCommand.Parameters.Add(new MySqlParameter("@id", mProducto.id_insumo));
                    mCommand.Parameters.Add(new MySqlParameter("@insumo", mProducto.nom_insumo));
                    mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio));
                    mCommand.Parameters.Add(new MySqlParameter("@cantidad", mProducto.cantidad));
                    mCommand.Parameters.Add(new MySqlParameter("@stock", mProducto.stock_final));
                    mCommand.Parameters.Add(new MySqlParameter("@condicion", mProducto.condicion));
                    mCommand.Parameters.Add(new MySqlParameter("@tipo", mProducto.tipo));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar en la base de datos: {ex.Message}");
                return false;
            }
        }

        // Actualizar el Inventario de los Insumos
        internal bool ActualizarStockCompra(int idInsumo, int cantidadComprada)
        {
            string UPDATE = "UPDATE insumo SET existencias_insumo = existencias_insumo + @cantidadComprada WHERE id_insumo = @idInsumo";

            try
            {
                MySqlCommand mCommand = new MySqlCommand(UPDATE, cConexion.GetConexion());
                mCommand.Parameters.AddWithValue("@cantidadComprada", cantidadComprada);
                mCommand.Parameters.AddWithValue("@idInsumo", idInsumo);

                return mCommand.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al actualizar el inventario por compra: {ex.Message}");
                return false;
            }
        }
       
    }
}

