using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    class Turno
    {
        //Clases para turnos y detalles de turno
        private int idTurno;
        private string nombreTurno;
        private DateTime horaInicio;
        private DateTime horaFin;
        private DateTime horaAlmuerzo;

        public int IdTurno { get => idTurno; set => idTurno = value; }
        public string NombreTurno { get => nombreTurno; set => nombreTurno = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public DateTime HoraAlmuerzo { get => horaAlmuerzo; set => horaAlmuerzo = value; }

        public override string ToString()
        {
            string turnoString = $"{this.NombreTurno} : {this.HoraInicio.ToString("t")} - {this.HoraFin.ToString("t")}";
            return turnoString;
        }
    }
}
