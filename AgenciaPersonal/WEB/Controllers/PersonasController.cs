using ENTITIES;
using LOGIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            var personas = new PersonaLogic().GetAll();
            return View(personas);
        }

        [HttpPost]
        public ActionResult LoadPerson(persona newPersona)
        {
            new PersonaLogic().AddPerson(newPersona);
            return RedirectToAction("Index");
        }
    }
}