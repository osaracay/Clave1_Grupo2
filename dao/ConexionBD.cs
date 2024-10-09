using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Configuration;

namespace Clave1_Grupo2.dao
{
    class ConexionBD
    {
        private OdbcConnection conexionMySQL;
        private String mySqlCs;
        public OdbcConnection GetConexionBD()
        {
            mySqlCs = ConfigurationManager.ConnectionStrings["Clave1_Grupo2.Properties.Settings.MySQLConnectionString"].ConnectionString;
            //Connect to MySQL using Connector/ODBC
            if (conexionMySQL == null)
            {
                conexionMySQL = new OdbcConnection(mySqlCs);
            }
            return conexionMySQL;
        }
    }
}
