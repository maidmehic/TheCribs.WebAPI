using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seminarskiv1.EF;
using Seminarskiv1.EntityModels;
using Seminarskiv1.helper;
using Seminarskiv1.ViewModels.api;

namespace Seminarskiv1.Controllers.api
{
    public class SpasenSmjestajController : MyWebApiBaseController
    {
        public SpasenSmjestajController(MyContext db) : base(db)
        {
        }

        [HttpGet("{korisnikId}/{stanId}")]
        public PregledSpasenogSmjestajaVM Index(int korisnikId, int stanId)
        {
            SpasenSmjestaj ss = _db.SpasenSmjestaj.Where(x => x.KorisnikId == korisnikId && x.StanId == stanId).SingleOrDefault();

            PregledSpasenogSmjestajaVM Model = new PregledSpasenogSmjestajaVM();
            if (ss != null) {
                Model.id = ss.Id;
                Model.stanId = ss.StanId;
                Model.korisnikId = ss.KorisnikId;
            }
            
            return Model;
        }

        [HttpPost]
        public PregledSpasenogSmjestajaVM Add([FromBody]NoviSpasenSmjestajVM input)
        {
            SpasenSmjestaj spasen= new SpasenSmjestaj
            {
                KorisnikId=input.korisnikId,
                StanId=input.stanId
            };
            _db.SpasenSmjestaj.Add(spasen);
            _db.SaveChanges();

            SpasenSmjestaj ss = _db.SpasenSmjestaj.Where(x=>x.Id==spasen.Id).SingleOrDefault();

            PregledSpasenogSmjestajaVM Model = new PregledSpasenogSmjestajaVM();
            if (ss != null)
            {
                Model.id = ss.Id;
                Model.stanId = ss.StanId;
                Model.korisnikId = ss.KorisnikId;
            }

            return Model;

        }

        [HttpDelete("{korisnikId}/{stanId}")]
        public ActionResult Remove(int korisnikId,int stanId)
        {
            SpasenSmjestaj ss = _db.SpasenSmjestaj.Where(x => x.KorisnikId == korisnikId && x.StanId == stanId).SingleOrDefault();

            if (ss != null)
            {
                _db.SpasenSmjestaj.Remove(ss);
                _db.SaveChanges();
            }
            return Ok();
        }
    }
}