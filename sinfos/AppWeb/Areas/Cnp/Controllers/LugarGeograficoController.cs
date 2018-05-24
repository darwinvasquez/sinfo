using Core.General;
using Core.General.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Areas.Cnp.Controllers
{
    public class LugarGeograficoController : Controller
    {
        public JsonResult ConsultarPaises()
        {
            IConsultarPais paises = new LugarGeografico();
            var datos = paises.ConsultarPais();
            return Json(new SelectList(datos, "PaisId", "Descripcion"));
        }

        public JsonResult ConsultarBarrio()
        {
            IConsultarPais paises = new LugarGeografico();
            var datos = paises.ConsultarPais();
            return Json(new SelectList(datos, "PaisId", "Descripcion"));
        }

    }
}