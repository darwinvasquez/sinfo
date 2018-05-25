using Core.General;
using Core.General.Abstraccion;
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

        public JsonResult ConsultarDepartamentos()
        {
            IConsultarDepartamento dato = new DepartamentoRepositorio();
            var datos = dato.ConsultarDepartamento();
            return Json(new SelectList(datos, "DepartamentoId", "Descripcion"));
        }

        public JsonResult ConsultarMunicipios()
        {
            IConsultarMunicipios dato = new MunicipioRepositorio();
            var datos = dato.ConsultarMunicipios();
            return Json(new SelectList(datos, "MunicipioId", "Descripcion"));
        }

        public JsonResult ConsultarLocalidadesPorMunicipio(string _municipioId)
        {
            IConsultarLocalidadesPorMunicipio dato = new LocalidadRepositorio();
            var datos = dato.ConsultarLocalidadesPorMunicipio(_municipioId);
            return Json(new SelectList(datos, "LocalidadId", "Descripcion"));
        }

        public JsonResult ConsultarBarrios()
        {
            IConsultarBarrios dato = new BarrioRepositorio();
            var datos = dato.ConsultarBarrios();
            return Json(new SelectList(datos, "LocalidadId", "Descripcion"));
        }

        public JsonResult ConsultarBarriosPorMuncipio(string _municipioId)
        {
            IConsultarBarriosPorMunicipio dato = new BarrioRepositorio();
            var datos = dato.ConsultarBarriosPorMunicipio(_municipioId);
            return Json(new SelectList(datos, "BarrioId", "Descripcion"));
        }

    }
}