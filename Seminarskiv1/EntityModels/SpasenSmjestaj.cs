using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarskiv1.EntityModels
{
    public class SpasenSmjestaj
    {
        public int Id { get; set; }

        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }

        public Stan Stan { get; set; }
        public int StanId { get; set; }
    }
}
