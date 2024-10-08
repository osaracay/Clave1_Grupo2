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
        
        public void SetIdUsuario (int usuario)
        {
            this.idUsuario = usuario;
        }

        public int GetIdUsuario()
        {
            return idUsuario;
        }
    }
}
