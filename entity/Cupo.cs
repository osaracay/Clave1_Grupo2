using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    class Cupo
    {
        /*Representa una instancia de cupo libre preparada para ser insertada en
        * la base de datos como cupo reservado. Antes de crear una instancia 
        * cupo durante la ejecución del programa (runtime), se desea saber
        * que cupos ya han sido reservados por veterinario y tipo de cita.
        * Se generaran listas dinamicas de objetos cupo 
        *
         */
        private int idReservacion;
        private DateTime fechaCupo; //Considerar crear listas por fecha
                                    //o una sola lista con este campo para filtrar
        private DateTime horaInicio;

        //El tipo de cita determina el precio y la duracion de una cita
        private DateTime horaFin;
        //private Veterinario vetAsignado;
        private int idVetAsignado;
        private bool estaReservado;

        public DateTime FechaCupo { get => fechaCupo; set => fechaCupo = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public int IdVetAsignado { get => idVetAsignado; set => idVetAsignado = value; }
        public bool EstaReservado { get => estaReservado; set => estaReservado = value; }
        public int IdReservacion { get => idReservacion; set => idReservacion = value; }
        /* Pseudocodigo o Caso de Uso
* 1 : Consultar cantidad de cupos tomados en la fecha y hora inicial 
* crear una COPIA LOCAL (RUNTIME) de la tabla de reservaciones
* y a partir de ahi excluir los veterinarios y horas que ya esten asignados
* 2 : Definir fecha y hora inicial
* 3 : Contar y mostrar vets disponibles para atender el cupo
* 4 : De acuerdo con el tipo de cita y su duracion, definir la hora final
* 5 : Que la hora final sea la hora inicial del siguiente cupo
*/
    }
}
