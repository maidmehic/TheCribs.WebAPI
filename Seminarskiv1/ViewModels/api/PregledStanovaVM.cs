using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarskiv1.ViewModels.api
{
    public class PregledStanovaVM
    {
        public class Rows
        {
            public int Id;
            public int KategorijaId;
            public string Naziv;
            public string DatumObjave;
            public double Cijena;
        }

        public List<Rows> podaci;
    }
}
