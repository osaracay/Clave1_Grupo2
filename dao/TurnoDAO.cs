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
    class TurnoDAO
    {                
        private static string consulta;
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lector;
        private static MySqlCommand ComandoSQL;
        private static List<Turno> turnos; //Define los horarios de atencion
        private static List<Turno> detallesTurnos; //Define los horarios cubiertos por determinados veterinarios
        public static List<Turno> GetTurnosClinica()
        {
            try
            {
                if (turnos == null)
                {
                    turnos = new List<Turno>();
                    consulta = "SELECT * FROM cat_turno_clinica";
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                    //adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner;

                    ConexionBD.GetConexionBD().Open();
                    lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                    while (lector.Read())
                    {
                        Turno turno = new Turno();
                        turno.IdTurno = lector.GetInt32(0); //Tengo que crear quizas una clase nueva para turnos
                        turno.NombreTurno = lector.GetString(1);
                        turno.HoraInicio = lector.GetDateTime(2);
                        turno.HoraFin = lector.GetDateTime(3);
                        turno.HoraAlmuerzo = lector.GetDateTime(4);
                        turnos.Add(turno);
                    }
                }                
                ConexionBD.GetConexionBD().Close();
                //Si el lector no se inicializa no se cierra la conexion y cae el programa en el finally 

                return turnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return turnos;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }

        public static List<Turno> GetTurnosVeterinarios()
        {
            //Esto se ocupara para rellenar la tabla asignar turnos y operar 
            //para definir horarios disponibles
            try
            {
                if (detallesTurnos == null)
                {
                    detallesTurnos = new List<Turno>();
                    consulta = "SELECT dt.id_detalle_turno, dt.id_vet, t.id_turno, t.nom_turno," +
                        "t.h_ini, t.h_fin, t.h_almuerzo, dt.d_descanso1," +
                        "dt.d_descanso2 FROM detalle_turno dt " +
                        "LEFT JOIN cat_turno_clinica t ON dt.id_turno = t.id_turno"; //JOIN
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                    //adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner;

                    ConexionBD.GetConexionBD().Open();
                    lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                    while (lector.Read())
                    {
                        Turno turno = new Turno();
                        turno.IdDetalleTurno = lector.GetInt32(0);
                        turno.IdVet = lector.GetInt32(1);//Tengo que crear quizas una clase nueva para turnos
                        turno.IdTurno = lector.GetInt32(2);
                        turno.NombreTurno = lector.GetString(3);
                        turno.HoraInicio = lector.GetDateTime(4);
                        turno.HoraFin = lector.GetDateTime(5);
                        turno.HoraAlmuerzo = lector.GetDateTime(6);
                        turno.Descanso1 = lector.GetChar(7);
                        turno.Descanso2 = lector.GetChar(8);
                        detallesTurnos.Add(turno);
                    }
                }
                ConexionBD.GetConexionBD().Close();
                //Si el lector no se inicializa no se cierra la conexion y cae el programa en el finally 

                return detallesTurnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return detallesTurnos;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }
        public static void ActualizarDetalleturnos()
        {
            detallesTurnos = null;
            GetTurnosVeterinarios();
        }

        public static bool AsignarTurno(int idVeterinario, int idTurno, char d1, char d2)
        {
            //recordar que el id debe ser un usuario de tipo 2
            //y la ventana asignar turnos llena el combo Veterinarios
            //con usuarios tipo 2. Utilizando MySqlConnection
            consulta = "INSERT INTO detalle_turno (id_vet, " +
                "id_turno, d_descanso1, d_descanso2)" +
                "VALUES (?, ?, ?, ?)";

            ComandoSQL = new MySqlCommand(consulta,ConexionBD.GetConexionMySQL());

            ComandoSQL.Parameters.Add("@idvet", MySqlDbType.Int32).Value = idVeterinario;
            ComandoSQL.Parameters.Add("@idturno", MySqlDbType.Int32).Value = idTurno;
            ComandoSQL.Parameters.Add("@d1", MySqlDbType.Enum).Value = d1;
            ComandoSQL.Parameters.Add("@d2", MySqlDbType.Enum).Value = d2;
            try
            {
                ConexionBD.GetConexionMySQL().Open();
                ComandoSQL.ExecuteNonQuery();
                int idInsert = (int)ComandoSQL.LastInsertedId; //Devuelve un Long
                MessageBox.Show($"Asignación completada. Id del registro: {idInsert}");
                return true;
            } catch (Exception e)
            {
                MessageBox.Show($"Ocurrió un error al asignar turno:\n{e.Message}");
                return false;
            }
            finally
            {
                ConexionBD.GetConexionMySQL().Close();
            }
        }

        public static bool ReasignarTurno(int idVeterinario, int idTurno, char d1, char d2)
        {
            //recordar que el id debe ser un usuario de tipo 2
            //y la ventana asignar turnos llena el combo Veterinarios
            //con usuarios tipo 2. Utilizando MySqlConnection
            consulta = "UPDATE detalle_turno SET id_vet=?, " +
                "id_turno=?, d_descanso1=?, d_descanso2=?";

            ComandoSQL = new MySqlCommand(consulta, ConexionBD.GetConexionMySQL());

            ComandoSQL.Parameters.Add("@idvet", MySqlDbType.Int32).Value = idVeterinario;
            ComandoSQL.Parameters.Add("@idturno", MySqlDbType.Int32).Value = idTurno;
            ComandoSQL.Parameters.Add("@d1", MySqlDbType.Enum).Value = d1;
            ComandoSQL.Parameters.Add("@d2", MySqlDbType.Enum).Value = d2;
            try
            {
                ConexionBD.GetConexionMySQL().Open();
                ComandoSQL.ExecuteNonQuery();
                int idInsert = (int)ComandoSQL.LastInsertedId; //Devuelve un Long
                MessageBox.Show($"Resignación completada.");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocurrió un error al asignar turno:\n{e.Message}");
                return false;
            }
            finally
            {
                ConexionBD.GetConexionMySQL().Close();
            }
        }
    }
}
