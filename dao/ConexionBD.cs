using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace Clave1_Grupo2.dao
{
    class ConexionBD
    {
        private static OdbcConnection conexionOdbc; //recordar abrir al usar y cerrar terminar
        private static MySqlConnection conexionMySQL;
        //private static string mySqlCs; // MySQL Connection String

        private static string odbcCs;
        private static string mySqliCs;

        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lectorDatos; //recordar abrir al usar y cerrar terminar

        //Pruebaaaaa hola amiguitos 

        private static DataSet c1g2db; //DataSet simboliza la base de datos en tiempo de ejecucion. 

        public static string MySqliCs { get => mySqliCs; set => mySqliCs = value; }

        //c1g2db stands  for clave1_grupo2db
        public static OdbcConnection GetConexionBD()
        {            
            try
            {
                if (conexionOdbc == null)
                {
                    //odbcCs = ConfigurationManager.ConnectionStrings["Clave1_Grupo2.Properties.Settings.MySQLConnectionString"].ConnectionString;

                    //Alternativa en linea 
                    //Connect to MySQL using Connector/ODBC
                    conexionOdbc = new OdbcConnection(odbcCs);
                    //MessageBox.Show($"Se creo 1 objeto conexion");
                    // \nConn String: { mySqlCs}
                }
            }            
            catch (OdbcException e)
            {
                MessageBox.Show("Error al conectar: \n" + e.StackTrace);
            }
            return conexionOdbc;
        }
        public static MySqlConnection GetConexionMySQL()
        { 
            //Este ocupare para obtener el last inserted id
            //a la hora de reservar un cupo y asignar el id
            //a una cita por registrar
            try
            {
                if (conexionMySQL == null)
                {
                    //mySqliCs = "Database = clave1_grupo2db; DataSource = localhost; User Id = root; Password =";
                    //Connect to MySQL using MySqlConnection
                    conexionMySQL = new MySqlConnection(MySqliCs);
                    MessageBox.Show($"Se creo 1 objeto conexion MySQL");
                    // \nConn String: { mySqlCs}
                }
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error al conectar: \n" + e.StackTrace);
            }
            return conexionMySQL;
        }

        public static DataSet GetDataSetBD()
        {
            if (c1g2db == null)
            {
                c1g2db = new DataSet();
                //MessageBox.Show("se creo la bd para tiempo de ejecucion");
            }
            return c1g2db;
        }
        /// <summary>
        /// Devuelve el conection string 
        /// </summary>
        /// <param name="opcion">Enum para seleccionar el tipo de conexion (local o en linea)</param>
        /// <returns>La cadena de conexión</returns>
        private static string EscogerConexion(MetodoConexion opcion)
        {

            switch (opcion)
            {
                case MetodoConexion.localodbc:
                    return ConfigurationManager.ConnectionStrings["Clave1_Grupo2.Properties.Settings.MySQLConnectionString"].ConnectionString;
                case MetodoConexion.localmysqli:
                    return "Database = clave1_grupo2db; DataSource = localhost; User Id = root; Password =";

                case MetodoConexion.azureodbc:
                    return ConfigurationManager.ConnectionStrings["Clave1_Grupo2.Properties.Settings.ConnectionString"].ConnectionString; //;SslMode=Required;SslCa='../assets/DigiCertGlobalRootCA.crt.pem'
                case MetodoConexion.azuremysqli:
                    return "Database = clave1_grupo2db; DataSource = uescs24014.mysql.database.azure.com; User Id = cs24014; Password =PrN115*FiaUes"; //;SslMode=Required;SslCa='../assets/DigiCertGlobalRootCA.crt.pem'
                default:
                    return "Database = clave1_grupo2db; DataSource = localhost; User Id = root; Password =";
            }
        }
        public static void SeleccionarTipoConexion()
        {
            if (String.IsNullOrEmpty(odbcCs) || String.IsNullOrEmpty(MySqliCs))
            {
                int seleccion;
                do
                {
                    try
                    {
                        seleccion = int.Parse(Interaction.InputBox("Escoja el método de conexion (1 o 2):\n1 - local (requiere driver odbc 8.0\n2 - en linea azure"));
                    }
                    catch (Exception)
                    {
                        seleccion = 0;
                    }


                } while (seleccion > 2 || seleccion < 1);
                if (seleccion == 1)
                {
                    odbcCs = EscogerConexion(MetodoConexion.localodbc);
                    mySqliCs = EscogerConexion(MetodoConexion.localmysqli);
                }
                else
                {
                    odbcCs = EscogerConexion(MetodoConexion.azureodbc);
                    MySqliCs = EscogerConexion(MetodoConexion.azuremysqli);
                }
            }                     
        }
    }
    public enum MetodoConexion
    {
        localodbc, localmysqli,azureodbc,azuremysqli
    }
}


