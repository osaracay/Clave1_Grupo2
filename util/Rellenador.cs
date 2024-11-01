using Clave1_Grupo2.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            cb.DisplayMember = "ToString";
            cb.DataSource = lista;
        }
        public static void CargarListaAComboBox(ComboBox cb, List<Turno> lista)
        {
            cb.ValueMember = "IdTurno";
            cb.DisplayMember = "ToString";
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
        /// <summary>
        /// Abre un cuadro de diálogo para seleccionar imágenes jpg, png.
        /// La imagen seleccionada será cargado a un picture box.
        /// </summary>
        /// <param name="pb">Picture box sobre el que se cargará la imagen seleccionada</param>
        public static void SeleccionarImagen(PictureBox pb)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imágenes (jpg,png) | *.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Escoge una foto";
            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pb.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }
        /// <summary>
        /// Obtiene un arreglo de bytes correspondiente a la imagen mostrada en un picturebox.
        /// Dicho arreglo de bytes puede guardarse luego en la base de datos en un campo Longblob.
        /// </summary>
        /// <param name="pb">picturebox que contiene la imagen sobre la que se obtendrá el arreglo de bytes</param>
        /// <returns>Arreglo de bytes de una imagen</returns>
        public static byte[] GetByteArrayDePicBox(PictureBox pb)
        {
            MemoryStream flujoMemo = new MemoryStream();
            pb.Image.Save(flujoMemo, ImageFormat.Jpeg);
            //byte[] aByte = flujoMemo.ToArray();
            return flujoMemo.ToArray();
        }
    }
}
