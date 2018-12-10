using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarskiv1.ViewModels.api
{
    public class PregedGradovaVM
    {
       public class Rows
        {
            public int id;
            public string Naziv;
        }

        public List<Rows> podaci;
    }
}
