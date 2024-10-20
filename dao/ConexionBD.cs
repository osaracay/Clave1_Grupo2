﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Clave1_Grupo2.dao
{
    class ConexionBD
    {
        private static OdbcConnection conexionOdbc; //recordar abrir al usar y cerrar terminar
        private static MySqlConnection conexionMySQL;
        private static String mySqlCs; // MySQL Connection String
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lectorDatos; //recordar abrir al usar y cerrar terminar

        //Pruebaaaaa hola amiguitos 

        private static DataSet c1g2db; //DataSet simboliza la base de datos en tiempo de ejecucion. 
        //c1g2db stands  for clave1_grupo2db
        public static OdbcConnection GetConexionBD()
        {            
            try
            {
                if (conexionOdbc == null)
                {
                    mySqlCs = ConfigurationManager.ConnectionStrings["Clave1_Grupo2.Properties.Settings.MySQLConnectionString"].ConnectionString;
                    //Connect to MySQL using Connector/ODBC
                    conexionOdbc = new OdbcConnection(mySqlCs);
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
                    mySqlCs = "Database = clave1_grupo2db; DataSource = localhost; User Id = root; Password =";
                    //Connect to MySQL using MySqlConnection
                    conexionMySQL = new MySqlConnection(mySqlCs);
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
    }
}
