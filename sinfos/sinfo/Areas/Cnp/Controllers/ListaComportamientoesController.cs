using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sinfo.Areas.Cnp.Models;
using System.Threading.Tasks;
using System.Net.Http;
using sinfo.Models;
using Newtonsoft.Json;

namespace sinfo.Areas.Cnp.Controllers
{
    public class ListaComportamientoesController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/ListaComportamientoes
        public ActionResult Index()
        {
            return View(db.ListaComportamiento.ToList());
        }

        // GET: Cnp/ListaComportamientoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListaComportamiento listaComportamiento = db.ListaComportamiento.Find(id);
            if (listaComportamiento == null)
            {
                return HttpNotFound();
            }
            return View(listaComportamiento);
        }

        // GET: Cnp/ListaComportamientoes/Create
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ListaComportamientoId,CodigoPonal,Descripcion,IdPapa,Vigente,IdTipo,Orden,IdTitulo,IdCapitulo,IdArticulo")] ListaComportamiento listaComportamiento)
        {
            if (ModelState.IsValid)
            {
                db.ListaComportamiento.Add(listaComportamiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(listaComportamiento);
        }

        public async Task<ActionResult> SincronizaComportamiento()
        {
            string username = "darwi.vasquez@correo.policia.gov.co";
            string password = "Policia2018*2019";
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://catalogoservicioweb.policia.gov.co");
            var url = "/sw/api/ListaValor/ConsultaComportamiento";
            var token = GeneradorToken.TokenPonal(username, password);
            client.DefaultRequestHeaders.Add("Authorization", token);
            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var result = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<List<DominioComportamiento>>(result);

            foreach (var item in resultado)
            {
                bool existe = db.ListaComportamiento.Any(x => x.CodigoPonal == item.ID_COMPORTAMIENTO);
                if (!existe)
                {
                    ListaComportamiento dato = new ListaComportamiento();
                    dato.CodigoPonal = Convert.ToInt32(item.ID_COMPORTAMIENTO);
                    dato.Descripcion = item.DESCRIPCION;
                    dato.IdPapa = Convert.ToDecimal(item.ID_PAPA);
                    dato.IdTipo = Convert.ToDecimal(item.ID_TIPO);
                    dato.Orden = item.ORDEN;
                    dato.IdTitulo = Convert.ToDecimal(item.ID_TITULO);
                    dato.IdCapitulo = Convert.ToDecimal(item.ID_CAPITULO);
                    dato.IdArticulo = Convert.ToDecimal(item.ID_ARTICULO);
                    dato.Vigente = true;
                    db.ListaComportamiento.Add(dato);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        // GET: Cnp/ListaComportamientoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListaComportamiento listaComportamiento = db.ListaComportamiento.Find(id);
            if (listaComportamiento == null)
            {
                return HttpNotFound();
            }
            return View(listaComportamiento);
        }

        // POST: Cnp/ListaComportamientoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ListaComportamientoId,CodigoPonal,Descripcion,IdPapa,Vigente,IdTipo,Orden,IdTitulo,IdCapitulo,IdArticulo")] ListaComportamiento listaComportamiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listaComportamiento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(listaComportamiento);
        }

        // GET: Cnp/ListaComportamientoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListaComportamiento listaComportamiento = db.ListaComportamiento.Find(id);
            if (listaComportamiento == null)
            {
                return HttpNotFound();
            }
            return View(listaComportamiento);
        }

        // POST: Cnp/ListaComportamientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ListaComportamiento listaComportamiento = db.ListaComportamiento.Find(id);
            db.ListaComportamiento.Remove(listaComportamiento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
