using MySql.Data.MySqlClient;
//using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.dao
{
    class CatListas
    {
        private ConexionMysql conexionMysql;

        public CatListas()
        {
            conexionMysql = new ConexionMysql();
        }

        public DataTable GetTipoInsumos()
        {
            DataTable dtInsumos = new DataTable();
            string QUERY = "SELECT id_tipo_insumo, nom_tipo_insumo FROM cat_tipo_insumo";

            try
            {
                MySqlCommand cmd = new MySqlCommand(QUERY, conexionMysql.GetConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtInsumos);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al obtener los insumos: {ex.Message}");
            }

            return dtInsumos;
        }
    }
}
