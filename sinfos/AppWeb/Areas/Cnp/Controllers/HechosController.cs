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
    public class HechosController : Controller
    {
        // GET: Cnp/Hechos
        public ActionResult Index()
        {
            IListarHechosVerbalAbreviado hechos = new HechoRepositorio();

            var datos = hechos.ListarHechosVerbalAbreviado();

            return View(datos);
        }
       
        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Adicionar(CnpHechoDTO _cnpHechosDto)
        {
            if (ModelState.IsValid)
            {     
                IRegistrarProcesoVerbalAbreviado proceso = new RegistrarProcesoVerbalAbreviado();

                _cnpHechosDto.IdMunicipio = 6058;               
                    try
                    {

                    }
                    catch (Exception ex)
                    {

                    }               
            }           

            return View(_cnpHechosDto);
          
        }
        
        //public PartialViewResult InfoHecho(string id)
        //{
            
        //}
           
        
        
        public ActionResult VariosCampos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VariosCampos(List<CnpPersona> model)
        {


            return View();
        }

    }
}