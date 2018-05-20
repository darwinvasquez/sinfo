using Core.Cnp;
using Core.Cnp.Abstraccion;
using System.Web.Mvc;

namespace AppWeb.Areas.Cnp.Controllers
{
    public class CobroCoactivoController : Controller
    {
        // GET: Cnp/CobroCoactivo
        public ActionResult Index()
        {
            //IConsultarCobroCoactivo cobro = new Multa();
            //cobro.ConsultarCobroCoactivo();
            return View();
        }
    }
}