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
        private int idMascota;
        private string nomMascota;
        private int especie;
        private string raza;
        private int edad;
        private char generoMascota;
        private int idPropietario;
        public List<Cita> citas;


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

    }
}
