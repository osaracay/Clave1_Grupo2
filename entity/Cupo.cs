using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    /// <summary>
    /// Representa una instancia de cupo libre preparada para ser insertada en
    ///la base de datos como cupo reservado. Antes de crear una instancia
    ///cupo durante la ejecución del programa(runtime), se desea saber
    /// que cupos ya han sido reservados por veterinario y tipo de cita.
    /// Se generaran listas dinamicas de objetos cupo
    /// </summary>
    class Cupo
    {


        /* Pseudocodigo o Caso de Uso
        * 1 : Consultar cantidad de cupos tomados en la fecha y hora inicial 
        * crear una COPIA LOCAL (RUNTIME) de la tabla de reservaciones
        * y a partir de ahi excluir los veterinarios y horas que ya esten asignados
        * 2 : Definir fecha y hora inicial
        * 3 : Contar y mostrar vets disponibles para atender el cupo
        * 4 : De acuerdo con el tipo de cita y su duracion, definir la hora final
        * 5 : Que la hora final sea la hora inicial del siguiente cupo
        */
        private static DateTime fechaMaxAgendable;
        private static DateTime fechaMinAgendable; //Tendre que ir jugando con los limites

        private int idReservacion;
        //private Veterinario vetAsignado;
        private int idVetAsignado;        
        private bool estaReservado;

        private DateTime horaFin;
        private DateTime fechaCupo; //Considerar crear listas por fecha
                                    //o una sola lista con este campo para filtrar        
        private DateTime horaInicio;

        private int duracionMinutos;
        //El tipo de cita determina el precio y la duracion de una cita
        private int idTipoCita;


        public DateTime FechaCupo { get => fechaCupo; set => fechaCupo = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public int IdVetAsignado { get => idVetAsignado; set => idVetAsignado = value; }
        public bool EstaReservado { get => estaReservado; set => estaReservado = value; }
        public int IdReservacion { get => idReservacion; set => idReservacion = value; }
        public int DuracionMinutos { get => duracionMinutos; set => duracionMinutos = value; }
        public int IdTipoCita { get => idTipoCita; set => idTipoCita = value; }

        public Cupo()
        {
        }
        /// <summary>
        /// Constructor de cupos con base en fecha, hora de inicio y duracion en minutos
        /// </summary>
        /// <param name="fechaCupo">Es la fecha en la que se aparta el cupo en formato DD/MM/AAAA 00:00:00</param>
        /// <param name="horaInicio">La fecha de inicio a partir de la que se calcula la hora de finalizacion</param>
        /// <param name="duracionMinutos">Los minutos que se obtienen de la base de datos o segun el tipo de cita</param>
        public Cupo(DateTime fechaCupo, DateTime horaInicio, int duracionMinutos)
        {
            this.fechaCupo = fechaCupo.Date; //Toma solo la fecha con hora 0:00:00
            this.horaInicio = horaInicio; //Cada vez que se cree, debe ser con el constructor y agregando, horas y minutos a 0 o 30 segun corresponda            
            
            this.duracionMinutos = duracionMinutos;
            this.HoraFin = horaInicio.AddMinutes(duracionMinutos);
        }
        /* Ya resolvi limitar la fecha en el control DateTimePicker
        private static void InstanciarCamposEstaticos()
        {
            Tener cuidado que esto se instanciara cada que se cree 
             * un nuevo objeto cupo. 
        fechaMaxAgendable = DateTime.Today.AddDays(15);
            fechaMinAgendable = DateTime.Now.AddHours(2);
            
        }
        */

        public override string ToString()
        {
            return $"{this.HoraInicio.ToString("t")} - {this.HoraFin.ToString("t")}";
        }

    }
}
