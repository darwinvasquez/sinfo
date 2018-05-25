using Comun.DTOs;
using Core.Cnp;
using Core.Cnp.Abstraccion;
using Core.Cnp.Reglas;
using Core.General;
using Core.General.Abstraccion;
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
            ViewBag.MunicipioId = "eabbfb57-c667-4290-907b-0aeaddeed9b7";     
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Adicionar(CnpHechoDTO _cnpHechosDto)
        {

            _cnpHechosDto.PaisId = "3fd8ceba-dfda-4afa-82f4-d519ac0bdb2b";
            _cnpHechosDto.DepartamentoId = "eb8ade7e-e532-4c1c-9a6e-57c138232b8c";
            _cnpHechosDto.MunicipioId = "eabbfb57-c667-4290-907b-0aeaddeed9b7";
            _cnpHechosDto.FuenteId = "Alcaldía de la Unión";

            if (ModelState.IsValid)
            {     
                IRegistrarProcesoVerbalAbreviado proceso = new RegistrarProcesoVerbalAbreviado();

                _cnpHechosDto.MunicipioId = "";               
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