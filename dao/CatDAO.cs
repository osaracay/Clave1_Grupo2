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
    /// <summary>
    /// Clase de acceso a dato a listas predefinidas en tablas de catálogo
    /// </summary>
    class CatDAO
    {
        private static string consulta;
        private static OdbcDataAdapter adaptador;
        private static OdbcDataReader lector;


        private static DataTable tipoInsumo;
        private static DataTable insumo;
        /*
        private static DataTable tipoUsuario;
        private static DataTable tipoCita;
        private static DataTable especie;
        private static DataTable estado;
        private static DataTable estadoCita;
        private static DataTable estadoPago;
        private static DataTable metPago;
        
        private static DataTable usuario;
        */
        //private static List<CatItem> listaTipoUsuarios; no creo que se ocupe esto
        //tipo Insumos es gestionado by MiltonDevAg
        private static List<CatItem> listaTipoCitas;
        private static List<CatItem> listaEspecies;
        private static List<CatItem> listaEstados; //Aplicables a Usuario y a Mascota
        private static List<CatItem> listaEstadosCita;
        private static List<CatItem> listaEstadosPago;
        private static List<CatItem> listaMetsPago;
        
        ///<summary>
        ///Clase de Acceso a Datos de las tablas cat_nombre_tabla
        ///Provee los datos a la clase Clave1_Grupo2.entity.CatItem
        ///</summary>
        
        /*Notar que los metodos que devuelven List<CatItem> solo cambia la consulta, 
         * el nombre de la lista
         * y los campos si incluye desc, pago y duracion*/
        public static List<CatItem> GetTipoCitas()
        {
            try
            {
                if (listaTipoCitas == null)
                {
                    listaTipoCitas = new List<CatItem>();
                    consulta = "SELECT * FROM cat_tipo_cita";
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                    //adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner;

                    ConexionBD.GetConexionBD().Open();
                    lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                    while (lector.Read())
                    {
                        CatItem tipoCita = new CatItem(lector.GetInt32(0), lector.GetString(1));
                        /* Considerar descartar la columna descripcion ya que los nombres ya son descriptivos
                        if (lector.GetString(2).GetType() == Type.GetType("System.DBNull"))
                        {
                            tipoCita.DescCat = "";
                        }
                        else
                        {
                            tipoCita.DescCat = lector.GetString(2); //cannot cast System.DBNull to System.String
                        }
                        //tipoCita.DescCat = lector.GetString(2); cannot cast System.DBNull to System.String
                        //MessageBox.Show($"Desc cita {tipoCita.DescCat} y \nvalor del lector {lector.GetString(2)}");
                        */
                        tipoCita.PrecioCat = (double)lector.GetDecimal(3);
                        tipoCita.DuracionMinutosCat = lector.GetInt32(4);
                        //Falta duracion de cita para ocupar al momento de definir los intervalos de tiempo
                        listaTipoCitas.Add(tipoCita);
                    }
                }
                //MessageBox.Show($"Número de ítems {listaTipoCitas.Count()}");
                ConexionBD.GetConexionBD().Close();                
                //Colocandolo aqui el cerrar conexion porque al llamarlo desde VtnMascotas en selected index changed
                //la primera vez que se selecciona un indice desde cuenta administrador dice que
                //la base de datos no se cierra pero la ejecucion continua
                //A pesar que hay un bloque Finally pero la excepcion ocurre antes del mensaje anterior
                //Y aqui lo pongo despues del mensaje 

                return listaTipoCitas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaTipoCitas;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }            
        }

        public static List<CatItem> GetEspecies()
        {
            try
            {
                if (listaEspecies == null)
                {
                    listaEspecies = new List<CatItem>();
                    consulta = "SELECT * FROM cat_especie";
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                    //adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner;

                    ConexionBD.GetConexionBD().Open();
                    lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                    while (lector.Read())
                    {
                        CatItem especie = new CatItem(lector.GetInt32(0), lector.GetString(1));
                        //tipoCita.DescCat = lector.GetString(2);
                        //tipoCita.PrecioCat = (double)lector.GetDecimal(3);
                        //Falta duracion de cita para ocupar al momento de definir los intervalos de tiempo
                        listaEspecies.Add(especie);
                    }
                }
                //MessageBox.Show($"Número de ítems {listaEspecies.Count()}");
                ConexionBD.GetConexionBD().Close();
                //Colocandolo aqui el cerrar conexion porque al llamarlo desde VtnMascotas en selected index changed
                //la primera vez que se selecciona un indice desde cuenta administrador dice que
                //la base de datos no se cierra pero la ejecucion continua
                //A pesar que hay un bloque Finally pero la excepcion ocurre antes del mensaje anterior
                //Y aqui lo pongo despues del mensaje 

                return listaEspecies;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaEspecies;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }

        public static List<CatItem> GetMetodosPago()
        {
            try
            {
                if (listaMetsPago == null)
                {
                    listaMetsPago = new List<CatItem>();
                    consulta = "SELECT * FROM cat_met_pago";
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                    //adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner;

                    ConexionBD.GetConexionBD().Open();
                    lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                    while (lector.Read())
                    {
                        CatItem metPago = new CatItem(lector.GetInt32(0), lector.GetString(1));
                        //tipoCita.DescCat = lector.GetString(2);
                        //tipoCita.PrecioCat = (double)lector.GetDecimal(3);
                        //Falta duracion de cita para ocupar al momento de definir los intervalos de tiempo
                        listaMetsPago.Add(metPago);
                    }
                }
                //MessageBox.Show($"Número de ítems {listaMetsPago.Count()}");
                ConexionBD.GetConexionBD().Close();
                //Colocandolo aqui el cerrar conexion porque al llamarlo desde VtnMascotas en selected index changed
                //la primera vez que se selecciona un indice desde cuenta administrador dice que
                //la base de datos no se cierra pero la ejecucion continua
                //A pesar que hay un bloque Finally pero la excepcion ocurre antes del mensaje anterior
                //Y aqui lo pongo despues del mensaje 

                return listaMetsPago;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaMetsPago;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }

        public static List<CatItem> GetEstadosPago()
        {
            try
            {
                if (listaEstadosPago == null)
                {
                    listaEstadosPago = new List<CatItem>();
                    consulta = "SELECT * FROM cat_estado_pago";
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                    //adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner;

                    ConexionBD.GetConexionBD().Open();
                    lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                    while (lector.Read())
                    {
                        CatItem estadoPago = new CatItem(lector.GetInt32(0), lector.GetString(1));
                        estadoPago.DescCat = lector.GetString(2); //Si esta nulo ver que se puede hacer
                        //tipoCita.PrecioCat = (double)lector.GetDecimal(3);
                        //Falta duracion de cita para ocupar al momento de definir los intervalos de tiempo
                        listaEstadosPago.Add(estadoPago);
                    }
                }
                //MessageBox.Show($"Número de ítems {listaEstadosPago.Count()}");
                ConexionBD.GetConexionBD().Close();
                //Colocandolo aqui el cerrar conexion porque al llamarlo desde VtnMascotas en selected index changed
                //la primera vez que se selecciona un indice desde cuenta administrador dice que
                //la base de datos no se cierra pero la ejecucion continua
                //A pesar que hay un bloque Finally pero la excepcion ocurre antes del mensaje anterior
                //Y aqui lo pongo despues del mensaje 

                return listaEstadosPago;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaEstadosPago;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }

        public static List<CatItem> GetEstadosCita()
        {
            try
            {
                if (listaEstadosCita == null)
                {
                    listaEstadosCita = new List<CatItem>();
                    consulta = "SELECT * FROM cat_estado_cita";
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.SelectCommand = new OdbcCommand(consulta, ConexionBD.GetConexionBD());
                    //adaptador.SelectCommand.Parameters.Add("@id_usuario", OdbcType.Int).Value = owner;

                    ConexionBD.GetConexionBD().Open();
                    lector = adaptador.SelectCommand.ExecuteReader(); //Execute nonquery requiere una conexion valida y activa por eso se abre. Para fill no se requiere se abre y cierra sola
                    while (lector.Read())
                    {
                        CatItem estadoCita = new CatItem(lector.GetInt32(0), lector.GetString(1));
                        estadoCita.DescCat = lector.GetString(2); //Si esta nulo ver que se puede hacer

                        listaEstadosCita.Add(estadoCita);
                    }
                }
                //MessageBox.Show($"Número de ítems {listaEstadosPago.Count()}");
                ConexionBD.GetConexionBD().Close();


                return listaEstadosCita;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaEstadosCita;
            }
            finally
            {
                lector.Close();
                ConexionBD.GetConexionBD().Close();
            }
        }
        /*
         * DATATABLES
         */
        public static DataTable GetTipoInsumo()
        {
            consulta = "SELECT * FROM cat_tipo_insumo";
            if (tipoInsumo == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    tipoInsumo = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(tipoInsumo); //Verificar si deberia agregarlo antes del fill o despues

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(tipoInsumo);
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
            return tipoInsumo;
        }

        public static DataTable GetInsumos()
        {
            consulta = "SELECT * FROM insumo";
            if (insumo == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    insumo = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(insumo); //Verificar si deberia agregarlo antes del fill o despues

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(insumo);
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
            return insumo;
        }



        /*
         * SIN USAR
         */

        /*REEMPLAZADOS DATATABLES POR LISTS
        public static DataTable GetEstadoPago()
        {
            consulta = "SELECT * FROM cat_estado_pago";
            if (estadoPago == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    estadoPago = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(estadoPago); //Verificar si deberia agregarlo antes del fill o despues

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(estadoPago);
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
            return estadoPago;
        }
        public static DataTable GetMetPago()
        {
            consulta = "SELECT * FROM cat_met_pago";
            if (metPago == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    metPago = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(metPago); //Verificar si deberia agregarlo antes del fill o despues

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(metPago);
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
            return metPago;
        }


        public static DataTable GetUsuarios()
        {
            consulta = "SELECT * FROM usuario";
            if (usuario == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    usuario = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(usuario); //Verificar si deberia agregarlo antes del fill o despues

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(usuario);
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
            return usuario;
        }
        public static DataTable GetTipoUsuario()
        {
            consulta = "SELECT * FROM cat_tipo_usuario";
            if (tipoUsuario == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    tipoUsuario = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(tipoUsuario); //Verificar si deberia agregarlo antes del fill o despues

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(tipoUsuario);
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
            return tipoUsuario;
        }
        public static DataTable GetEstadoCita()
        {
            consulta = "SELECT * FROM cat_estado_cita";
            if (estadoCita == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    estadoCita = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(estadoCita); //Verificar si deberia agregarlo antes del fill o despues
                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(estadoCita);
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
            return estadoCita;
        }
        public static DataTable GetEstado()
        {
            consulta = "SELECT * FROM cat_estado";
            if (estado == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    estado = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(estado); //Verificar si deberia agregarlo antes del fill o despues

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(estado);
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
            return estado;
        }

        public static DataTable GetTipoCita()
        {
            consulta = "SELECT * FROM cat_tipo_cita";
            if (tipoCita == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    tipoCita = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(tipoCita); //Verificar si deberia agregarlo antes del fill o despues

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(tipoCita);
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
            return tipoCita;
        }
        public static DataTable GetEspecie()
        {
            consulta = "SELECT * FROM cat_especie";
            if (especie == null)
            {
                try
                {
                    adaptador = new OdbcDataAdapter(consulta, ConexionBD.GetConexionBD());
                    especie = new DataTable();

                    //PENDIENTE Definir campos de tabla y agregar tabla al DataSet
                    ConexionBD.GetDataSetBD().Tables.Add(especie); //Verificar si deberia agregarlo antes del fill o despues

                    using (adaptador)
                    {
                        ConexionBD.GetConexionBD().Open();
                        adaptador.Fill(especie);
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

            return especie;
        }
        */
    }
}
