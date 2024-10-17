using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private int tipoUsuario;
        private int estadoUsuario;
        private string email;
        private char genero; //Debe ser M, F, o X
        private string username;
        private string pw; //Debe ser menor a 60; caracteres para que se acepte en la bd

        public Usuario() { }

        //Revisar para que sirve etiqueta param

        /// <summary>
        /// Constructor para registrar usuario sin tipo ni estado
        /// </summary>
        public Usuario(string nombre, string apellido, DateTime fechaNac, string email, char genero, string username, string pw)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            Email = email;
            Genero = genero;
            Username = username;
            Pw = pw;
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            TipoUsuario = tipoUsuario;
            EstadoUsuario = estadoUsuario;
            Email = email;
            Genero = genero;
            Username = username;
            Pw = pw;
        }

        
        public Usuario(int idUsuario, string nombre, string apellido, DateTime fechaNac, int tipoUsuario, int estadoUsuario, string email, char genero, string username)
        {
            //Constructor para consultas SELECT. No deseamos la contrasena en tiempo de ejecucion
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.tipoUsuario = tipoUsuario;
            this.estadoUsuario = estadoUsuario;
            this.email = email;
            this.genero = genero;
            this.username = username;
        }

        public override string ToString()
        {
            string stringCliente = $"{this.Username} - {this.Nombre} {this.Apellido}";
            return stringCliente;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public int EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public string Email { get => email; set => email = value; }
        public char Genero { get => genero; set => genero = value; }
        public string Username { get => username; set => username = value; }
        public string Pw { get => pw; set => pw = value; }
    }
}
