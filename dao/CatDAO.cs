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
    class CatDAO
    {
        private static string consulta;
        private static OdbcDataAdapter adaptador;

        private static DataTable tipoUsuario;
        private static DataTable tipoInsumo;
        private static DataTable tipoCita;
        private static DataTable especie;
        private static DataTable estado;
        private static DataTable estadoCita;
        private static DataTable estadoPago;
        private static DataTable metPago;
        private static DataTable insumo;

        ///<summary>
        ///Clase de Acceso a Datos de las tablas cat_nombre_tabla
        ///Provee los datos a la clase Clave1_Grupo2.entity.CatItem
        ///</summary>

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
                }catch(Exception e)
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
    }
}
