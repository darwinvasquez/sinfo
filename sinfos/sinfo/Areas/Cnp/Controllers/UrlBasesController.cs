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
    public class UrlBasesController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/UrlBases
        public ActionResult Index()
        {
            return View(db.UrlBase.ToList());
        }

        // GET: Cnp/UrlBases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrlBase urlBase = db.UrlBase.Find(id);
            if (urlBase == null)
            {
                return HttpNotFound();
            }
            return View(urlBase);
        }

        // GET: Cnp/UrlBases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cnp/UrlBases/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UrlBaseId,Descripcion,Vigente")] UrlBase urlBase)
        {
            if (ModelState.IsValid)
            {
                db.UrlBase.Add(urlBase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(urlBase);
        }

        // GET: Cnp/UrlBases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrlBase urlBase = db.UrlBase.Find(id);
            if (urlBase == null)
            {
                return HttpNotFound();
            }
            return View(urlBase);
        }

        // POST: Cnp/UrlBases/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UrlBaseId,Descripcion,Vigente")] UrlBase urlBase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(urlBase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(urlBase);
        }

        // GET: Cnp/UrlBases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrlBase urlBase = db.UrlBase.Find(id);
            if (urlBase == null)
            {
                return HttpNotFound();
            }
            return View(urlBase);
        }

        // POST: Cnp/UrlBases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UrlBase urlBase = db.UrlBase.Find(id);
            db.UrlBase.Remove(urlBase);
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
