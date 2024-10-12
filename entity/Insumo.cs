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
    class Insumo
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

    class ConsultaInsumo
    {
        private ConexionMysql mConexion;
        private List<Insumo> mProductos;

        public ConsultaInsumo()
        {
            mConexion = new ConexionMysql();
            mProductos = new List<Insumo>();
        }

        public List<Insumo> getProductos(string filtro)
        {
            string QUERY = "SELECT * FROM insumo ";
            MySqlDataReader mReadaer = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "id_insumo LIKE '%" + filtro + "%' OR " +
                        "nom_insumo LIKE '%" + filtro + "%' OR " +
                        "id_tipo_insumo LIKE '%" + filtro + "%' OR " +
                        "precio_unit LIKE '%" + filtro + "%' OR " +
                        "unit_medida LIKE '%" + filtro + "%' OR " +
                        "existencias_insumo LIKE '%" + filtro + "%' OR " +
                        "punto_reorden_insumo LIKE '%" + filtro + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = mConexion.GetConexion();
                mReadaer = mComando.ExecuteReader();

                Insumo mProducto = null;
                while (mReadaer.Read())
                {
                    mProducto = new Insumo();
                    mProducto.id_insumo = mReadaer.GetInt16("id_insumo");
                    mProducto.nom_insumo = mReadaer.GetString("nom_insumo");
                    mProducto.id_tipo_insumo = mReadaer.GetInt16("id_tipo_insumo");
                    mProducto.precio_unit = mReadaer.GetInt16("precio_unit");
                    mProducto.unit_medida = mReadaer.GetString("unit_medida");
                    mProducto.existencias_insumo = mReadaer.GetInt16("existencias_insumo");
                    mProducto.punto_reorden_insumo = mReadaer.GetInt16("punto_reorden_insumo");
                    mProductos.Add(mProducto);

                }
                mReadaer.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mProductos;
        }
        // Registrar los items a la Tabla de Insumos
        internal bool agregarProducto(Insumo mProducto)
        {
            try
            {
                string INSERT = "INSERT INTO insumo (nom_insumo, id_tipo_insumo, desc_insumo, precio_unit, unit_medida, existencias_insumo, punto_reorden_insumo) VALUES (@nombre, @tipo, @descrip, @precio, @medida, @cantidad, @stockm);";

                using (MySqlCommand mCommand = new MySqlCommand(INSERT, mConexion.GetConexion()))
                {
                    mCommand.Parameters.Add(new MySqlParameter("@nombre", mProducto.nom_insumo));
                    mCommand.Parameters.Add(new MySqlParameter("@tipo", mProducto.id_tipo_insumo));
                    mCommand.Parameters.Add(new MySqlParameter("@descrip", mProducto.desc_insumo));
                    mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio_unit));
                    mCommand.Parameters.Add(new MySqlParameter("@medida", mProducto.unit_medida));
                    mCommand.Parameters.Add(new MySqlParameter("@cantidad", mProducto.existencias_insumo));
                    mCommand.Parameters.Add(new MySqlParameter("@stockm", mProducto.punto_reorden_insumo));

                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar en la base de datos: {ex.Message}");
                return false;
            }
        }
        // Modificar los items en la Tabla de Insumos
        internal bool ActualizarProducto(Insumo mProducto)
        {
            string UPDATE = " UPDATE insumo " +
                "SET nom_insumo = @nombre, " +
                " id_tipo_insumo = @tipo, " +
                " desc_insumo = @descrip, " +
                " precio_unit = @precio, " +
                " unit_medida = @medida, " +
                " existencias_insumo = @cantidad, " +
                " punto_reorden_insumo = @stockm " +
                " WHERE id_insumo = @id"; // Asegúrate de tener el WHERE correcto

            try
            {
                MySqlCommand mCommand = new MySqlCommand(UPDATE, mConexion.GetConexion());

                mCommand.Parameters.Add(new MySqlParameter("@nombre", mProducto.nom_insumo));
                mCommand.Parameters.Add(new MySqlParameter("@tipo", mProducto.id_tipo_insumo));
                mCommand.Parameters.Add(new MySqlParameter("@descrip", mProducto.desc_insumo));
                mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio_unit));
                mCommand.Parameters.Add(new MySqlParameter("@medida", mProducto.unit_medida));
                mCommand.Parameters.Add(new MySqlParameter("@cantidad", mProducto.existencias_insumo));
                mCommand.Parameters.Add(new MySqlParameter("@stockm", mProducto.punto_reorden_insumo));
                mCommand.Parameters.Add(new MySqlParameter("@id", mProducto.id_insumo)); // Aquí añades el parámetro del ID

                return mCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Eliminar items en la Tabla de Insumos
        internal bool eliminarProducto(int id)
        {
            string DELETE = "DELETE FROM insumo WHERE id_insumo = @id";

            try
            {
                MySqlCommand mCommand = new MySqlCommand(DELETE, mConexion.GetConexion());
                mCommand.Parameters.Add(new MySqlParameter("@id", id));

                return mCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

