using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seminarskiv1.EF;
using Seminarskiv1.EntityModels;
using Seminarskiv1.helper;
using Seminarskiv1.ViewModels.api;

namespace Seminarskiv1.Controllers.api
{
    public class KorisnikController : MyWebApiBaseController
    {
        public KorisnikController(MyContext db) : base(db)
        {
        }

        [HttpGet("{email}/{password}")]
        public PregledLogiranogKorisnikaVM LoginCheck(string email,string password)
        {
            PregledLogiranogKorisnikaVM Model = new PregledLogiranogKorisnikaVM();

            Korisnik k = _db.Korisnik.Where(x => x.Email == email && x.Password == password).SingleOrDefault();

            if (k != null)
            {
                Model.id = k.Id;
                Model.ime = k.Ime;
                Model.prezime = k.Prezime;
                Model.email = k.Email;
                Model.password = k.Password;
            }
            return Model;

        }



        [HttpPost]
        public IActionResult Add([FromBody]PregledLogiranogKorisnikaVM input)
        {


            Korisnik k = _db.Korisnik.Where(x => x.Email == input.email).SingleOrDefault();
            if (input.ime == "")
            {
                return StatusCode(500, "Ime je obavezno");
            }
            if (input.prezime == "")
            {
                return StatusCode(500, "Prezime je obavezno");
            }
            if (input.email == "")
            {
                return StatusCode(500, "Email je obavezan");
            }
            if (input.password == "")
            {
                return StatusCode(500, "Lozinka je obavezna");
            }

            if (k != null)
            {
                return StatusCode(500, "Email adresa je već iskorištena");
            }

            if (input.password.Length < 8)
            {
                return StatusCode(500, "Lozinka mora sadržavati minimalno 8 karaktera");
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(input.email);
            if (!match.Success)
                return StatusCode(500, "Email adresa nije validna");



            Korisnik newKorisnik = new Korisnik
            {
                Ime = input.ime,
                Prezime = input.prezime,
                Email = input.email,
                Password= input.password
            };
            _db.Korisnik.Add(newKorisnik);
            _db.SaveChanges();


            var result = _db.Korisnik
                    .Where(w => w.Id == newKorisnik.Id)
                    .Select(s => new PregledLogiranogKorisnikaVM
                    {
                        id = s.Id,
                        ime = s.Ime,
                        prezime = s.Prezime,
                        email=s.Email,
                        password=s.Password
                    })
                    .Single();

            return Ok(result);
        }
    }
}