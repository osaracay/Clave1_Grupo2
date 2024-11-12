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
        private static string sentenciaSQL;
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lector;
        private static List<Mascota> mascotasDueno;
        public static bool RegistrarMascota(Mascota pet)
        {
            sentenciaSQL = "INSERT INTO mascota (nom_mascota, " +
                "especie, raza, edad, genero_mascota, id_propietario, estado_mascota, color)" +//, color) " +
                "VALUES (?, ?, ?, ?, ?, ?, ?, ?)"; //)"; //
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
            adaptador.InsertCommand.Parameters.Add("@color", OdbcType.VarChar).Value = pet.Color;
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

        /*SIN USARUpdate mascotas por propietario en caso el usuario sea vet o admin
        public static DataTable GetMascotasPorPropietario(int propietario)
        {
            //ASEGURARARME QUE EL Usuario sea tipo cliente
            sentenciaSQL = "SELECT * FROM mascota WHERE id_propietario = ?";
            pets = new DataTable();
            adaptador = new OdbcDataAdapter(sentenciaSQL, ConexionBD.GetConexionBD());
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.SelectCommand = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD());

            //MessageBox.Show("Id de propietario es " + propietario); Se ejecuta dos veces por el listbox y el combobox
            adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = propietario;

            try
            {
                ConexionBD.GetConexionBD().Open();
                adaptador.SelectCommand.ExecuteNonQuery(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                adaptador.Fill(pets);
                return pets;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
                return pets;
            }
            finally
            {
                ConexionBD.GetConexionBD().Close();
            }            
        }
        */
        public static List<Mascota> GetListaMascotasOwner(Usuario owner)
        {
            //ASEGURARARME QUE EL Usuario sea tipo cliente
            if (owner.TipoUsuario == 3) //Aqui puede suceder un relajo si le paso un Usuario de tipo distinto de 3
            {           
            sentenciaSQL = "SELECT * FROM mascota WHERE id_propietario = ?";
            mascotasDueno = new List<Mascota>();
            adaptador = new OdbcDataAdapter(sentenciaSQL, ConexionBD.GetConexionBD());
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.SelectCommand = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD());
            
            adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner.IdUsuario;
            }
            else
            {
                MessageBox.Show("El tipo de usuario no posee mascotas");
            }
            try
            {
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                while (lector.Read())
                {
                    Mascota m = new Mascota();
                    m.SetIdmascota(lector.GetInt32(0)); //int
                    m.SetNomMascota(lector.GetString(1));
                    m.SetEspecie(lector.GetInt32(2)); //int. Ver si puedo ocupar un JOIN y agregar propiedad con el texto especie
                    m.SetRaza(lector.GetString(3)); //String
                    m.SetEdad(lector.GetInt32(4)); //
                    m.SetGeneroMascota(lector.GetChar(5)); //CHAR
                    m.SetIdPropietario(lector.GetInt32(6)); //int
                    m.EstadoMascota = lector.GetInt32(7); //int
                    //COLOR FALTA
                    m.Color = lector.GetString(8);
                    mascotasDueno.Add(m);
                }
                //MessageBox.Show($"Cantidad de mascotas {mascotasDueno.Count}");
                return mascotasDueno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return mascotasDueno;
            }
            finally
            {
                if (lector != null)
                {
                    lector.Close();
                }                                                
                ConexionBD.GetConexionBD().Close();
            }
        }
        public static List<Mascota> GetListaMascotasOwner(int owner)
        {
            //ASEGURARARME QUE EL Usuario sea tipo cliente
            sentenciaSQL = "SELECT * FROM mascota WHERE id_propietario = ?";
            mascotasDueno = new List<Mascota>();
            adaptador = new OdbcDataAdapter(sentenciaSQL, ConexionBD.GetConexionBD());
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.SelectCommand = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD());
            adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner;
            try
            {
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                while (lector.Read())
                {
                    Mascota m = new Mascota();
                    m.SetIdmascota(lector.GetInt32(0)); //int
                    m.SetNomMascota(lector.GetString(1));
                    m.SetEspecie(lector.GetInt32(2)); //int. Ver si puedo ocupar un JOIN y agregar propiedad con el texto especie
                    m.SetRaza(lector.GetString(3)); //String
                    m.SetEdad(lector.GetInt32(4)); //
                    m.SetGeneroMascota(lector.GetChar(5)); //CHAR
                    m.SetIdPropietario(lector.GetInt32(6)); //int                    
                    m.EstadoMascota = lector.GetInt32(7); //int
                    //COLOR FALTA
                    m.Color = lector.GetString(8);
                    mascotasDueno.Add(m);
                }
                ConexionBD.GetConexionBD().Close();
                //MessageBox.Show($"Cantidad de mascotas {mascotasDueno.Count}");
                //Colocandolo aqui el cerrar conexion porque al llamarlo desde VtnMascotas en selected index changed
                //la primera vez que se selecciona un indice desde cuenta administrador dice que
                //la base de datos no se cierra pero la ejecucion continua
                //A pesar que hay un bloque Finally pero la excepcion ocurre antes del mensaje anterior
                //Y aqui lo pongo despues del mensaje 
                
                return mascotasDueno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return mascotasDueno;
            }
            finally
            {
                lector.Close();
                
                ConexionBD.GetConexionBD().Close();
            }
        }
        public static bool ActualizarDatosMascota(Mascota m, string nombre, int especie, string raza, int edad, char genero, string color)
        {

            string sentenciaSQL = "UPDATE mascota SET nom_mascota = ?, " +
    "especie = ?, raza = ?, edad = ?, genero_mascota = ?, color = ? " + //color pudiera dar excepcion
                "WHERE id_mascota = ?"; //, ?)";
            /*"VALUES (@nombre, @apellido, @fecha_nac, @tipo_usuario, @estado_usuario, @email, @genero, @usrlogin, @usrpw)";
             Esta forma no funciona debo usar los ? como en Java*/
            ConexionBD.GetConexionBD().Open();
            adaptador = new OdbcDataAdapter();
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.InsertCommand = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD());
            //OdbcCommand comando = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD()); El objeto OdbcComand se guarda en el Getter de adaptador InsertCommand
            //comando.Parameters.AddWithValue("@nombre", c.Nombre);

            adaptador.InsertCommand.Parameters.Add("@nombre", OdbcType.VarChar, 30).Value = nombre;
            adaptador.InsertCommand.Parameters.Add("@especie", OdbcType.Int).Value = especie;
            adaptador.InsertCommand.Parameters.Add("@raza", OdbcType.VarChar).Value = raza;
            adaptador.InsertCommand.Parameters.Add("@edad", OdbcType.Int).Value = edad;
            adaptador.InsertCommand.Parameters.Add("@genero", OdbcType.Char).Value = genero;
            adaptador.InsertCommand.Parameters.Add("@color", OdbcType.VarChar).Value = color;
            adaptador.InsertCommand.Parameters.Add("@idmascota", OdbcType.Int).Value = m.GetIdMascota(); // Activa por default al momento de agregar            
            try
            {
                adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show($"Se actualizó la información de {nombre}");
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
    }
}
