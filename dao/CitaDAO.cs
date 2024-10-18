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
        /// 
        private static List<Cupo> cuposReservados;
        //Esta lista se usara para definir los cupos disponibles
        private static List<Cupo> cuposDisponibles;
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
                        //tipoCita.DescCat = lector.GetString(2);
                        //tipoCita.PrecioCat = (double)lector.GetDecimal(3);
                        //Falta duracion de cita para ocupar al momento de definir los intervalos de tiempo
                        cuposReservados.Add(cupo);
                    }
                }
                MessageBox.Show($"Cantidad de reservaciones {cuposReservados.Count()}");
                ConexionBD.GetConexionBD().Close();
                //Colocandolo aqui el cerrar conexion porque al llamarlo desde VtnMascotas en selected index changed
                //la primera vez que se selecciona un indice desde cuenta administrador dice que
                //la base de datos no se cierra pero la ejecucion continua
                //A pesar que hay un bloque Finally pero la excepcion ocurre antes del mensaje anterior
                //Y aqui lo pongo despues del mensaje 

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
        //REUBICAR SEGUN CONVENGA Y PUEDE QUE SEA NECESARIO PASARLE UNA FECHA Y UN ID VETERINARIO O LISTA DE VETERINARIOS
        private static List<Cupo> GetCuposDisponibles()
        {
            //CONSULTAR HORARIOS DE ATENCION MATUTINO Y VESPERTINO
            //OBTENER HORA DE INICIO, HORA FIN Y HORAS DE ALMUERZO
            //CONSTRUIR INTERVALOS DE ACUERDO CON LA DURACION DEL TIPO DE CITA SOLICITADO.
            //TOMO LA HORA DE INICIO, LE SUMO LA DURACION Y LA HORA RESULTANDO LA ASIGNO A LA HORA DE FIN
            //HASTA ENCONTRARME CON UNA HORA RESERVADA, HORA DE ALMUERZO U HORA FIN DE UN TURNO
            //PRIMERO DEBE CREARSE LA CITA PARA LUEGO CREAR Y ASIGNAR UN CUPO
            return cuposDisponibles;
        }
    }
}
