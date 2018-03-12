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
    public class StatusCodeWebServicesController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/StatusCodeWebServices
        public ActionResult Index()
        {
            return View(db.StatusCodeWebService.ToList().OrderByDescending(x => x.StatusCodeWebServiceId));
        }

        // GET: Cnp/StatusCodeWebServices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusCodeWebService statusCodeWebService = db.StatusCodeWebService.Find(id);
            if (statusCodeWebService == null)
            {
                return HttpNotFound();
            }
            return View(statusCodeWebService);
        }

        // GET: Cnp/StatusCodeWebServices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cnp/StatusCodeWebServices/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StatusCodeWebServiceId,Accion,Usuario,Url,PropietarioSw,FechaRegistro,Vigente")] StatusCodeWebService statusCodeWebService)
        {
            if (ModelState.IsValid)
            {
                db.StatusCodeWebService.Add(statusCodeWebService);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statusCodeWebService);
        }

        // GET: Cnp/StatusCodeWebServices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusCodeWebService statusCodeWebService = db.StatusCodeWebService.Find(id);
            if (statusCodeWebService == null)
            {
                return HttpNotFound();
            }
            return View(statusCodeWebService);
        }

        // POST: Cnp/StatusCodeWebServices/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StatusCodeWebServiceId,Accion,Usuario,Url,PropietarioSw,FechaRegistro,Vigente")] StatusCodeWebService statusCodeWebService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusCodeWebService).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statusCodeWebService);
        }

        // GET: Cnp/StatusCodeWebServices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusCodeWebService statusCodeWebService = db.StatusCodeWebService.Find(id);
            if (statusCodeWebService == null)
            {
                return HttpNotFound();
            }
            return View(statusCodeWebService);
        }

        // POST: Cnp/StatusCodeWebServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StatusCodeWebService statusCodeWebService = db.StatusCodeWebService.Find(id);
            db.StatusCodeWebService.Remove(statusCodeWebService);
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
