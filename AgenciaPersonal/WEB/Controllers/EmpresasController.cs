using LOGIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class EmpresasController : Controller
    {
        // GET: Empresas
        public ActionResult Index()
        {
            var empresas = new EmpresaLogic().GetAll();
            return View(empresas);
        }
    }
}