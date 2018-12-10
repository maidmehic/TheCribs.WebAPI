using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seminarskiv1.EF;
using Seminarskiv1.helper;
using Seminarskiv1.ViewModels.api;

namespace Seminarskiv1.Controllers.api
{
    public class GradController : MyWebApiBaseController
    {
        public GradController(MyContext db) : base(db)
        {
        }

        [HttpGet]
        public PregedGradovaVM Index()
        {
            return Index("");
        }

        [HttpGet("{naziv}")]
        public PregedGradovaVM Index(string naziv)
        {

            PregedGradovaVM Model = new PregedGradovaVM();

            Model.podaci = _db.Grad.Where(x=>x.Naziv.ToLower().StartsWith(naziv.ToLower())).
                Select(x => new PregedGradovaVM.Rows
                {
                    id = x.Id,
                    Naziv = x.Naziv

                }).ToList();


            return Model;
        }
    }
}