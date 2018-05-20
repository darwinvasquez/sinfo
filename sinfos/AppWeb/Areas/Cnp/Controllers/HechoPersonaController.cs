using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Areas.Cnp.Controllers
{
    public class HechoPersonaController : Controller
    {
        // GET: Cnp/HechoPersona
        public ActionResult Adicionar(string id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}