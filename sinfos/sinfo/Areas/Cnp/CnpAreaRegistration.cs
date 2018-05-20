using System.Web.Mvc;

namespace sinfo.Areas.Cnp
{
    public class CnpAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Cnp";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Cnp_default",
                "Cnp/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "AppWeb.Areas.Cnp.Controllers" }
            );
        }
    }
}