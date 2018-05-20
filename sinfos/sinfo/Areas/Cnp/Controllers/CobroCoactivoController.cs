using System.Web.Mvc;

namespace sinfo.Areas.Cnp.Controllers
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