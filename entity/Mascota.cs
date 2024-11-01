using Clave1_Grupo2.dao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    class Mascota
    {
        private byte[] imagen;
        private int idMascota;
        private string nomMascota;
        private int especie;
        //private string especie; 
        private string raza;
        private int edad;
        private char generoMascota;
        private int idPropietario;
        private int estadoMascota;
        //ESTADO COMO QUE FALTA
        private string color;
        public List<Cita> citas;

        public string Color { get => color; set => color = value; }
        public int EstadoMascota { get => estadoMascota; set => estadoMascota = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }

        public Mascota()
        {
        }


        //Constructor para consultas
        public Mascota(int idMascota, string nomMascota, int especie, string raza, int edad, char generoMascota, int idPropietario, string color)
        {
            this.idMascota = idMascota;
            this.nomMascota = nomMascota;
            this.especie = especie;
            this.raza = raza;
            this.edad = edad;
            this.generoMascota = generoMascota;
            this.idPropietario = idPropietario;
        }
        //Constructor para nuevos registros
        public Mascota(string nomMascota, int especie, string raza, int edad, char generoMascota, int idPropietario, string color)
        {
            this.nomMascota = nomMascota;
            this.especie = especie;
            this.raza = raza;
            this.edad = edad;
            this.generoMascota = generoMascota;
            this.idPropietario = idPropietario;
        }
        //Constructor para nuevos registros sin color
        public Mascota(string nomMascota, int especie, string raza, int edad, char generoMascota, int idPropietario)
        {
            this.nomMascota = nomMascota;
            this.especie = especie;
            this.raza = raza;
            this.edad = edad;
            this.generoMascota = generoMascota;
            this.idPropietario = idPropietario;
        }

        public int GetIdMascota() 
        { 
            return idMascota;
        }
        public void SetIdmascota(int idMascota)
        {
            this.idMascota = idMascota;
        }

        public string GetNomMascota()
        {
            return nomMascota;
        }
        public void SetNomMascota(string nomMascota)
        {
            this.nomMascota= nomMascota;
        }

        public string GetNomEspecie(int especie)
        {
            foreach (CatItem e in CatDAO.GetEspecies())
            {
                if (e.IdCat == especie) return e.NomCat;
            }
            return "especie desconocida";
        }

        public int GetEspecie()
        {
            return especie;
        }
        public void SetEspecie(int especie)
        {
            this.especie = especie;
        }

        public string GetRaza()
        {
            return raza;
        }
        public void SetRaza(string raza)
        {
            this.raza = raza;
        }

        public int GetEdad()
        { 
            return edad; 
        }
        public void SetEdad(int edad)
        { 
            this.edad = edad; 
        }

        public char GetGeneroMascota()
        { 
            return generoMascota; 
        }
        public void SetGeneroMascota(char generoMascota)
        {
            this.generoMascota = generoMascota;
        }

        public int GetIdPropietario()
        {
            return idPropietario;
        }
        public void SetIdPropietario(int idPropietario)
        {
            this.idPropietario = idPropietario;
        }

        public override string ToString()
        {
            string stringMascota = $"{this.GetNomMascota()} - {this.GetNomEspecie(this.GetEspecie())}"; //+ " - " +  quisiera que aqui me indicara la especie
            return stringMascota;
        }
    }
}
