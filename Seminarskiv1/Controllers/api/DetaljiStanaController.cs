using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seminarskiv1.EF;
using Seminarskiv1.EntityModels;
using Seminarskiv1.helper;
using Seminarskiv1.ViewModels.api;

namespace Seminarskiv1.Controllers.api
{
    public class DetaljiStanaController : MyWebApiBaseController
    {
        public DetaljiStanaController(MyContext db) : base(db)
        {
        }

        [HttpGet("{stanId}")]
        public PregledDetaljaStanaVM Index(int stanId)
        {
            DetaljiStana detalji = _db.DetaljiStana.Include(x=>x.Stan).Include(x=>x.Stan.Grad).Where(x => x.StanId == stanId).Single();

            PregledDetaljaStanaVM model = new PregledDetaljaStanaVM
            {
                id = detalji.Id,
                naziv = detalji.Stan.Naziv,
                brojSoba = detalji.BrojSoba,
                grad = detalji.Stan.Grad.Naziv,
                stanId = detalji.StanId,
                adresa=detalji.Adresa,
                opis=detalji.Opis,
                cijena=detalji.Stan.Cijena
            };
            return model;
        }
    }
}