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
    class TurnoDAO
    {                
        private static string consulta;
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lector;
        private static List<Turno> turnos;
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
    }
}
