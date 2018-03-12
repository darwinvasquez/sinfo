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
    public class CodigoResponsesController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/CodigoResponses
        public ActionResult Index()
        {
            return View(db.CodigoResponse.ToList());
        }

        // GET: Cnp/CodigoResponses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodigoResponse codigoResponse = db.CodigoResponse.Find(id);
            if (codigoResponse == null)
            {
                return HttpNotFound();
            }
            return View(codigoResponse);
        }

        // GET: Cnp/CodigoResponses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cnp/CodigoResponses/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CodigoResponse codigoResponse)
        {
            if (ModelState.IsValid)
            {
                db.CodigoResponse.Add(codigoResponse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(codigoResponse);
        }

        // GET: Cnp/CodigoResponses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodigoResponse codigoResponse = db.CodigoResponse.Find(id);
            if (codigoResponse == null)
            {
                return HttpNotFound();
            }
            return View(codigoResponse);
        }

        // POST: Cnp/CodigoResponses/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoResponseId,Descripcion,Vigente")] CodigoResponse codigoResponse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(codigoResponse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(codigoResponse);
        }

        // GET: Cnp/CodigoResponses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodigoResponse codigoResponse = db.CodigoResponse.Find(id);
            if (codigoResponse == null)
            {
                return HttpNotFound();
            }
            return View(codigoResponse);
        }

        // POST: Cnp/CodigoResponses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CodigoResponse codigoResponse = db.CodigoResponse.Find(id);
            db.CodigoResponse.Remove(codigoResponse);
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
