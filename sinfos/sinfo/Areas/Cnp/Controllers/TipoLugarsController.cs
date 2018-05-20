using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sinfo.Areas.Cnp.Models;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using sinfo.Models;
using System.Threading.Tasks;

namespace sinfo.Areas.Cnp.Controllers
{
    public class TipoLugarsController : Controller
    {
        private ContextCnp db = new ContextCnp();
       

        // GET: Cnp/TipoLugars
        public ActionResult Index()
        {
            return View(db.TipoLugar.ToList());
        }

        // GET: Cnp/TipoLugars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLugar tipoLugar = db.TipoLugar.Find(id);
            if (tipoLugar == null)
            {
                return HttpNotFound();
            }
            return View(tipoLugar);
        }

        // GET: Cnp/TipoLugars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cnp/TipoLugars/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoLugarId,Descripcion,Vigente")] TipoLugar tipoLugar)
        {
            if (ModelState.IsValid)
            {
                db.TipoLugar.Add(tipoLugar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoLugar);
        } 
        
        public async Task<ActionResult> SincronizaTipoLugar()
        {
            string username = "darwi.vasquez@correo.policia.gov.co";
            string password = "Policia2018*2019";
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://catalogoservicioweb.policia.gov.co");
            var url = "/sw/api/ListaValor/ConsultaTipoLugar";             
            var token = GeneradorToken.TokenPonal(username, password);
            client.DefaultRequestHeaders.Add("Authorization", token);
            var response =  await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            
            var result = await response.Content.ReadAsStringAsync();            
            var tipoLugar = JsonConvert.DeserializeObject<List<DominioPonal>>(result);              

            foreach (var item in tipoLugar)
            {
                bool existe = db.TipoLugar.Any(x => x.CodigoPonal == item.ID_DOMINIO);
                if(!existe)
                {
                    TipoLugar tipo = new TipoLugar();
                    tipo.CodigoPonal = Convert.ToInt32(item.ID_DOMINIO);
                    tipo.Descripcion = item.DESCRIPCION;
                    tipo.Vigente = true;
                    db.TipoLugar.Add(tipo);
                    db.SaveChanges();
                }
            }            

            return RedirectToAction("Index");
        }        



        // GET: Cnp/TipoLugars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLugar tipoLugar = db.TipoLugar.Find(id);
            if (tipoLugar == null)
            {
                return HttpNotFound();
            }
            return View(tipoLugar);
        }

        // POST: Cnp/TipoLugars/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoLugarId,Descripcion,Vigente")] TipoLugar tipoLugar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoLugar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoLugar);
        }

        // GET: Cnp/TipoLugars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLugar tipoLugar = db.TipoLugar.Find(id);
            if (tipoLugar == null)
            {
                return HttpNotFound();
            }
            return View(tipoLugar);
        }

        // POST: Cnp/TipoLugars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoLugar tipoLugar = db.TipoLugar.Find(id);
            db.TipoLugar.Remove(tipoLugar);
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
