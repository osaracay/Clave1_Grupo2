using Clave1_Grupo2.dao;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    class Cliente : Usuario
    {
        private static List<Mascota> mascotas;
        private static OdbcDataReader lector;

        //A la hora de iniciar sesion la clase usuario DAO crea una instancia del tipo 
        //Cliente, Admin, o Veterinario, con base en el tipo de Usuario. Asi, al obtener la sesion
        //Podra hacerse un explicit casting a la clase que simbolice el tipo de usuario
        //Y hacer uso de herencia y polimorfismo en C#. 

        public static List<Mascota> GetMascotas()
        {
            //Hare uso de un Data Table para crear las instancias tipo Mascota que agregare a la lista
            if(mascotas != null)
            {

            }
            else
            {
                mascotas = MascotaDAO.GetListaMascotasOwner(UsuarioDAO.GetSesion());
                //lector = new OdbcDataReader();
            }
            
            return mascotas;
        }

    }
}
