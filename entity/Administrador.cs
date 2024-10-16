using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    class Administrador : Usuario
    {

        //A la hora de iniciar sesion la clase usuario DAO crea una instancia del tipo 
        //Cliente, Admin, o Veterinario, con base en el tipo de Usuario. Asi, al obtener la sesion
        //Podra hacerse un explicit casting a la clase que simbolice el tipo de usuario
        //Y hacer uso de herencia y polimorfismo en C#. 
        public Administrador()
        {
        }
        public Administrador(string nombre, string apellido, DateTime fechaNac, string email, char genero, string username, string pw) : base(nombre, apellido, fechaNac, email, genero, username, pw)
        {
        }
        public Administrador(int idUsuario, string nombre, string apellido, DateTime fechaNac, int tipoUsuario, int estadoUsuario, string email, char genero, string username) : base(idUsuario, nombre, apellido, fechaNac, tipoUsuario, estadoUsuario, email, genero, username)
        {
        }
    }
}
