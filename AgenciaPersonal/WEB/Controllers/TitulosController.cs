using LOGIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class TitulosController : Controller
    {
        // GET: Titulos
        public ActionResult Index()
        {
            var titulos = new TituloLogic().GetAll();
            return View(titulos);
        }
    }
}