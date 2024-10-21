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
        private int idVet;
        private int idDetalleTurno;
        private char descanso1;
        private char descanso2;

        public int IdTurno { get => idTurno; set => idTurno = value; }
        public string NombreTurno { get => nombreTurno; set => nombreTurno = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public DateTime HoraAlmuerzo { get => horaAlmuerzo; set => horaAlmuerzo = value; }
        public int IdVet { get => idVet; set => idVet = value; }
        public int IdDetalleTurno { get => idDetalleTurno; set => idDetalleTurno = value; }
        public char Descanso1 { get => descanso1; set => descanso1 = value; }
        public char Descanso2 { get => descanso2; set => descanso2 = value; }

        public override string ToString()
        {
            string turnoString = $"{this.NombreTurno} : {this.HoraInicio.ToString("t")} - {this.HoraFin.ToString("t")}";
            return turnoString;
        }
    }
}
