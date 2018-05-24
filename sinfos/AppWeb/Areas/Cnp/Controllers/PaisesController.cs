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
    public class PaisesController : Controller
    {
        string mensaje = string.Empty;

        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Adicionar()
        {         
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Adicionar(PaisDTO _params)
        {
            

            if (!ModelState.IsValid)
            {
                return View(_params);
            }                   

            try
            {
                IAgregarPais pais = new PaisRepositorio();
                pais.AgregarPais(_params, out mensaje);

            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }

    }
}