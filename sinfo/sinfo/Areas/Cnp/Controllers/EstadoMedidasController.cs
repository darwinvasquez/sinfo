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
using Newtonsoft.Json;
using sinfo.Models;

namespace sinfo.Areas.Cnp.Controllers
{
    public class EstadoMedidasController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/EstadoMedidas
        public ActionResult Index()
        {
            return View(db.EstadoMedida.ToList());
        }

        // GET: Cnp/EstadoMedidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoMedida estadoMedida = db.EstadoMedida.Find(id);
            if (estadoMedida == null)
            {
                return HttpNotFound();
            }
            return View(estadoMedida);
        }

        // GET: Cnp/EstadoMedidas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cnp/EstadoMedidas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstadoMedidaId,CodigoPonal,Descripcion,Vigente")] EstadoMedida estadoMedida)
        {
            if (ModelState.IsValid)
            {
                db.EstadoMedida.Add(estadoMedida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadoMedida);
        }

        public async Task<ActionResult> SincronizaEstadoMedida()
        {
            string username = "darwi.vasquez@correo.policia.gov.co";
            string password = "Policia2018*2019";

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://catalogoservicioweb.policia.gov.co");
            var url = "/sw/api/ListaValor/ConsultaEstadoMedida";
            var token = GeneradorToken.TokenPonal(username, password);
            client.DefaultRequestHeaders.Add("Authorization", token);
            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var result = await response.Content.ReadAsStringAsync();
            var datos = JsonConvert.DeserializeObject<List<DominioPonal>>(result);

            foreach (var item in datos)
            {
                bool existe = db.EstadoMedida.Any(x => x.CodigoPonal == item.ID_DOMINIO);
                if (!existe)
                {
                    EstadoMedida dato = new EstadoMedida();
                    dato.CodigoPonal = Convert.ToInt32(item.ID_DOMINIO);
                    dato.Descripcion = item.DESCRIPCION;
                    dato.Vigente = true;
                    db.EstadoMedida.Add(dato);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        // GET: Cnp/EstadoMedidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoMedida estadoMedida = db.EstadoMedida.Find(id);
            if (estadoMedida == null)
            {
                return HttpNotFound();
            }
            return View(estadoMedida);
        }

        // POST: Cnp/EstadoMedidas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstadoMedidaId,CodigoPonal,Descripcion,Vigente")] EstadoMedida estadoMedida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadoMedida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadoMedida);
        }

        // GET: Cnp/EstadoMedidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoMedida estadoMedida = db.EstadoMedida.Find(id);
            if (estadoMedida == null)
            {
                return HttpNotFound();
            }
            return View(estadoMedida);
        }

        // POST: Cnp/EstadoMedidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstadoMedida estadoMedida = db.EstadoMedida.Find(id);
            db.EstadoMedida.Remove(estadoMedida);
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
