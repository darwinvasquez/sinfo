using Comun.DTOs;
using Core.General;
using Core.General.Abstraccion;
using System;
using System.Web.Mvc;

namespace AppWeb.Areas.Cnp.Controllers
{
    public class DepartamentosController : Controller
    {
        // GET: Cnp/Departamentos
        public ActionResult Index()
        {
            IConsultarDepartamento departamentos = new DepartamentoRepositorio();
            return View(departamentos.ConsultarDepartamento());
        }


        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Adicionar(DepartamentoDTO _params)
        {
            string mensaje = string.Empty;

            if (!ModelState.IsValid)
            {
                return View(_params);
            }

            try
            {
                IAgregarDepartamento dato = new DepartamentoRepositorio();
                dato.AgregarDepartamento(_params, out mensaje);
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }
    }
}