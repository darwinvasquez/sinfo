using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comun.DTOs;
using Core.General;
using Core.General.Abstraccion;


namespace AppWeb.Areas.Cnp.Controllers
{
    public class MunicipiosController : Controller
    {       
        public ActionResult Index()
        {
            IConsultarMunicipios municipio = new MunicipioRepositorio();
            return View(municipio.ConsultarMunicipios());
        }


        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Adicionar(MunicipioDTO _params)
        {
            string mensaje = string.Empty;

            if (!ModelState.IsValid)
            {
                return View(_params);
            }

            try
            {
                IAgregarMunicipio dato = new MunicipioRepositorio();
                dato.AgregarMunicipio(_params, out mensaje);
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }

    }
}