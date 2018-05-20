using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sinfo.Areas.Cnp.Models;

namespace sinfo.Areas.Cnp.Controllers
{
    public class UrlServicioWebsController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/UrlServicioWebs
        public ActionResult Index()
        {
            return View(db.UrlServicioWeb.ToList());
        }

        // GET: Cnp/UrlServicioWebs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrlServicioWeb urlServicioWeb = db.UrlServicioWeb.Find(id);
            if (urlServicioWeb == null)
            {
                return HttpNotFound();
            }
            return View(urlServicioWeb);
        }

        // GET: Cnp/UrlServicioWebs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cnp/UrlServicioWebs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UrlServicioWebId,Metodo,Url,NombreServicio,DescripcionServicio,Propietario")] UrlServicioWeb urlServicioWeb)
        {
            if (ModelState.IsValid)
            {
                db.UrlServicioWeb.Add(urlServicioWeb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(urlServicioWeb);
        }

        // GET: Cnp/UrlServicioWebs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrlServicioWeb urlServicioWeb = db.UrlServicioWeb.Find(id);
            if (urlServicioWeb == null)
            {
                return HttpNotFound();
            }
            return View(urlServicioWeb);
        }

        // POST: Cnp/UrlServicioWebs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UrlServicioWebId,Metodo,Url,NombreServicio,DescripcionServicio,Propietario")] UrlServicioWeb urlServicioWeb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(urlServicioWeb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(urlServicioWeb);
        }

        // GET: Cnp/UrlServicioWebs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrlServicioWeb urlServicioWeb = db.UrlServicioWeb.Find(id);
            if (urlServicioWeb == null)
            {
                return HttpNotFound();
            }
            return View(urlServicioWeb);
        }

        // POST: Cnp/UrlServicioWebs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UrlServicioWeb urlServicioWeb = db.UrlServicioWeb.Find(id);
            db.UrlServicioWeb.Remove(urlServicioWeb);
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
