using Clave1_Grupo2.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
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
        private static List<Usuario> listaUsuarios;
        private static List<Usuario> listaClientes;
        private static List<Usuario> listaVets;
        //private static List<> detalleTurnos; //HACER UN JOIN

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

        //QUIERO CREAR LISTAS DE USUARIOS PARA LLENAR COMBOBOXES O LISTBOXES
        public static List<Usuario> GetListaUsuarios(int tipoUsuario)
        {
            consulta = "SELECT * FROM usuario WHERE tipo_usuario= ?";
            adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
            adaptador.SelectCommand.Parameters.Add("@tipo_usuario", OdbcType.Int).Value = tipoUsuario;
            
            try
            {
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                
                //PODRIA HABER OCUPADO UN SWITCH CASE
                if (tipoUsuario == 3) //Aqui puede suceder un relajo si le paso un Usuario de tipo distinto de 3
                {
                    listaClientes = new List<Usuario>();
                    //listaClientes = new List<Cliente>();
                    while (lector.Read())
                    {
                        Cliente m = new Cliente(); //Puede ser un cliente, Admin o Vet
                        m.IdUsuario = lector.GetInt32(0); //int
                        m.Nombre = lector.GetString(1);
                        m.Apellido = lector.GetString(2);
                        m.FechaNac = lector.GetDate(3); //Date
                        m.TipoUsuario = lector.GetInt32(4);
                        m.EstadoUsuario = lector.GetInt32(5);
                        m.Email = lector.GetString(6);
                        m.Genero = lector.GetChar(7);
                        m.Username = lector.GetString(8);
                        listaClientes.Add(m);
                    }
                    //MessageBox.Show($"Cantidad de clientes {listaClientes.Count}");
                    return listaClientes;
                }
                else if (tipoUsuario == 2)
                {
                    listaVets = new List<Usuario>(); // Suponiendo que esto limpia la lista
                    while (lector.Read())
                    {
                        
                        Veterinario m = new Veterinario(); //Puede ser un cliente, Admin o Vet
                        m.IdUsuario = lector.GetInt32(0); //int
                        m.Nombre = lector.GetString(1);
                        m.Apellido = lector.GetString(2);
                        m.FechaNac = lector.GetDate(3); //Date
                        m.TipoUsuario = lector.GetInt32(4);
                        m.EstadoUsuario = lector.GetInt32(5);
                        m.Email = lector.GetString(6);
                        m.Genero = lector.GetChar(7);
                        m.Username = lector.GetString(8);
                        listaVets.Add(m);
                    }
                    //MessageBox.Show($"Cantidad de Veterinarios {listaVets.Count}");
                    return listaVets;
                }
                else
                {
                    listaUsuarios = new List<Usuario>();
                    while (lector.Read())
                    {
                        Administrador m = new Administrador(); //Puede ser un cliente, Admin o Vet
                        m.IdUsuario = lector.GetInt32(0); //int
                        m.Nombre = lector.GetString(1);
                        m.Apellido = lector.GetString(2);
                        m.FechaNac = lector.GetDate(3); //Date
                        m.TipoUsuario = lector.GetInt32(4);
                        m.EstadoUsuario = lector.GetInt32(5);
                        m.Email = lector.GetString(6);
                        m.Genero = lector.GetChar(7);
                        m.Username = lector.GetString(8);
                        listaUsuarios.Add(m);
                    }
                    //MessageBox.Show($"Cantidad de Administradores {listaUsuarios.Count}");
                    return listaUsuarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se encontraron usuarios del tipo indicado u otro error: \n{ex.Message}");                
                return null;
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
        /// <summary>
        /// Recibe un arreglo de bytes correspondiente a una imagen y lo perpetua en una cuenta de usuario.
        /// </summary>
        /// <param name="imagen">Arreglo de bytes correspondiente a una imagen.</param>
        /// <param name="idUsuario">Cuenta de usuario.</param>
        /// <returns></returns>
        public static bool GuardarImagen(byte[] imagen, int idUsuario)
        {
            consulta = "UPDATE usuario SET pic_usuario = ? " +
                            " WHERE id_usuario=?";            
            
            adaptador = new OdbcDataAdapter();
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.InsertCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
            
            adaptador.InsertCommand.Parameters.Add("@pic", OdbcType.Binary).Value = imagen; //This types to an array of type byte.            
            adaptador.InsertCommand.Parameters.Add("@usuario", OdbcType.Int).Value = idUsuario;
            try
            {
                ConexionBD.GetConexionBD().Open();
                adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Se ha guardado la foto exitosamente.");
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

        public static bool CargarImagenAPictureBox(PictureBox pb, int idUsuario)
        {
            consulta = "SELECT pic_usuario FROM usuario WHERE id_usuario=?";
            
                //comando
                adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = idUsuario;
            try
            {
                //Recuerdo que con el lector no se abria la bd pues lo hacia por su cuenta.
                ConexionBD.GetConexionBD().Open();
                lector = adaptador.SelectCommand.ExecuteReader();
                //reader
                if (lector.Read())
                {                    
                    byte[] imagen = (byte[])lector["pic_usuario"];
                    MemoryStream flujoMemo = new MemoryStream(imagen);
                    Bitmap bm = new Bitmap(flujoMemo);
                    pb.Image = bm;
                    return true;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                    return false;
                }

            }catch(Exception e) {
                MessageBox.Show($"Ocurrio un error :\n{e.Message}");
                //Buscar excepciones en conexion con bd
                //Y al convertir a byte
                return false;
            }
            finally
            {
                ConexionBD.GetConexionBD().Close();
            }
        }
    }
}
