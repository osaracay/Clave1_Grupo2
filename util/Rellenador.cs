using Clave1_Grupo2.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.util
{
    class Rellenador
    {
        private static DataTableReader lector;
        private static List<Mascota> mascotas; //Se lo pasare a la lista de mascotas del Usuario
        
        /*PARA DATATABLES OBTENIDOS DE LA BASE DE DATOS*/
        public static void CargarDataTableACombo(ComboBox cb, DataTable dataTable, string campoId, string mostrarCampo)
        {

            cb.DataSource = dataTable;
            cb.DisplayMember = mostrarCampo;
            cb.ValueMember = campoId;
            cb.SelectedIndex = -1; //0 o -1
        }

        public static void CargarDataTableAListBox(ListBox lb, DataTable dataTable)
        {
            //mascotas = new List<Mascota>();
            /*try
            {

                lector = new DataTableReader(dataTable);
                while (lector.Read())
                {
                    Mascota mascota = new Mascota();
                    mascota.SetIdmascota(lector.GetInt32(0));
                    mascota.SetNomMascota(lector.GetString(1));
                    mascota.SetEspecie(lector.GetInt32(2)); // Aqui pudiera ocupar el Join para mostrar la especie
                    mascota.SetRaza(lector.GetString(3));
                    mascota.SetEdad(lector.GetInt32(4));
                    mascota.SetGeneroMascota(lector.GetChar(5));
                    mascota.SetIdPropietario(lector.GetInt32(6));
                    mascota.EstadoMascota = lector.GetInt32(7);
                    //FALTARIA EL COLOR                    
                    mascotas.Add(mascota);
                }
                

        }
            catch (OdbcException)
            {
                MessageBox.Show("Ocurrio un error al leer los datos.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("El datatable es nulo");
            }
            /*finally
            {
                //lector.Close();
                //ConexionBD.GetConexionBD().Close();
            }*/

            lb.DataSource = dataTable;
            //cb.DisplayMember = mostrarCampo;
            //cb.ValueMember = campoId;
            //cb.SelectedIndex = -1; //0 o -1
        }
    }
}
