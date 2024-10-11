using Clave1_Grupo2.dao;
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
    class Producto
    {
        public int id_insumo { get; set; }
        public string nom_insumo { get; set; }
        public int id_tipo_insumo { get; set; }
        public string desc_insumo { get; set; }
        public decimal precio_unit { get; set; }
        public string unit_medida { get; set; }
        public int existencias_insumo { get; set; }
        public int punto_reorden_insumo { get; set; }
    }
    class Insumo
    {
        private OdbcConnection conexionMySQL;
        private List<Producto> mProductos;

        public Insumo()
        {
            conexionMySQL = ConexionBD.GetConexionBD();
            mProductos = new List<Producto>();
        }
        public List<Producto> getProductos(string filtro)
        {
            string QUERY = "SELECT * FROM insumo ";
            OdbcDataReader mReader = null;

            try
            {
                if (conexionMySQL.State == ConnectionState.Closed)
                {
                    conexionMySQL.Open(); // Ensure the connection is open
                }

                if (!string.IsNullOrEmpty(filtro))
                {
                    QUERY += " WHERE id_insumo LIKE '%" + filtro + "%' OR nom_insumo LIKE '%" + filtro + "%'";
                }

                OdbcCommand mComando = new OdbcCommand(QUERY, conexionMySQL);
                mReader = mComando.ExecuteReader();

                List<Producto> productos = new List<Producto>();
                while (mReader.Read())
                {
                    Producto mProducto = new Producto
                    {
                        id_insumo = Convert.ToInt16(mReader["id_insumo"]),
                        //nom_insumo = mReader.GetString("nom_insumo"),
                        nom_insumo = mReader.GetString(mReader.GetOrdinal("nom_insumo")),
                        id_tipo_insumo = Convert.ToInt16(mReader["id_tipo_insumo"]),
                        precio_unit = Convert.ToDecimal(mReader["precio_unit"]),
                        //unit_medida = mReader.GetString("unit_medida"),
                        unit_medida = mReader.GetString(mReader.GetOrdinal("unit_medida")),
                        existencias_insumo = Convert.ToInt16(mReader["existencias_insumo"]),
                        punto_reorden_insumo = Convert.ToInt16(mReader["punto_reorden_insumo"])
                    };
                    productos.Add(mProducto);
                }

                return productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los Registros: " + ex.Message);
                return null;
            }
            finally
            {
                if (mReader != null && !mReader.IsClosed)
                {
                    mReader.Close(); // Siempre cerrar el reader dspues de usar
                }

                if (conexionMySQL.State == ConnectionState.Open)
                {
                    conexionMySQL.Close(); // Siempre cerrar la conexion despues de usar..
                }
            }
        }
         internal bool agregarProducto(Producto mProducto)
        {
            string QUERY = "INSERT INTO insumo (nom_insumo, id_tipo_insumo, desc_insumo, precio_unit, unit_medida, existencias_insumo, punto_reorden_insumo) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?)";

            try
            {
                // Asegurarse de que la conexión esté abierta
                if (conexionMySQL.State == ConnectionState.Closed)
                {
                    conexionMySQL.Open();
                }

                using (OdbcCommand mCommand = new OdbcCommand(QUERY, conexionMySQL))
                {
                    // Agregar parámetros para evitar inyección SQL
                    mCommand.Parameters.AddWithValue("@nom_insumo", mProducto.nom_insumo);
                    mCommand.Parameters.AddWithValue("@id_tipo_insumo", mProducto.id_tipo_insumo);
                    mCommand.Parameters.AddWithValue("@desc_insumo", mProducto.desc_insumo);
                    mCommand.Parameters.AddWithValue("@precio_unit", mProducto.precio_unit);
                    mCommand.Parameters.AddWithValue("@unit_medida", mProducto.unit_medida);
                    mCommand.Parameters.AddWithValue("@existencias_insumo", mProducto.existencias_insumo);
                    mCommand.Parameters.AddWithValue("@punto_reorden_insumo", mProducto.punto_reorden_insumo);

                    // Ejecutar la consulta
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
                return false;
            }
            finally
            {
                // Asegurarse de que la conexión se cierre correctamente
                if (conexionMySQL.State == ConnectionState.Open)
                {
                    conexionMySQL.Close();
                }
            }
        }
    }
}

