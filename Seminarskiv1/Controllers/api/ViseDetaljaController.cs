using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seminarskiv1.EF;
using Microsoft.EntityFrameworkCore;
using Seminarskiv1.EntityModels;
using Seminarskiv1.helper;
using Seminarskiv1.ViewModels.api;

namespace Seminarskiv1.Controllers.api
{
    public class ViseDetaljaController : MyWebApiBaseController
    {
        public ViseDetaljaController(MyContext db) : base(db)
        {
        }

        [HttpGet("{detaljiId}")]
        public PregedViseDetaljaVM Index(int detaljiId)
        {

            ViseDetalja detalji = _db.ViseDetalja.Include(x => x.DetaljiStana).Include(x=>x.DetaljiStana.Stan).Where(x => x.DetaljiStanaId == detaljiId).Single();


            PregedViseDetaljaVM Model = new PregedViseDetaljaVM {

                datumObjave =  detalji.DetaljiStana.Stan.DatumObjave.ToString("dd.MM.yyyy"),
                adresa =detalji.DetaljiStana.Adresa,
                godIzgradnje=detalji.GodIzgradnje,
                vrstaGrijanja = detalji.VrstaGrijanja,
                vrstaPlacanja = detalji.VrstaPlacanja,
                balkon = detalji.Balkon,
                parking = detalji.Parking,
                klima = detalji.Klima,
                kablovska = detalji.Kablovska,
                internet = detalji.Internet,
                telefon = detalji.Telefon,
                email = detalji.Email,
                vrstaPoda=detalji.VrstaPoda,
                primarnaOrjentacija=detalji.PrimarnaOrjentacija,
                kvadrata=detalji.Kvadrata,
                videoNadzor=detalji.VideoNadzor,
                blindiranaVrata=detalji.BlindiranaVrata
                
            };
            return Model;
        }
    }
}