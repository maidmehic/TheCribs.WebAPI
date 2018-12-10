using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarskiv1.EntityModels
{
    public class ViseDetalja
    {
        public int Id { get; set; }

        public DetaljiStana DetaljiStana { get; set; }
        public int DetaljiStanaId { get; set; }

        
        public string GodIzgradnje { get; set; }
        public string VrstaGrijanja { get; set; }
        public string VrstaPlacanja { get; set; }
        public string VrstaPoda { get; set; }
        public string PrimarnaOrjentacija { get; set; }
        public string Kvadrata { get; set; }

        public bool Balkon { get; set; }
        public bool Parking { get; set; }
        public bool Klima { get; set; }
        public bool Kablovska { get; set; }
        public bool Internet { get; set; }
        public bool VideoNadzor { get; set; }
        public bool BlindiranaVrata { get; set; }

        public string Telefon { get; set; }
        public string Email { get; set; }

    }
}
