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
        private string motivoCita;
        private string sintomasMascota;
        private string diagnostico;
        private string tratamiento;
        private string observaciones;

        public int GetIdCita()
        {
            return idCita;
        }
        public void SetIdCita(int idCita)
        {
            this.idCita = idCita;
        }
        public int GetIdTipoCita()
        {
            return idTipoCita;
        }
        public void SetIdTipoCita(int idTipoCita)
        {
            this.idTipoCita = idTipoCita;
        }
        public int GetIdMascota()
        {
            return idMascota;
        }
        public void SetIdMascota(int idMascota)
        {
            this.idMascota = idMascota;
        }
        public int GetIdVet()
        {
            return idVet;
        }
        public void SetIdVet(int idVet)
        {
            this.idVet = idVet;
        }
        public int GetIdEstadoCita()
        {
            return idEstadoCita;
        }
        public void SetIdEstadoCita(int idEstadoCita)
        {
            this.idEstadoCita = idEstadoCita;
        }
        public string GetMotivoCita()
        {
            return motivoCita;
        }
        public void SetMotivoCita(string motivoCita)
        {
            this.motivoCita = motivoCita;
        }
        public string GetSintomasMascota()
        {
            return sintomasMascota;
        }
        public void SetSintomasMascota(string sintomasMascota)
        {
            this.sintomasMascota = sintomasMascota;
        }
        public string GetDiagnostico()
        {
            return diagnostico;
        }
        public void SetDiagnostico(string diagnostico)
        {
            this.diagnostico = diagnostico;
        }
        public string GetTratamiento()
        {
            return tratamiento;
        }
        public void SetTratamiento(string tratamiento)
        {
            this.tratamiento = tratamiento;
        }
        public string GetObservaciones()
        {
            return observaciones;
        }
        public void SetObservaciones(string observaciones)
        {
            this.observaciones = observaciones;
        }




    }
}
