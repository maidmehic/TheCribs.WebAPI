using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seminarskiv1.EF;
using Seminarskiv1.helper;
using Seminarskiv1.ViewModels.api;

namespace Seminarskiv1.Controllers.api
{
    public class StanController : MyWebApiBaseController
    {
        public StanController(MyContext db) : base(db)
        {
        }

        public PregledStanovaVM Index()
        {
            var model = new PregledStanovaVM
            {
                podaci = _db.Stan.OrderByDescending(x=>x.DatumObjave)
                    .Select(s => new PregledStanovaVM.Rows
                    {
                        Id = s.Id,
                        KategorijaId = s.KategorijaId,
                        Naziv = s.Naziv,
                        Cijena = s.Cijena,
                        DatumObjave = s.DatumObjave.ToString("dd.MM.yyyy")                        

                    }).ToList()
            };


            return model;
        }

        [HttpGet("{kategorijaId}")]
        public PregledStanovaVM PregledPoKategorijama(int kategorijaId)
        {
            var model = new PregledStanovaVM
            {
                podaci = _db.Stan.OrderByDescending(x=>x.DatumObjave).Where(x=>x.KategorijaId==kategorijaId)
                    .Select(s => new PregledStanovaVM.Rows
                    {
                        Id = s.Id,
                        KategorijaId = s.KategorijaId,
                        Naziv = s.Naziv,
                        Cijena = s.Cijena,
                        DatumObjave = s.DatumObjave.ToString("dd.MM.yyyy")

                    }).ToList()
            };


            return model;
        }

        [HttpGet("{gradId}")]
        public PregledStanovaVM PregledPoGradovima(int gradId)
        {
            var model = new PregledStanovaVM
            {
                podaci = _db.Stan.OrderByDescending(x => x.DatumObjave).Where(x => x.GradId == gradId)
                    .Select(s => new PregledStanovaVM.Rows
                    {
                        Id = s.Id,
                        KategorijaId = s.KategorijaId,
                        Naziv = s.Naziv,
                        Cijena = s.Cijena,
                        DatumObjave = s.DatumObjave.ToString("dd.MM.yyyy")

                    }).ToList()
            };


            return model;
        }

        [HttpGet("{korisnikId}")]
        public PregledStanovaVM PregledSpasenogSmjestaja(int korisnikId)
        {
            var model = new PregledStanovaVM
            {
                podaci = _db.SpasenSmjestaj.Where(x => x.KorisnikId == korisnikId).Include(x=>x.Korisnik).Include(x=>x.Stan)
                    .Select(s => new PregledStanovaVM.Rows
                    {
                        Id = s.Stan.Id,
                        KategorijaId = s.Stan.KategorijaId,
                        Naziv = s.Stan.Naziv,
                        Cijena = s.Stan.Cijena,
                        DatumObjave = s.Stan.DatumObjave.ToString("dd.MM.yyyy")

                    }).ToList()
            };
            return model;
        }
    }
}