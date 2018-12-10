using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarskiv1.EntityModels
{
    public class Stan
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Cijena{ get; set; }
        public DateTime DatumObjave{ get; set; }

        public Kategorija Kategorija { get; set; }
        public int KategorijaId { get; set; }

        public Grad Grad { get; set; }
        public int GradId { get; set; }
        //Ubaciti sliku

        public byte[] Slika { get; set; }
    }
}
