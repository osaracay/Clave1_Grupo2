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
        private List<Mascota> mascotas; //Procurar que no sea estatica, en caso quiera implementar 
        //llamar listas de mascotas por cada instancia cliente en una lista de clientes consultada
        //desde una Clase Vet o Admin

        //A la hora de iniciar sesion la clase usuario DAO crea una instancia del tipo 
        //Cliente, Admin, o Veterinario, con base en el tipo de Usuario. Asi, al obtener la sesion
        //Podra hacerse un explicit casting a la clase que simbolice el tipo de usuario
        //Y hacer uso de herencia y polimorfismo en C#. 
        public Cliente()
        {
        }

        public Cliente(string nombre, string apellido, DateTime fechaNac, string email, char genero, string username, string pw) : base(nombre, apellido, fechaNac, email, genero, username, pw)
        {
        }

        public Cliente(int idUsuario, string nombre, string apellido, DateTime fechaNac, int tipoUsuario, int estadoUsuario, string email, char genero, string username) : base(idUsuario, nombre, apellido, fechaNac, tipoUsuario, estadoUsuario, email, genero, username)
        {
        }

        public List<Mascota> GetMascotas()
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

        public override string ToString()
        {
            string stringCliente = $"{this.Nombre} {this.Apellido}";
            return stringCliente;
        }

    }
}
