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
        
        public PartialViewResult Adicionar(string id)
        {
            return PartialView();
        }

    }
}