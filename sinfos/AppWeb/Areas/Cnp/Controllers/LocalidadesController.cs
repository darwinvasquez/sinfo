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
    public class LocalidadesController : Controller
    {
        public ActionResult Index()
        {
            IConsultarLocalidades localidad = new LocalidadRepositorio();
            return View(localidad.ConsultarLocalidades());
        }

        [HttpGet]
        public ActionResult Adicionar() => View();        

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Adicionar(LocalidadDTO _params)
        {
            string mensaje = string.Empty;

            if (!ModelState.IsValid)
            {
                return View(_params);
            }

            try
            {
                IAgregarLocalidad dato = new LocalidadRepositorio();
                dato.AgregarLocalidad(_params, out mensaje);
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }
    }
}