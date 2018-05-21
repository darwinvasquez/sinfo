using Comun.DTOs;
using Core.Cnp;
using Core.Cnp.Abstraccion;
using Core.Cnp.Reglas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Areas.Cnp.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Cnp/Personas
        
        public PartialViewResult Adicionar(string hechoId)
        {
            ViewBag.HechoId = hechoId;
            return PartialView();
        }

        public ActionResult GuardarPersona(PersonaDTO _params)
        {
            IRegistrarPersonaHecho persona = new RegistrarPersonaHecho();

            persona.AdicionarPersonaHecho(_params);

            return RedirectToAction("Agregar", "HechoPersona", new { id = _params.HechoId});
        }


        public PartialViewResult ObtenerPeresonaIdHechos(string id)
        {
            IConsultarPersonaPorIdHecho consulta = new PersonaRepositorio();
            var datos = consulta.ConsultarPersonaPorIdHecho(id);
            return PartialView(datos);
        }


        public ActionResult Index(string id)
        {
            return View();
        }

    }
}