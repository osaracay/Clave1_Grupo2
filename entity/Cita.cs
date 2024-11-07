using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    class Cita
    {
        private int idCita;
        //private int idHorario;
        private int idTipoCita;
        private int idMascota;
        private int idVet;
        private int idEstadoCita;
        private int idCupo;
        private Cupo cupo;
        private string motivoCita;
        private string sintomasMascota;
        private string diagnostico;
        private string tratamiento;
        private string observaciones;
        private int idPropietario;

        public int IdCita { get => idCita; set => idCita = value; }
        public int IdTipoCita { get => idTipoCita; set => idTipoCita = value; }
        public int IdMascota { get => idMascota; set => idMascota = value; }
        public int IdVet { get => idVet; set => idVet = value; }
        public int IdEstadoCita { get => idEstadoCita; set => idEstadoCita = value; }
        public int IdCupo { get => idCupo; set => idCupo = value; }
        public string MotivoCita { get => motivoCita; set => motivoCita = value; }
        public string SintomasMascota { get => sintomasMascota; set => sintomasMascota = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        internal Cupo Cupo { get => cupo; set => cupo = value; }

        public override string ToString()
        {
            string citastring = $"{this.Cupo.FechaCupo.ToString("d")}: {this.Cupo.HoraInicio.ToString("t")} - {this.Cupo.HoraFin.ToString("t")}";
            return citastring;
        }
    }
}
