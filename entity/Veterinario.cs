using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    class Veterinario : Usuario
    {
        public List<Cita> citas;
        private int idDetalleTurno;
        private string nombreTurno;
        private DateTime horaIniTurno, horaFinTurno, horaAlmuerzo;
        private char diaDescanso1, diaDescanso2;

        //A la hora de iniciar sesion la clase usuario DAO crea una instancia del tipo 
        //Cliente, Admin, o Veterinario, con base en el tipo de Usuario. Asi, al obtener la sesion
        //Podra hacerse un explicit casting a la clase que simbolice el tipo de usuario
        //Y hacer uso de herencia y polimorfismo en C#. 
        public Veterinario()
        {
        }
        public Veterinario(string nombre, string apellido, DateTime fechaNac, string email, char genero, string username, string pw) : base(nombre, apellido, fechaNac, email, genero, username, pw)
        {
        }
        public Veterinario(int idUsuario, string nombre, string apellido, DateTime fechaNac, int tipoUsuario, int estadoUsuario, string email, char genero, string username) : base(idUsuario, nombre, apellido, fechaNac, tipoUsuario, estadoUsuario, email, genero, username)
        {
        }

        public int IdDetalleTurno { get => idDetalleTurno; set => idDetalleTurno = value; }
        public DateTime HoraIniTurno { get => horaIniTurno; set => horaIniTurno = value; }
        public DateTime HoraFinTurno { get => horaFinTurno; set => horaFinTurno = value; }
        public DateTime HoraAlmuerzo { get => horaAlmuerzo; set => horaAlmuerzo = value; }
        public char DiaDescanso1 { get => diaDescanso1; set => diaDescanso1 = value; }
        public char DiaDescanso2 { get => diaDescanso2; set => diaDescanso2 = value; }
        public string NombreTurno { get => nombreTurno; set => nombreTurno = value; }

        public override string ToString()
        {
            
            string stringVet= $"Dr. {this.Apellido}, {this.Nombre}";
            if(this.NombreTurno=="") stringVet+= $" - {this.NombreTurno}";
            return stringVet;
        }

    }
}
