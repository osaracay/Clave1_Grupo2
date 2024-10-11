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
    class MascotaDAO
    {
        ///<summary>
        ///Clase de Acceso a Datos de la tabla Mascota
        /// </summary>

        private static DataTable pets;

        private static string consulta;
        private static OdbcDataAdapter adaptador;
        public static bool RegistrarMascota(Mascota pet)
        {
            string sentenciaSQL = "INSERT INTO mascota (nom_mascota, " +
                "especie, raza, edad, genero_mascota, id_propietario, estado_mascota)" +//, color) " +
                "VALUES (?, ?, ?, ?, ?, ?, ?)"; //, ?)";
            /*"VALUES (@nombre, @apellido, @fecha_nac, @tipo_usuario, @estado_usuario, @email, @genero, @usrlogin, @usrpw)";
             Esta forma no funciona debo usar los ? como en Java*/
            ConexionBD.GetConexionBD().Open();
            adaptador = new OdbcDataAdapter();
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.InsertCommand = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD());
            //OdbcCommand comando = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD()); El objeto OdbcComand se guarda en el Getter de adaptador InsertCommand
            //comando.Parameters.AddWithValue("@nombre", c.Nombre);

            adaptador.InsertCommand.Parameters.Add("@nombre", OdbcType.VarChar).Value = pet.GetNomMascota();
            adaptador.InsertCommand.Parameters.Add("@especie", OdbcType.Int).Value = pet.GetEspecie();
            adaptador.InsertCommand.Parameters.Add("@raza", OdbcType.VarChar).Value = pet.GetRaza();
            adaptador.InsertCommand.Parameters.Add("@edad", OdbcType.Int).Value = pet.GetEdad();
            adaptador.InsertCommand.Parameters.Add("@genero", OdbcType.Char).Value = pet.GetGeneroMascota();            
            adaptador.InsertCommand.Parameters.Add("@id_propietario", OdbcType.Int).Value = pet.GetIdPropietario(); //El cbxPropietario se popula solo con clientes                        
            adaptador.InsertCommand.Parameters.Add("@estado", OdbcType.Int).Value = 2; // Activa por default al momento de agregar
            //adaptador.InsertCommand.Parameters.Add("@color", OdbcType.VarChar).Value = pet.Color;
            try
            {
                adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Se registró la mascota con éxito");

                //Durante las pruebas obtuvimos el error al agregar color ODBC: ERROR [HY001] Out of memory while reading tuples.; memory allocation error
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionBD.GetConexionBD().Close();
            }
        }

        public static DataTable GetMascotasPorPropietario(int idPropietario)
        {
            consulta = $"SELECT * FROM mascota WHERE id_propietario={idPropietario}"; // Actualizar este query usando Parametros
            if (pets == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    pets = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(pets);

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(pets);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ocurrio un error: \n{e.Message}");
                }
                finally
                {
                    ConexionBD.GetConexionBD().Close();
                }
            }
            return pets;
        }
    }
}
