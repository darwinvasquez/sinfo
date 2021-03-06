﻿using Comun.DTOs;
using Core.General;
using Core.General.Abstraccion;
using System;
using System.Web.Mvc;

namespace AppWeb.Areas.Cnp.Controllers
{
    public class PaisesController : Controller
    {               
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Adicionar()
        {         
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Adicionar(PaisDTO _params)
        {
            string mensaje = string.Empty;

            if (!ModelState.IsValid)
            {
                return View(_params);
            }  

            try
            {
                IAgregarPais pais = new PaisRepositorio();
                pais.AgregarPais(_params, out mensaje);
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }

    }
}