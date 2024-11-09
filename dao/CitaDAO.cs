using Clave1_Grupo2.entity;
using MySql.Data.MySqlClient;
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

        public static MySqlCommand ComandoSQL { get; private set; }

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
        public static List<Cita> GetCitas(Usuario user, DateTime fecha)
        {
            if (user.TipoUsuario == 3)
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado, m.id_propietario " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE m.id_propietario = ? AND dr.reservado= 1 AND dr.dia_reservacion = ? " +
                    "ORDER BY dr.h_ini ASC";
            }
            else if (user.TipoUsuario == 2)
            {
                consulta = "SELECT c.id_cita, c.id_tipo_cita, c.id_mascota, c.id_veterinario, " +
                    "c.id_estado_cita, c.motivo_cita, c.sintomas_mascota, c.diagnostico, c.tratamiento, " +
                    "c.observaciones, c.monto_pago, c.fecha_pago, c.id_met_pago, c.id_estado_pago, " +
                    "c.id_reservacion, dr.id_vet, dr.dia_reservacion, dr.h_ini, dr.h_fin, dr.reservado, m.id_propietario " +
                    "FROM cita c JOIN detalle_reservacion dr ON c.id_reservacion = dr.id_reservacion " +
                    "JOIN mascota m ON c.id_mascota = m.id_mascota " +
                    "WHERE c.id_veterinario = ? AND dr.reservado= 1 AND dr.dia_reservacion = ? " +
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
                    "WHERE m.id_propietario <> ? AND dr.reservado= 1 AND dr.dia_reservacion = ? " +
                    "ORDER BY dr.h_ini ASC";
                // O sea, que seleccione todos. Usuarios admin no se les asignan mascotas
            }

            adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
            adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = user.IdUsuario;
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
                MessageBox.Show($"151 Cantidad de citas {citas.Count()}");
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
        public static List<Cita> GetCitas(DateTime fecha, Mascota mascota)
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
                    reservacion.IdReservacion = lector.GetInt32(15);
                    reservacion.IdVetAsignado = lector.GetInt32(16);
                    reservacion.FechaCupo = lector.GetDate(17);
                    reservacion.HoraInicio = lector.GetDateTime(18);
                    reservacion.HoraFin = lector.GetDateTime(19);
                    reservacion.EstaReservado = lector.GetBoolean(20);
                    cita.IdPropietario = lector.GetInt32(21);
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
                    cita.PrecioCita = (double)lector.GetDecimal(10); //Si esto es nulo da excepcion y me saca del bucle
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
        public static bool ActualizarCita(Cita c,CatItem idTipoCita,int idMascota,int idVet, string motivoCita)
        {
            consulta = "UPDATE cita SET id_tipo_cita=?, monto_pago = ?, id_mascota=?, id_veterinario=?, motivo_cita=? " +
                "WHERE id_cita=?";

            ComandoSQL = new MySqlCommand(consulta, ConexionBD.GetConexionMySQL());
            ComandoSQL.Parameters.Add("@idtipocita", MySqlDbType.Int32).Value = idTipoCita.IdCat;
            ComandoSQL.Parameters.Add("@montopago", MySqlDbType.Decimal).Value = idTipoCita.PrecioCat;
            //ComandoSQL.Parameters.Add("@idvet", MySqlDbType.Int32).Value = idVeterinario;
            ComandoSQL.Parameters.Add("@idmascota", MySqlDbType.Int32).Value = idMascota;
            ComandoSQL.Parameters.Add("@idvet", MySqlDbType.Int32).Value = idVet;
            ComandoSQL.Parameters.Add("@motivocita", MySqlDbType.VarChar).Value = motivoCita;
            ComandoSQL.Parameters.Add("@idcita", MySqlDbType.Int32).Value = c.IdCita;
            try
            {
                ConexionBD.GetConexionMySQL().Open();
                ComandoSQL.ExecuteNonQuery();
                //IdInsert = (int)ComandoSQL.LastInsertedId; //Devuelve un Long
                MessageBox.Show($"Detalles de cita actualizados");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocurrió un error al actualizar detalles:\n{e.Message}\n{e.StackTrace}");
                return false;
            }
            finally
            {
                ConexionBD.GetConexionMySQL().Close();
            }
        }        
        /// <summary>
        /// GUARDAR DATOS AL ATENDER CITA
        /// </summary>
        /// <param name="c"></param>
        /// <param name="motivoCita"></param>
        /// <param name="sintomas"></param>
        /// <param name="diagnostico"></param>
        /// <param name="tratamiento"></param>
        /// <param name="observaciones"></param>
        /// <returns></returns>
        public static bool ActualizarAtencionCita(Cita c)
        {
            consulta = "UPDATE cita SET motivo_cita=?, sintomas_mascota=?, diagnostico=?, tratamiento=?, observaciones=? " +
                "WHERE id_cita=?";

            ComandoSQL = new MySqlCommand(consulta, ConexionBD.GetConexionMySQL());
            ComandoSQL.Parameters.Add("@motivocita", MySqlDbType.VarChar).Value = c.MotivoCita;
            ComandoSQL.Parameters.Add("@sintomas", MySqlDbType.VarChar).Value = c.SintomasMascota;
            ComandoSQL.Parameters.Add("@diagnostico", MySqlDbType.VarChar).Value = c.Diagnostico;            
            ComandoSQL.Parameters.Add("@tratamiento", MySqlDbType.VarChar).Value = c.Tratamiento;
            ComandoSQL.Parameters.Add("@observaciones", MySqlDbType.VarChar).Value = c.Observaciones;
            
            ComandoSQL.Parameters.Add("@idcita", MySqlDbType.Int32).Value = c.IdCita;
            try
            {
                ConexionBD.GetConexionMySQL().Open();
                ComandoSQL.ExecuteNonQuery();
                //IdInsert = (int)ComandoSQL.LastInsertedId; //Devuelve un Long
                MessageBox.Show($"Detalles de cita actualizados");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocurrió un error al actualizar detalles:\n{e.Message}\n{e.StackTrace}");
                return false;
            }
            finally
            {
                ConexionBD.GetConexionMySQL().Close();
            }
        }


        //CARGAR DETALLES AL ATENDER CITA
        public static void CargarDetallesAtencionCita(Cita cita)
        {
            consulta = "SELECT motivo_cita, sintomas_mascota,diagnostico,tratamiento,observaciones " +
                "FROM cita WHERE id_cita=?";
            adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
            adaptador.SelectCommand.Parameters.Add("@cita", OdbcType.Int).Value = cita.IdCita;
            
            try
            {
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                while (lector.Read())
                {
                    cita.MotivoCita = lector.GetString(0);
                    cita.SintomasMascota = lector.GetString(1); //Si esto es nulo da excepcion y me saca del bucle
                    cita.Diagnostico = lector.GetString(2); //Si esto es nulo da excepcion y me saca del bucle
                    cita.Tratamiento = lector.GetString(3); //Si esto es nulo da excepcion y me saca del bucle
                    cita.Observaciones = lector.GetString(4); //Si esto es nulo da excepcion y me saca del bucle
                }

                //MessageBox.Show(fechacon.Date+consulta +adaptador.SelectCommand.CommandText);
                MessageBox.Show($"Detalles de cita cargados exitosamente");
                ConexionBD.GetConexionBD().Close();
                /*En ciertos casos no se instancia el lector y queda nulo,
                 recien luego de abrir la conexion, y en el catch no se cierra la conexion
                y no se si deba cerrarla. Creo que si porque igual no recorre el bucle while*/                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"NullRefEx: {ex.Message}\n{ex.StackTrace}");
                cita.SintomasMascota = ""; //Si esto es nulo da excepcion y me saca del bucle
                cita.Diagnostico = ""; //Si esto es nulo da excepcion y me saca del bucle
                cita.Tratamiento = ""; //Si esto es nulo da excepcion y me saca del bucle
                cita.Observaciones = "";
                /*EN CASO DE UNA EXCEPCION QUIERO QUE QUEDE INICIALIZADO CON CAMPOS VACIOS PORQUE LOS STRING EN 
                 * LA VARIABLE cita SON LOS QUE OCUPARE PARA ACTUALIZAR LOS DATOS EN LA BD.
                 DE ESA FORMA PODRIA CAUSARME INCONVENIENTES SI SOLO ALGUNOS CAMPOS TIENEN DATOS*/
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ex: {ex.Message}\n{ex.StackTrace}");
                cita.SintomasMascota = ""; //Si esto es nulo da excepcion y me saca del bucle
                cita.Diagnostico = ""; //Si esto es nulo da excepcion y me saca del bucle
                cita.Tratamiento = ""; //Si esto es nulo da excepcion y me saca del bucle
                cita.Observaciones = "";
                /*EN CASO DE UNA EXCEPCION QUIERO QUE QUEDE INICIALIZADO CON CAMPOS VACIOS PORQUE LOS STRING EN 
                 * LA VARIABLE cita SON LOS QUE OCUPARE PARA ACTUALIZAR LOS DATOS EN LA BD.
                 DE ESA FORMA PODRIA CAUSARME INCONVENIENTES SI SOLO ALGUNOS CAMPOS TIENEN DATOS*/
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }

        //Actualizar estado de cita.
        public static bool ActualizarEstadoCita(Cita c, int idEstadoCita)
        {
            consulta = "UPDATE cita SET id_estado_cita=? " +
                "WHERE id_cita=?";

            ComandoSQL = new MySqlCommand(consulta, ConexionBD.GetConexionMySQL());
            ComandoSQL.Parameters.Add("@estado", MySqlDbType.Int32).Value = idEstadoCita;
            ComandoSQL.Parameters.Add("@idcita", MySqlDbType.Int32).Value = c.IdCita;
            try
            {
                ConexionBD.GetConexionMySQL().Open();
                ComandoSQL.ExecuteNonQuery();
                //IdInsert = (int)ComandoSQL.LastInsertedId; //Devuelve un Long
                MessageBox.Show($"El estado de la cita ha sido actualizado");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el estado:\n{e.Message}\n{e.StackTrace}");
                return false;
            }
            finally
            {
                ConexionBD.GetConexionMySQL().Close();
            }
        }
    }
}
