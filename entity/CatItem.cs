using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    ///<summary>
    ///Simboliza los registros de tablas de Catalogos con listas predefinidas
    ///que por lo general poseen de 2 a 4 campos.
    ///La idea es crear Arrays o Lists con objetos tipo CatItem
    /// </summary>
    class CatItem
    {
        

        private int idCat;
        private string nomCat;
        private string descCat; //no todas las tablas Cat tienen desc
        private double precioCat; //Solo la tabla de tipo de cita tiene precio.
        private int duracionMinutosCat; //Solo la tabla tipo de cita
        public CatItem()
        {

        }

        public CatItem(int idCat, string nomCat)
        {
            this.IdCat = idCat;
            this.NomCat = nomCat;
        }

        public CatItem(int idCat, string nomCat, string descCat) : this(idCat, nomCat)
        {
            this.DescCat = descCat;
        }

        public CatItem(int idCat, string nomCat, string descCat, double precioCat) : this(idCat, nomCat, descCat)
        {
            this.PrecioCat = precioCat;
        }

        public int IdCat { get => idCat; set => idCat = value; }
        public string NomCat { get => nomCat; set => nomCat = value; }
        public string DescCat { get => descCat; set => descCat = value; }
        public double PrecioCat { get => precioCat; set => precioCat = value; }
        public int DuracionMinutosCat { get => duracionMinutosCat; set => duracionMinutosCat = value; }

        public override string ToString()
        {
            if (this.PrecioCat > 0)
            {
                return $"{this.NomCat} - ${this.PrecioCat} - {this.DuracionMinutosCat} min";
            }
            return this.NomCat;
        }
    }
}
