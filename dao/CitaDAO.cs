using Clave1_Grupo2.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.dao
{
    class CitaDAO
    {        
        private static string consulta;
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lector;
        ///<summary>
        ///Clase de Acceso a Datos de la tabla Cita
        /// </summary>

        //Aqui ocupare una instancia de mysqlconnection porque ocupo el metodo last inserted id
        //que el driver odbc no tiene
        
    }
}
