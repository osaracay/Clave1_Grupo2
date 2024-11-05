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
    class CupoDAO
    {
        private static string consulta;
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lector;
        private static MySqlCommand ComandoSQL;
        private static int idInsert;

        //Variable para restringir horario de atencion de la clinica en un dia
        private static DateTime inicioJornada;
        private static DateTime finJornada;
        private static DateTime inicioCupo;
        private static DateTime finCupo;
        private static DateTime finTurno;
        ///<summary>
        ///Clase de Acceso a Datos de la tabla reservaciones
        /// </summary>
        /// 
        private static List<Cupo> cuposReservados; //Totalidad de cupos reservados en la base de datos
        //Esta lista se usara para definir los cupos disponibles
        private static List<Cupo> cuposDisponibles;

        public static int IdInsert { get => idInsert; set => idInsert = value; }

        //Reubicar segun convenga        

        //Probablemente necesite pasarle fecha 
        public static List<Cupo> GetCuposReservados()
        {
            try
            {
                if (cuposReservados == null)
                {
                    cuposReservados = new List<Cupo>();
                    consulta = "SELECT * FROM detalle_reservacion";
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                    //adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner;

                    ConexionBD.GetConexionBD().Open();
                    lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                    while (lector.Read())
                    {
                        Cupo cupo = new Cupo();
                        cupo.IdReservacion = lector.GetInt32(0);
                        cupo.IdVetAsignado = lector.GetInt32(1);
                        cupo.HoraInicio = lector.GetDateTime(3);
                        cupo.HoraFin = lector.GetDateTime(4);
                        cupo.EstaReservado = lector.GetBoolean(5);
                        cupo.FechaCupo = lector.GetDate(6);
                        cuposReservados.Add(cupo);
                    }
                }
                MessageBox.Show($"Cantidad de reservaciones {cuposReservados.Count()}");
                ConexionBD.GetConexionBD().Close();
                //Colocandolo aqui el cerrar conexion porque al llamarlo desde VtnMascotas en selected index changed
                //la primera vez que se selecciona un indice desde cuenta administrador dice que
                //la base de datos no se cierra pero la ejecucion continua gracias al catch
                //A pesar que hay un bloque Finally pero la excepcion ocurre antes del mensaje anterior
                //Y aqui lo pongo despues del mensaje

                /*Lo que ocurre es que en ciertos casos no se instancia el lector y queda nulo,
                 recien luego de abrir la conexion, y en el catch no se cierra la conexion
                y no se si deba cerrarla. Creo que si porque igual no recorre el bucle while*/

                return cuposReservados;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return cuposReservados;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }

        /// <summary>
        /// Obtengo los cupos reservados de una fecha para un veterinario
        /// </summary>
        /// <param name="fecha">Fecha reservación</param>
        /// <param name="vet">Veterinario seleccionado</param>
        /// <returns></returns>
        public static List<Cupo> GetCuposReservados(DateTime fecha, Veterinario vet)
        {
            try
            {
                if (cuposReservados == null)
                {
                    cuposReservados = new List<Cupo>();
                    consulta = "SELECT * FROM detalle_reservacion WHERE dia_reservacion = ? AND id_vet = ?";
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                    adaptador.SelectCommand.Parameters.Add("@dia reservacion", OdbcType.Date).Value = fecha.ToString("d");
                    adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = vet.IdUsuario;

                    ConexionBD.GetConexionBD().Open();
                    lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                    while (lector.Read())
                    {
                        Cupo cupo = new Cupo();
                        cupo.IdReservacion = lector.GetInt32(0);
                        cupo.IdVetAsignado = lector.GetInt32(1);
                        cupo.HoraInicio = lector.GetDateTime(3);
                        cupo.HoraFin = lector.GetDateTime(4);
                        cupo.EstaReservado = lector.GetBoolean(5);
                        cupo.FechaCupo = lector.GetDate(6);
                        cuposReservados.Add(cupo);
                    }
                }
                MessageBox.Show($"Cantidad de reservaciones {cuposReservados.Count()}");
                ConexionBD.GetConexionBD().Close();
                //Colocandolo aqui el cerrar conexion porque al llamarlo desde VtnMascotas en selected index changed
                //la primera vez que se selecciona un indice desde cuenta administrador dice que
                //la base de datos no se cierra pero la ejecucion continua gracias al catch
                //A pesar que hay un bloque Finally pero la excepcion ocurre antes del mensaje anterior
                //Y aqui lo pongo despues del mensaje

                /*Lo que ocurre es que en ciertos casos no se instancia el lector y queda nulo,
                 recien luego de abrir la conexion, y en el catch no se cierra la conexion
                y no se si deba cerrarla. Creo que si porque igual no recorre el bucle while*/

                return cuposReservados;
            } catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                return cuposReservados;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return cuposReservados;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }

        /// <summary>
        /// EN CONSTRUCCION: Dado un veterinario, obtiene sus detalles de turno en la clinica. -bY OCSaracay
        /// </summary>
        /// <param name="vet">Veterinario sobre quien se hace la consulta</param>
        /// <returns>true si todo salio bien, false si algo acontecio firma Oswaldo</returns>
        /// <author>OCSARACAY</author>
        public static bool GetDataVeterana(Veterinario vet)
        {
            try
            {                
                consulta = "SELECT dt.id_vet, tc.H_ini, tc.H_fin, tc.H_almuerzo, dt.d_descanso1, dt.d_descanso2, tc.nom_turno " +
                    "FROM detalle_turno dt JOIN cat_turno_clinica tc ON dt.id_turno = tc.id_turno WHERE dt.id_vet = ?";
                adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                //adaptador.SelectCommand.Parameters.Add("@dia reservacion", OdbcType.Date).Value = fecha.ToString("d");
                adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = vet.IdUsuario;

                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                while (lector.Read())
                {
                    vet.HoraIniTurno = lector.GetDateTime(1);
                    vet.HoraFinTurno = lector.GetDateTime(2);
                    vet.HoraAlmuerzo = lector.GetDateTime(3);
                    vet.DiaDescanso1 = lector.GetChar(4);
                    vet.DiaDescanso2 = lector.GetChar(5);
                    vet.NombreTurno = lector.GetString(6);

                }                
                MessageBox.Show($"Cantidad de reservaciones {cuposReservados.Count()}");
                ConexionBD.GetConexionBD().Close();
                //Colocandolo aqui el cerrar conexion porque al llamarlo desde VtnMascotas en selected index changed
                //la primera vez que se selecciona un indice desde cuenta administrador dice que
                //la base de datos no se cierra pero la ejecucion continua gracias al catch
                //A pesar que hay un bloque Finally pero la excepcion ocurre antes del mensaje anterior
                //Y aqui lo pongo despues del mensaje

                /*Lo que ocurre es que en ciertos casos no se instancia el lector y queda nulo,
                 recien luego de abrir la conexion, y en el catch no se cierra la conexion
                y no se si deba cerrarla. Creo que si porque igual no recorre el bucle while*/

                return true;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }

        //REUBICAR SEGUN CONVENGA Y PUEDE QUE SEA NECESARIO PASARLE UNA FECHA
        //Y UN ID VETERINARIO O LISTA DE VETERINARIOS
        //TENGO QUE CONTAR LOS VETS 

        /*
        /// <summary>
        /// Prueba: Dada una fecha y una duracion en minutos enteros genera cupos disponibles y los devuelve en una lista
        /// </summary> 
        /// <param name="fecha">fecha de donde se solicitan los cupos</param>
        /// <param name="duracionMinutos">duracion en minutos de la cita</param>
        /// <returns>Devuelve un listado de Cupos disponibles </returns>
        public static List<Cupo> GetCuposDisponibles(DateTime fecha, int duracionMinutos)
        {
            cuposDisponibles = new List<Cupo>(); 
            //CONSULTAR HORARIOS DE ATENCION MATUTINO Y VESPERTINO
            inicioJornada = new DateTime(fecha.Year, fecha.Month, fecha.Day,
                TurnoDAO.GetTurnosClinica().ElementAt(0).HoraInicio.Hour, 0, 0); //Estos incluyen los turnos de la clinica y todos los veterinarios            
            //ElementAt(0) es porque yo se que el primer turno es el matutino. Tener cuidado con referencias
            //estaticas de este tipo

            finJornada = new DateTime(fecha.Year, fecha.Month, fecha.Day,
                TurnoDAO.GetTurnosClinica().ElementAt(1).HoraFin.Hour, 0, 0); //Cuidado con lo que viene de turnos clinica por la fecha
                                                                              //ElementAt(1) es porque yo se que el siguiente turno es el vespertino. Tener cuidado con referencias
                                                                              //estaticas de este tipo

            MessageBox.Show($"El inicio de la jornada es {inicioJornada.ToString("G")}\n" +
                $"El fin de la jornada es {finJornada.ToString("G")}");
            

            //hora inicio y hora fin se guardan en la base como hh:mm:ss. Al traerlo a codigo solo puede guardarse como DateTime. 
            //La parte correspondiente a la fecha la asigna en tiempo de compilacion. para fechas futuras puede que
            //necesite agregar los dias

            //MessageBox.Show($"{inicioJornada.Date.ToString("G")}");

            //Aqui obtengo las reservaciones de la fecha indicada en el parametro
            IEnumerable<Cupo> reservacionesDia = from reservacion in GetCuposReservados() where reservacion.FechaCupo == fecha.Date select reservacion;
            //se tomara en cuenta la hora de inicio y la hora de finalizacion de cada reservacion encontrada

            //OBTENER HORA DE INICIO, HORA FIN Y HORAS DE ALMUERZO
            //CONSTRUIR INTERVALOS DE ACUERDO CON LA DURACION DEL TIPO DE CITA SOLICITADO.
            inicioCupo = inicioJornada;
            while(inicioCupo >= inicioJornada && finCupo < finJornada)
            {
                //hora inicio se ira actualizando segun se vayan creando cupos
                Cupo c = new Cupo(fecha.Date, inicioCupo, duracionMinutos);
                finCupo = c.HoraFin;
                inicioCupo = finCupo;
                cuposDisponibles.Add(c);
            }
            //TOMO LA HORA DE INICIO, LE SUMO LA DURACION Y LA HORA RESULTANDO LA ASIGNO A LA HORA DE FIN
            //HASTA ENCONTRARME CON UNA HORA RESERVADA, HORA DE ALMUERZO U HORA FIN DE UN TURNO
            //PRIMERO DEBE CREARSE LA CITA PARA LUEGO CREAR Y ASIGNAR UN CUPO
            return cuposDisponibles;
        }
        */

        //Sobrecarga del metodo recibiendo un tipo de cita instead
        /// <summary>
        /// Dada una fecha y una duracion en minutos enteros genera cupos disponibles y los devuelve en una lista
        /// </summary>
        /// <param name="fecha">fecha de donde se solicitan los cupos</param>
        /// <param name="tipoCita">Tipo de cita del cual se extra la duracion en minutos y el precio de la cita</param>
        /// <returns>Devuelve un listado de Cupos disponibles </returns>
        public static List<Cupo> GetCuposDisponibles(DateTime fecha, CatItem tipoCita)
        {
            if(cuposDisponibles == null)
            {
                cuposDisponibles = new List<Cupo>();
            }
            cuposDisponibles.Clear();
            //CONSULTAR HORARIOS DE ATENCION MATUTINO Y VESPERTINO
            inicioJornada = new DateTime(fecha.Year, fecha.Month, fecha.Day,
                TurnoDAO.GetTurnosClinica().ElementAt(0).HoraInicio.Hour, 0, 0); //Estos incluyen los turnos de la clinica y todos los veterinarios            
            //ElementAt(0) es porque yo se que el primer turno es el matutino. Tener cuidado con referencias
            //estaticas de este tipo

            finJornada = new DateTime(fecha.Year, fecha.Month, fecha.Day,
                TurnoDAO.GetTurnosClinica().ElementAt(1).HoraFin.Hour, 0, 0); //Cuidado con lo que viene de turnos clinica por la fecha
                                                                              //ElementAt(1) es porque yo se que el siguiente turno es el vespertino. Tener cuidado con referencias
                                                                              //estaticas de este tipo

            /*MessageBox.Show($"El inicio de la jornada es {inicioJornada.ToString("G")}\n" +
                $"El fin de la jornada es {finJornada.ToString("G")}");
            */

            //hora inicio y hora fin se guardan en la base como hh:mm:ss. Al traerlo a codigo solo puede guardarse como DateTime. 
            //La parte correspondiente a la fecha la asigna en tiempo de compilacion. para fechas futuras puede que
            //necesite agregar los dias

            //MessageBox.Show($"{inicioJornada.Date.ToString("G")}");

            //Aqui obtengo las reservaciones de la fecha indicada en el parametro
            IEnumerable<Cupo> reservacionesDia = from reservacion in GetCuposReservados() where reservacion.FechaCupo == fecha.Date select reservacion;
            //se tomara en cuenta la hora de inicio y la hora de finalizacion de cada reservacion encontrada

            //OBTENER HORA DE INICIO, HORA FIN Y HORAS DE ALMUERZO
            //CONSTRUIR INTERVALOS DE ACUERDO CON LA DURACION DEL TIPO DE CITA SOLICITADO.
            inicioCupo = inicioJornada;
            while (inicioCupo >= inicioJornada && inicioCupo < finJornada) //finCupo < finJornada)
            {
                foreach(Cupo cupoReservado in reservacionesDia)
                {
                    //Comparar INICIO CUPO con INICIO DE CUPO RESERVADO                   
                    if(cupoReservado.HoraInicio == inicioCupo)
                    {
                        //Si esto encuentra un solo cupo reservado, lo va a saltar AUNQUE HAYAN MAS VETS QUE LO PUEDAN CUBRIR
                        //Considerar si hay un cupo apartado media hora antes si la duracion es de 60 min.
                        inicioCupo = inicioCupo.AddMinutes(tipoCita.DuracionMinutosCat);
                        //Puedo contar a ver si se sale del foreach o algo
                        break;
                    }
                }
                //hora inicio se ira actualizando segun se vayan creando cupos
                Cupo c = new Cupo(fecha.Date, inicioCupo, tipoCita.DuracionMinutosCat);
                //finCupo = c.HoraFin;
                inicioCupo = c.HoraFin; //finCupo;
                cuposDisponibles.Add(c);
            }
            //TOMO LA HORA DE INICIO, LE SUMO LA DURACION Y LA HORA RESULTANDO LA ASIGNO A LA HORA DE FIN
            //HASTA ENCONTRARME CON UNA HORA RESERVADA, HORA DE ALMUERZO U HORA FIN DE UN TURNO
            //PRIMERO DEBE CREARSE LA CITA PARA LUEGO CREAR Y ASIGNAR UN CUPO
            return cuposDisponibles;
        }
        

        //Sobrecarga del metodo recibiendo un tipo de cita instead
        /// <summary>
        /// Dada una fecha y una duracion en minutos enteros genera cupos disponibles y los devuelve en una lista
        /// </summary>
        /// <param name="fecha">fecha de donde se solicitan los cupos</param>
        /// <param name="tipoCita">Tipo de cita del cual se extrae la duracion en minutos y el precio de la cita</param>
        /// <param name="vet">Obtener cupos para este Veterinario</param>
        /// <returns>Devuelve un listado de Cupos disponibles por veterinario y tipo de cita.</returns>
        public static List<Cupo> GetCuposDisponibles(DateTime fecha, CatItem tipoCita, Veterinario vet)
        {
            //?Donde esta la informacion del vet respecto a turnos? detalle turnos.

            
            
            //De estos turnos reservados para un vet en x fecha
            CupoDAO.GetCuposReservados(new DateTime(fecha.Year,fecha.Month,fecha.Day), vet);
            //Lo hago asi porque la fecha que se pasa en el argumento puede no estar 00:00:00 en hh:mm:ss

            if (cuposDisponibles == null)
            {
                cuposDisponibles = new List<Cupo>();
            }
            cuposDisponibles.Clear();
            if (GetDataVeterana(vet))
            {
                inicioJornada = new DateTime(fecha.Year, fecha.Month, fecha.Day,
                vet.HoraIniTurno.Hour, 0, 0); //Estos incluyen los turnos de la clinica y todos los veterinarios            
                                              //ElementAt(0) es porque yo se que el primer turno es el matutino. Tener cuidado con referencias
                                              //estaticas de este tipo

                finTurno = new DateTime(fecha.Year, fecha.Month, fecha.Day,
                    vet.HoraFinTurno.Hour, 0, 0); //Cuidado con lo que viene de turnos clinica por la fecha
                                                  //ElementAt(1) es porque yo se que el siguiente turno es el vespertino. Tener cuidado con referencias
                                                  //estaticas de este tipo
            }
            else
            {
                MessageBox.Show("Probablemente el veterinario no tenga un turno asignado");
            }
            //CONSULTAR HORARIOS DE ATENCION MATUTINO Y VESPERTINO


            /*MessageBox.Show($"El inicio de la jornada es {inicioJornada.ToString("G")}\n" +
                $"El fin de la jornada es {finJornada.ToString("G")}");
            */

            //hora inicio y hora fin se guardan en la base como hh:mm:ss. Al traerlo a codigo solo puede guardarse como DateTime. 
            //La parte correspondiente a la fecha la asigna en tiempo de compilacion. para fechas futuras puede que
            //necesite agregar los dias

            //MessageBox.Show($"{inicioJornada.Date.ToString("G")}");

            //Aqui obtengo las reservaciones de la fecha indicada en el parametro
            IEnumerable<Cupo> reservacionesDia = from reservacion in GetCuposReservados() where reservacion.FechaCupo == fecha.Date select reservacion;
            //se tomara en cuenta la hora de inicio y la hora de finalizacion de cada reservacion encontrada

            //OBTENER HORA DE INICIO, HORA FIN Y HORAS DE ALMUERZO
            //CONSTRUIR INTERVALOS DE ACUERDO CON LA DURACION DEL TIPO DE CITA SOLICITADO.
            inicioCupo = inicioJornada;
            while (inicioCupo >= inicioJornada && inicioCupo < finTurno) //finCupo < finJornada)
            {
                foreach (Cupo cupoReservado in reservacionesDia)
                {
                    //Comparar INICIO CUPO con INICIO DE CUPO RESERVADO                   
                    if (cupoReservado.HoraInicio == inicioCupo)
                    {
                        //Si esto encuentra un solo cupo reservado, lo va a saltar AUNQUE HAYAN MAS VETS QUE LO PUEDAN CUBRIR
                        //Considerar si hay un cupo apartado media hora antes si la duracion es de 60 min.
                        inicioCupo = inicioCupo.AddMinutes(tipoCita.DuracionMinutosCat);
                        //Puedo contar a ver si se sale del foreach o algo
                        break;
                    }
                }
                //hora inicio se ira actualizando segun se vayan creando cupos
                Cupo c = new Cupo(fecha.Date, inicioCupo, tipoCita.DuracionMinutosCat);
                //finCupo = c.HoraFin;
                inicioCupo = c.HoraFin; //finCupo;
                cuposDisponibles.Add(c);
            }
            //TOMO LA HORA DE INICIO, LE SUMO LA DURACION Y LA HORA RESULTANDO LA ASIGNO A LA HORA DE FIN
            //HASTA ENCONTRARME CON UNA HORA RESERVADA, HORA DE ALMUERZO U HORA FIN DE UN TURNO
            //PRIMERO DEBE CREARSE LA CITA PARA LUEGO CREAR Y ASIGNAR UN CUPO
            return cuposDisponibles;
        }
        /// <summary>
        /// 
        /// By Liss AlexaSorto
        /// </summary>
        /// <param name="idVeterinario"></param>
        /// <param name="fechaCupo"></param>
        /// <param name="horaInicio"></param>
        /// <param name="horaFin"></param>
        /// <returns></returns>
        /// <autor>Liss</autor>
        public static bool RegistrarCupo(int idVeterinario, DateTime fechaCupo, DateTime horaInicio, DateTime horaFin )
        {
            //recordar que el id debe ser un usuario de tipo 2
            //y la ventana asignar turnos llena el combo Veterinarios
            //con usuarios tipo 2. Utilizando MySqlConnection
            consulta = "INSERT INTO detalle_reservacion (id_vet, dia_reservacion, h_ini, h_fin, reservado)" +
                "VALUES (?,?, ?, ?, TRUE)";

            ComandoSQL = new MySqlCommand(consulta, ConexionBD.GetConexionMySQL());

            ComandoSQL.Parameters.Add("@idvet", MySqlDbType.Int32).Value = idVeterinario;
            ComandoSQL.Parameters.Add("@fechacupo", MySqlDbType.Datetime).Value = fechaCupo;
            ComandoSQL.Parameters.Add("@horainicio", MySqlDbType.DateTime).Value = horaInicio;
            ComandoSQL.Parameters.Add("@horafin", MySqlDbType.DateTime).Value = horaFin;
            try
            {
                ConexionBD.GetConexionMySQL().Open();
                ComandoSQL.ExecuteNonQuery();
                IdInsert = (int)ComandoSQL.LastInsertedId; //Devuelve un Long
                MessageBox.Show($"Asignación completada. Id del registro: {IdInsert}");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocurrió un error al asignar turno:\n{e.Message}\n{e.StackTrace}");
                return false;
            }
            finally
            {
                ConexionBD.GetConexionMySQL().Close();
            }
        }
    }
}
