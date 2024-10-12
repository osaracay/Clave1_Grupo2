using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.dao
{
    class conexion
    {
        protected string server = "localhost";
        protected string database = "clave1_grupo2";
        protected string user = "root";
        protected string password = "";
    }
    class ConexionMysql : conexion
    {
        protected new string server = "localhost";
        protected new string database = "clave1_grupo2";
        protected new string user = "root";
        protected new string password = "";

        private MySqlConnection conexion;
        private string cadenaConexion;
        public ConexionMysql()
        {
            cadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id= " + user +
                "; Password=" + password;

            conexion = new MySqlConnection(cadenaConexion);
        }
        public MySqlConnection GetConexion()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return conexion;
        }
        public void CloseConexion()
        {
            conexion.Clone();
        }
    }
}
