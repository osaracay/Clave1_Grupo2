using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace Clave1_Grupo2.dao
{
    class ConexionBD
    {
        private static OdbcConnection conexionMySQL; //recordar abrir al usar y cerrar terminar
        private static String mySqlCs; // MySQL Connection String
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lectorDatos; //recordar abrir al usar y cerrar terminar

        private static DataSet c1g2db; //DataSet simboliza la base de datos en tiempo de ejecucion. 
        //c1g2db stands  for clave1_grupo2db
        public static OdbcConnection GetConexionBD()
        {            
            try
            {
                if (conexionMySQL == null)
                {
                    mySqlCs = ConfigurationManager.ConnectionStrings["Clave1_Grupo2.Properties.Settings.MySQLConnectionString"].ConnectionString;
                    //Connect to MySQL using Connector/ODBC
                    conexionMySQL = new OdbcConnection(mySqlCs);
                    MessageBox.Show($"Se creo 1 objeto conexion \nConn String: {mySqlCs}");
                }
            }            
            catch (OdbcException e)
            {
                MessageBox.Show("Error al conectar: \n" + e.StackTrace);
            }
            return conexionMySQL;
        }
    }
}
