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

        private static DataTable clientes;
        private static DataTable vets;
        private static DataTable admins;


        public static bool RegistrarCliente(Usuario c)
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
            adaptador.InsertCommand.Parameters.Add("@tipo_usuario", OdbcType.Int).Value = 3; //El usuario que se registre sera Cliente por default
            adaptador.InsertCommand.Parameters.Add("@estado_usuario", OdbcType.Int).Value = 2; //El estado del usuario cliente sera activo por default
            adaptador.InsertCommand.Parameters.Add("@email", OdbcType.VarChar,80).Value = c.Email;
            adaptador.InsertCommand.Parameters.Add("@genero", OdbcType.Char,1).Value = c.Genero;
            adaptador.InsertCommand.Parameters.Add("@usrlogin",OdbcType.VarChar,30).Value = c.Username;
            adaptador.InsertCommand.Parameters.Add("@usrpw", OdbcType.VarChar,60).Value = c.Pw;
                        
            //MessageBox.Show($"No se cual es el problema {adaptador.InsertCommand.CommandText}");
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

        public static DataTable GetTblClientes()
        {
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
