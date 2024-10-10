using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.entity
{
    class CatItem
    {
        ///<summary>
        ///Simboliza los registros de tablas de Catalogos con listas predefinidas
        ///que por lo general poseen de 2 a 4 campos.
        ///La idea es crear Arrays o Lists con objetos tipo CatItem
        /// </summary>

        private int idCat;
        private string nomCat;
        private string descCat; //no todas las tablas Cat tienen desc
        private double precioCat; //Solo la tabla de tipo de cita tiene precio.

        public CatItem()
        {

        }

        public CatItem(int idCat, string nomCat)
        {
            this.idCat = idCat;
            this.nomCat = nomCat;
        }

        public CatItem(int idCat, string nomCat, string descCat) : this(idCat, nomCat)
        {
            this.descCat = descCat;
        }

        public CatItem(int idCat, string nomCat, string descCat, double precioCat) : this(idCat, nomCat, descCat)
        {
            this.precioCat = precioCat;
        }
    }
}
