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
        private static List<Cita> citas;

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
        //Consultar citas veterinario. Tomar en cuenta el estado.        
        public static List<Cita> GetCitas(Usuario user)
        {
            if(user.TipoUsuario == 3)
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado, m.id_propietario " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE m.id_propietario = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
            }
            else if(user.TipoUsuario == 2)
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado, m.id_propietario " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE c.id_veterinario = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
            }
            else if (user.TipoUsuario == 1)
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado, m.id_propietario " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE m.id_propietario <> ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
                // O sea, que seleccione todos. Usuarios admin no se les asignan mascotas
            }
            
            adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
            adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = user.IdUsuario;
            //adaptador.SelectCommand.Parameters.Add("@dia reservacion", OdbcType.VarChar).Value = fechacon;
            //adaptador.SelectCommand.Parameters.Add("@dia reservacion2", OdbcType.Date).Value = fechacon.AddDays(1);
            if (citas == null)
            {
                citas = new List<Cita>();
            }
            else
            {
                citas.Clear();
            }
            try
            {               
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                while (lector.Read())
                {
                    Cita cita = new Cita();
                    cita.IdCita = lector.GetInt32(0);
                    cita.IdTipoCita = lector.GetInt32(1);
                    cita.IdMascota = lector.GetInt32(2);
                    cita.IdVet = lector.GetInt32(3);
                    cita.IdEstadoCita= lector.GetInt32(4);
                    cita.MotivoCita = lector.GetString(5);
                    
                    //cita.SintomasMascota = lector.GetString(6); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.Diagnostico = lector.GetString(7); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.Tratamiento = lector.GetString(8); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.Observaciones = lector.GetString(9); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.MontoPago = lector.GetDecimal(10); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.FechaPago = lector.GetDate(11);
                    //cita.IdMetPago = lector.GetInt32(12); 
                    //cita.IdEstadoPago = lector.GetInt32(13);

                    Cupo reservacion = new Cupo();
                    reservacion.IdReservacion = lector.GetInt32(14);
                    reservacion.IdVetAsignado = lector.GetInt32(15);
                    reservacion.FechaCupo = lector.GetDate(16);
                    reservacion.HoraInicio = lector.GetDateTime(17);
                    reservacion.HoraFin = lector.GetDateTime(18);
                    reservacion.EstaReservado = lector.GetBoolean(19);

                    cita.IdPropietario = lector.GetInt32(20);
                    cita.Cupo = reservacion;
                    citas.Add(cita);
                }

                //MessageBox.Show(fechacon.Date+consulta +adaptador.SelectCommand.CommandText);
                MessageBox.Show($"151 Cantidad de reservaciones {citas.Count()}");
                ConexionBD.GetConexionBD().Close();
                /*En ciertos casos no se instancia el lector y queda nulo,
                 recien luego de abrir la conexion, y en el catch no se cierra la conexion
                y no se si deba cerrarla. Creo que si porque igual no recorre el bucle while*/

                return citas;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"NullRefEx: {ex.Message}\n{ex.StackTrace}");
                return citas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ex: {ex.Message}\n{ex.StackTrace}");
                return citas;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();                
            }            
        }

        //Consultar cita por mascota. Tomar en cuenta el estado.
        public static List<Cita> GetCitas(Mascota mascota)
        {
            consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado, m.id_propietario " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE c.id_mascota = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
            //MODIFICAR
            /*
            if (user.TipoUsuario == 3)
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE c.id_mascota = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
            }
            else if (user.TipoUsuario == 2)
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE c.id_mascota = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
            }
            else
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE c.id_mascota = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
                // O sea, que seleccione todos. Usuarios admin no se les asignan mascotas
            }
            */
            adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
            adaptador.SelectCommand.Parameters.Add("@id_mascota", OdbcType.Int).Value = mascota.IdMascota;
            //adaptador.SelectCommand.Parameters.Add("@dia reservacion", OdbcType.VarChar).Value = fechacon;
            //adaptador.SelectCommand.Parameters.Add("@dia reservacion2", OdbcType.Date).Value = fechacon.AddDays(1);
            if (citas == null)
            {
                citas = new List<Cita>();
            }
            else
            {
                citas.Clear();
            }
            try
            {
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                while (lector.Read())
                {
                    Cita cita = new Cita();
                    cita.IdCita = lector.GetInt32(0);
                    cita.IdTipoCita = lector.GetInt32(1);
                    cita.IdMascota = lector.GetInt32(2);
                    cita.IdVet = lector.GetInt32(3);
                    cita.IdEstadoCita = lector.GetInt32(4);
                    cita.MotivoCita = lector.GetString(5);
                    //cita.SintomasMascota = lector.GetString(6); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.Diagnostico = lector.GetString(7); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.Tratamiento = lector.GetString(8); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.Observaciones = lector.GetString(9); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.MontoPago = lector.GetDecimal(10); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.FechaPago = lector.GetDate(11);
                    //cita.IdMetPago = lector.GetInt32(12); 
                    //cita.IdEstadoPago = lector.GetInt32(13);

                    Cupo reservacion = new Cupo();
                    reservacion.IdReservacion = lector.GetInt32(14);
                    reservacion.IdVetAsignado = lector.GetInt32(15);
                    reservacion.FechaCupo = lector.GetDate(16);
                    reservacion.HoraInicio = lector.GetDateTime(17);
                    reservacion.HoraFin = lector.GetDateTime(18);
                    reservacion.EstaReservado = lector.GetBoolean(19);
                    cita.IdPropietario = lector.GetInt32(20);
                    cita.Cupo = reservacion;
                    citas.Add(cita);
                }

                //MessageBox.Show(fechacon.Date+consulta +adaptador.SelectCommand.CommandText);
                MessageBox.Show($"277 Cantidad de reservaciones {citas.Count()}");
                ConexionBD.GetConexionBD().Close();
                /*En ciertos casos no se instancia el lector y queda nulo,
                 recien luego de abrir la conexion, y en el catch no se cierra la conexion
                y no se si deba cerrarla. Creo que si porque igual no recorre el bucle while*/

                return citas;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"NullRefEx: {ex.Message}\n{ex.StackTrace}");
                return citas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ex: {ex.Message}\n{ex.StackTrace}");
                return citas;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }

        //Consultar citas por fecha. Tomar en cuenta el estado.
        public static List<Cita> GetCitas(DateTime fecha)
        {
            consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado, m.id_propietario " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE dr.dia_reservacion = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
            //MODIFICAR
            /*
            if (user.TipoUsuario == 3)
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE c.id_mascota = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
            }
            else if (user.TipoUsuario == 2)
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE c.id_mascota = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
            }
            else
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE c.id_mascota = ? AND dr.reservado= TRUE " +
                    "ORDER BY dr.h_ini ASC";
                // O sea, que seleccione todos. Usuarios admin no se les asignan mascotas
            }
            */
            adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
            adaptador.SelectCommand.Parameters.Add("@fecha", OdbcType.Date).Value = fecha.Date;
            //adaptador.SelectCommand.Parameters.Add("@dia reservacion", OdbcType.VarChar).Value = fechacon;
            //adaptador.SelectCommand.Parameters.Add("@dia reservacion2", OdbcType.Date).Value = fechacon.AddDays(1);
            if (citas == null)
            {
                citas = new List<Cita>();
            }
            else
            {
                citas.Clear();
            }
            try
            {
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                while (lector.Read())
                {
                    Cita cita = new Cita();
                    cita.IdCita = lector.GetInt32(0);
                    cita.IdTipoCita = lector.GetInt32(1);
                    cita.IdMascota = lector.GetInt32(2);
                    cita.IdVet = lector.GetInt32(3);
                    cita.IdEstadoCita = lector.GetInt32(4);
                    cita.MotivoCita = lector.GetString(5);
                    //cita.SintomasMascota = lector.GetString(6); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.Diagnostico = lector.GetString(7); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.Tratamiento = lector.GetString(8); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.Observaciones = lector.GetString(9); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.MontoPago = lector.GetDecimal(10); //Si esto es nulo da excepcion y me saca del bucle
                    //cita.FechaPago = lector.GetDate(11);
                    //cita.IdMetPago = lector.GetInt32(12); 
                    //cita.IdEstadoPago = lector.GetInt32(13);

                    Cupo reservacion = new Cupo();
                    reservacion.IdReservacion = lector.GetInt32(14);
                    reservacion.IdVetAsignado = lector.GetInt32(15);
                    reservacion.FechaCupo = lector.GetDate(16);
                    reservacion.HoraInicio = lector.GetDateTime(17);
                    reservacion.HoraFin = lector.GetDateTime(18);
                    reservacion.EstaReservado = lector.GetBoolean(19);
                    cita.IdPropietario = lector.GetInt32(20);
                    cita.Cupo = reservacion;
                    citas.Add(cita);
                }

                //MessageBox.Show(fechacon.Date+consulta +adaptador.SelectCommand.CommandText);
                MessageBox.Show($"277 Cantidad de reservaciones {citas.Count()}");
                ConexionBD.GetConexionBD().Close();
                /*En ciertos casos no se instancia el lector y queda nulo,
                 recien luego de abrir la conexion, y en el catch no se cierra la conexion
                y no se si deba cerrarla. Creo que si porque igual no recorre el bucle while*/

                return citas;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"NullRefEx: {ex.Message}\n{ex.StackTrace}");
                return citas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ex: {ex.Message}\n{ex.StackTrace}");
                return citas;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }
        //Reagendar cita.

        //Actualizar estado de cita.
    }
}
