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
    ///<summary>
    ///Clase de Acceso a Datos de la tabla Cita
    /// </summary>
    class CitaDAO
    {        
        private static string consulta;
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lector;
        

        //Aqui ocupare una instancia de mysqlconnection porque ocupo el metodo last inserted id
        //que el driver odbc no tiene

        public static bool RegistrarCita(Cita c, CatItem tipoCita, int idReservacion)
        {
            string sentenciaSQL = "INSERT INTO cita (id_tipo_cita, " +
                "id_mascota, id_veterinario, id_estado_cita, motivo_cita, monto_pago, id_reservacion) " +
                "VALUES (?, ?, ?, ?, ?, ?, ?)";
            /*"VALUES (@nombre, @apellido, @fecha_nac, @tipo_usuario, @estado_usuario, @email, @genero, @usrlogin, @usrpw)";
             Esta forma no funciona debo usar los ? como en Java*/
            ConexionBD.GetConexionBD().Open();
            adaptador = new OdbcDataAdapter();
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.InsertCommand = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD());
            //OdbcCommand comando = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD()); El objeto OdbcComand se guarda en el Getter de adaptador InsertCommand
            //comando.Parameters.AddWithValue("@nombre", c.Nombre);

            adaptador.InsertCommand.Parameters.Add("@tipocita", OdbcType.Int).Value = c.IdTipoCita;
            adaptador.InsertCommand.Parameters.Add("@idmascota", OdbcType.Int).Value = c.IdMascota;
            adaptador.InsertCommand.Parameters.Add("@idvet", OdbcType.Int).Value = c.IdVet;
            adaptador.InsertCommand.Parameters.Add("@idestado", OdbcType.Int).Value = 1; //El estado por default es agendado 1
            adaptador.InsertCommand.Parameters.Add("@motivo", OdbcType.VarChar, 250).Value = c.MotivoCita;
            adaptador.InsertCommand.Parameters.Add("@precio", OdbcType.Decimal).Value = tipoCita.PrecioCat;//El estado del usuario cliente sera activo por default
            adaptador.InsertCommand.Parameters.Add("@idreservacion", OdbcType.Int).Value = idReservacion;
            

            //MessageBox.Show($"No se cual es el problema {adaptador.InsertCommand.CommandText}");
            try
            {
                adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Se registró su cita exitosamente");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
                return false;
            }
            finally
            {
                ConexionBD.GetConexionBD().Close();
            }
        }

        //Consultar Cita cliente si la mascota no esta seleccionada. Tomar en cuenta el estado.

        //Consultar cita por mascota. Tomar en cuenta el estado.

        //Consultar citas veterinario. Tomar en cuenta el estado.

        //Consultar citas por fecha. Tomar en cuenta el estado.

        //Reagendar cita.

        //Actualizar estado de cita.
    }
}
