using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinfo.Areas.Cnp.Controllers
{
    public class NotificacionController : Controller
    {
        // GET: Cnp/Notificacion
        public ActionResult SinPermiso(string usuario, string ul)
        {
            ViewBag.SINPERMISOS = usuario + " " + ul;
            return View();
        }
    }
}