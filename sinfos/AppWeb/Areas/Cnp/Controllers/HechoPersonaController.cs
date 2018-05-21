using Core.Cnp;
using Core.Cnp.Abstraccion;
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
        public ActionResult Agregar(string id)
        {
            IConsultarHechosVerbalAbreviadoId hecho = new HechoRepositorio();
            var datos = hecho.ConsultarHechosVerbalAbreviadoId(id);
            return View(datos);
        }
    }
}