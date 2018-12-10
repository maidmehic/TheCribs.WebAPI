using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarskiv1.EntityModels
{
    public class DetaljiStana
    {
        public int Id { get; set; }

        
        public string BrojSoba { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }


        public Stan Stan { get; set; }
        public int StanId { get; set; }

      


        //dodati sliku

    }
}
