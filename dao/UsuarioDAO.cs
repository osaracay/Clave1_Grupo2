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
    class UsuarioDAO
    {
        ///<summary>
        ///Clase de Acceso a Datos de la tabla Usuario
        /// </summary>
        private static string consulta;
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lector;

        private static DataTable clientes;
        private static DataTable vets;
        private static DataTable admins;

        private static Usuario sesion; //Para gestionar la sesion.

        //PARA CREAR Y ACCEDER AL Colaborador Sesion
        /*
         * Al parecer no utilizare este de momento*/
        public static void SetSesion(Usuario c)
        {
            sesion = c;
        }
        
        public static Usuario GetSesion()
        {
            return sesion;
        }
        //POLIMORFISMO: Aqui es donde se decidira si crear un cliente, vet, o admin segun el tipo de usuario
        public static bool AutenticarUsuario(string usuario, string haspw)
        {
            //haspw es hashed pw
            //1 verificar usuario y pw existen en la bd
            consulta = "SELECT * FROM usuario WHERE usr_login=? AND usr_pw=?";

            adaptador = new OdbcDataAdapter(consulta,ConexionBD.GetConexionBD());
            adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
            // Set the parameters.
            adaptador.SelectCommand.Parameters.Add(
                "@usr", OdbcType.VarChar).Value = usuario;
            adaptador.SelectCommand.Parameters.Add(
                "@pw", OdbcType.VarChar).Value = haspw;

            try
            {
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader();
                while (lector.Read())
                {
                    sesion = new Usuario(); 
                    sesion.IdUsuario = lector.GetInt32(0);
                    sesion.Nombre= lector.GetString(1);
                    sesion.Apellido = lector.GetString(2);
                    sesion.FechaNac = lector.GetDateTime(3);
                    sesion.TipoUsuario = lector.GetInt32(4);
                    sesion.EstadoUsuario = lector.GetInt32(5);
                    sesion.Email = lector.GetString(6);
                    sesion.Genero = lector.GetChar(7);
                    sesion.Username = lector.GetString(8);
                    return true;
                }
                MessageBox.Show("Informacion incorrecta");
                return false;
            }
            catch (OdbcException)
            {
                MessageBox.Show("Asegúrese que la base de datos esté activa y el puerto abierto.");
                return false;
            }
            finally
            {
                //lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }
        //DEVUELVE LA . SEGUN EL NOMBRE DEL USUARIO. PUEDE UTILIZARSE PARA CONFIRMAR CAMBIO DE . TAMBIEN
        public static string Olvidaste(string usuario)
        {
            return OlvidePw(usuario);
        }
        private static string OlvidePw(string usr)
        {
            string hashedpw = "";
            consulta = $"SELECT usr_pw FROM usuario WHERE usr_login=?";
            
            adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
            adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());

            adaptador.SelectCommand.Parameters.Add("@usr", OdbcType.VarChar).Value = usr;
            try
            {
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader();
                
                while (lector.Read())
                {
                    hashedpw = lector.GetString(0);                    
                }
                if (hashedpw == "")
                {
                    MessageBox.Show("El usuario no existe");
                }
                lector.Close();
                return hashedpw;
                
            }
            catch (OdbcException)
            {
                MessageBox.Show("El usuario no existe");
                return hashedpw;
            }
            finally
            {
                //lector.Close();
                ConexionBD.GetConexionBD().Close();
            }            
        }
        //RENOMBRAR CLIENTE A USUARIO
        public static bool RegistrarCliente(Usuario c, int tipoUsuario)
        {
            string sentenciaSQL = "INSERT INTO usuario (nombre, " +
                "apellido, fecha_nacimiento, tipo_usuario, estado_usuario, email, genero,usr_login,usr_pw) " +
                "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            /*"VALUES (@nombre, @apellido, @fecha_nac, @tipo_usuario, @estado_usuario, @email, @genero, @usrlogin, @usrpw)";
             Esta forma no funciona debo usar los ? como en Java*/
            ConexionBD.GetConexionBD().Open();
            adaptador = new OdbcDataAdapter();
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.InsertCommand = new OdbcCommand(sentenciaSQL,ConexionBD.GetConexionBD());
            //OdbcCommand comando = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD()); El objeto OdbcComand se guarda en el Getter de adaptador InsertCommand
            //comando.Parameters.AddWithValue("@nombre", c.Nombre);

            adaptador.InsertCommand.Parameters.Add("@nombre", OdbcType.VarChar,30).Value = c.Nombre;
            adaptador.InsertCommand.Parameters.Add("@apellido", OdbcType.VarChar, 30).Value = c.Apellido;
            adaptador.InsertCommand.Parameters.Add("@fecha_nac", OdbcType.DateTime).Value = c.FechaNac;
            adaptador.InsertCommand.Parameters.Add("@tipo_usuario", OdbcType.Int).Value = tipoUsuario; //El usuario que se registre sera Cliente por default
            adaptador.InsertCommand.Parameters.Add("@estado_usuario", OdbcType.Int).Value = 2; //El estado del usuario cliente sera activo por default
            adaptador.InsertCommand.Parameters.Add("@email", OdbcType.VarChar,80).Value = c.Email;
            adaptador.InsertCommand.Parameters.Add("@genero", OdbcType.Char,1).Value = c.Genero;
            adaptador.InsertCommand.Parameters.Add("@usrlogin",OdbcType.VarChar,30).Value = c.Username;
            adaptador.InsertCommand.Parameters.Add("@usrpw", OdbcType.VarChar,60).Value = c.Pw;
                        
            //MessageBox.Show($"No se cual es el problema {adaptador.InsertCommand.CommandText}");
            try
            {                
                adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el usuario exitosamente");
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
        //Actualizar los datos del usuario desde la opcion de modificar perfil
        public static bool ActualizarDatosUsuario(Usuario c, string nombre, string apellido, string email, DateTime fechaNac)
        {

            string sentenciaSQL = "UPDATE usuario SET nombre = ?, " +
    "apellido = ?, fecha_nacimiento = ?, email = ? " +
    "WHERE id_usuario = ?";
            /*"VALUES (@nombre, @apellido, @fecha_nac, @tipo_usuario, @estado_usuario, @email, @genero, @usrlogin, @usrpw)";
             Esta forma no funciona debo usar los ? como en Java*/
            ConexionBD.GetConexionBD().Open();
            adaptador = new OdbcDataAdapter();
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.InsertCommand = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD());
            //OdbcCommand comando = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD()); El objeto OdbcComand se guarda en el Getter de adaptador InsertCommand
            //comando.Parameters.AddWithValue("@nombre", c.Nombre);

            adaptador.InsertCommand.Parameters.Add("@nombre", OdbcType.VarChar, 30).Value = nombre;
            adaptador.InsertCommand.Parameters.Add("@apellido", OdbcType.VarChar, 30).Value = apellido;
            adaptador.InsertCommand.Parameters.Add("@fecha_nac", OdbcType.DateTime).Value = fechaNac;                        
            adaptador.InsertCommand.Parameters.Add("@email", OdbcType.VarChar).Value = email;
            adaptador.InsertCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = c.IdUsuario;

            try
            {
                adaptador.InsertCommand.ExecuteNonQuery();
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
        public static bool ActualizarLlaveCliente(Usuario c, string haspw)
        {
            string sentenciaSQL = "UPDATE usuario SET usr_pw = ? " +
"WHERE id_usuario = ?";
            /*"VALUES (@nombre, @apellido, @fecha_nac, @tipo_usuario, @estado_usuario, @email, @genero, @usrlogin, @usrpw)";
             Esta forma no funciona debo usar los ? como en Java*/
            ConexionBD.GetConexionBD().Open();
            adaptador = new OdbcDataAdapter();
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.InsertCommand = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD());
            //OdbcCommand comando = new OdbcCommand(sentenciaSQL, ConexionBD.GetConexionBD()); El objeto OdbcComand se guarda en el Getter de adaptador InsertCommand
            //comando.Parameters.AddWithValue("@nombre", c.Nombre);

            adaptador.InsertCommand.Parameters.Add("@usrpw", OdbcType.VarChar, 30).Value = haspw;
            adaptador.InsertCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = c.IdUsuario;

            try
            {
                adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("La contraseña se actualizó exitosamente");
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

        public static DataTable GetTblClientes()
        {
            //CONSIDERAR QUE ESTE METODO REGRESE UNA LISTA DE CLIENTES O CREAR UN NUEVO METODO GetListaClientes
            //O UTILIZAR LINQ PARA HACER CONSULTAS A LOS DATATABLE
            consulta = "SELECT * FROM usuario WHERE tipo_usuario=3"; // El tipo de usuario clientes corresponde al tipo 3
            if (clientes == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    clientes = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(clientes); 

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(clientes);
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
            return clientes;
        }

        public static DataTable UpdateTblClientes()
        {
            consulta = "SELECT * FROM usuario WHERE tipo_usuario=3"; // El tipo de usuario clientes corresponde al tipo 3
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    clientes = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(clientes);

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(clientes);
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
            return clientes;
        }

        public static DataTable GetTblVets()
        {
            consulta = "SELECT * FROM usuario WHERE cat_tipo_usuario=2"; // El tipo de usuario vets corresponde al tipo 2
            if (vets == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    vets = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(vets);

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(vets);
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
            return vets;
        }

        public static DataTable GetTblAdmins()
        {
            consulta = "SELECT * FROM usuario WHERE cat_tipo_usuario=1"; // El tipo de usuario vets corresponde al tipo 2
            if (admins == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    admins = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(admins);

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(admins);
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
            return admins;
        }
    }
}
