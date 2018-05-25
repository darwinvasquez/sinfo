using Comun.DTOs;
using Core.General;
using Core.General.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Areas.Cnp.Controllers
{
    public class BarriosController : Controller
    {
        public ActionResult Index()
        {
            IConsultarBarrios barrios = new BarrioRepositorio();
            return View(barrios.ConsultarBarrios());
        }

        [HttpGet]
        public ActionResult Adicionar() => View();       

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Adicionar(BarrioDTO _params)
        {
            string mensaje = string.Empty;

            if (!ModelState.IsValid)
            {
                return View(_params);
            }

            try
            {
                IAgregarBarrio barrio = new BarrioRepositorio();
                barrio.AgregarBarrio(_params, out mensaje);
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }
    }
}