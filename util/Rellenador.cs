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
        /*PARA DATATABLES OBTENIDOS DE LA BASE DE DATOS*/
        public static void CargarDataTableACombo(ComboBox cb, DataTable dataTable, string campoId, string mostrarCampo)
        {

            cb.DataSource = dataTable;
            cb.DisplayMember = mostrarCampo;
            cb.ValueMember = campoId;
            cb.SelectedIndex = -1; //0 o -1
        }

        public static void CargarListaPetAListBox(ListBox lb, List<Mascota> lista)
        {
            lb.DataSource = lista;
        }
        public static void CargarListaAComboBox(ComboBox cb, List<CatItem> lista)
        {
            cb.ValueMember = "IdCat";
            cb.DisplayMember = "NomCat";
            cb.DataSource = lista;
        }
        public static void CargarListaAComboBox(ComboBox cb, List<Mascota> lista)
        {
            cb.ValueMember = "idMascota";
            cb.DisplayMember = "ToString";
            cb.DataSource = lista;
        }
        public static void CargarListaAComboBox(ComboBox cb, List<Usuario> lista)
        {
            //Por lo que veo, es mejor crear metodos separados que devuelvan listas del tipo requerido
            cb.ValueMember = "IdUsuario";
            cb.DisplayMember = "ToString"; //Wow, lo hice. Ocupe el metodo To String como DisplayMember y ahora hago uso de polimorfismo T.T
            cb.DataSource = lista;
        }
        
        /*
         * SIN USAR
         */
        public static void CargarDataTableAListBox(ListBox lb, DataTable dataTable)
        {
            lb.DataSource = dataTable;
        }

        /*listas por tipo de usuario*/
        public static void CargarListaAComboBox(ComboBox cb, List<Cliente> lista)
        {
            cb.ValueMember = "IdUsuario";
            cb.DisplayMember = "ToString"; //Wow, lo hice. Ocupe el metodo To String como DisplayMember y ahora hago uso de polimorfismo T.T
            cb.DataSource = lista;
        }
        public static void CargarListaAComboBox(ComboBox cb, List<Veterinario> lista)
        {
            cb.ValueMember = "IdUsuario";
            cb.DisplayMember = "ToString"; //Wow, lo hice. Ocupe el metodo To String como DisplayMember y ahora hago uso de polimorfismo T.T
            cb.DataSource = lista;
        }
        public static void CargarListaAComboBox(ComboBox cb, List<Administrador> lista)
        {
            cb.ValueMember = "IdUsuario";
            cb.DisplayMember = "ToString"; //Wow, lo hice. Ocupe el metodo To String como DisplayMember y ahora hago uso de polimorfismo T.T
            cb.DataSource = lista;
        }
    }
}
