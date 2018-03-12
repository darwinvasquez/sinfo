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
    public class UsuarioAutorizadoesController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/UsuarioAutorizadoes
        public ActionResult Index()
        {
            return View(db.UsuarioAutorizado.ToList());
        }

        // GET: Cnp/UsuarioAutorizadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioAutorizado usuarioAutorizado = db.UsuarioAutorizado.Find(id);
            if (usuarioAutorizado == null)
            {
                return HttpNotFound();
            }
            return View(usuarioAutorizado);
        }

        // GET: Cnp/UsuarioAutorizadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cnp/UsuarioAutorizadoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioAutorizadoId,Usuario,Password,Alcaldia,FechaInicio,FechaFinal")] UsuarioAutorizado usuarioAutorizado)
        {
            if (ModelState.IsValid)
            {
                db.UsuarioAutorizado.Add(usuarioAutorizado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuarioAutorizado);
        }

        // GET: Cnp/UsuarioAutorizadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioAutorizado usuarioAutorizado = db.UsuarioAutorizado.Find(id);
            if (usuarioAutorizado == null)
            {
                return HttpNotFound();
            }
            return View(usuarioAutorizado);
        }

        // POST: Cnp/UsuarioAutorizadoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioAutorizadoId,Usuario,Password,Alcaldia,FechaInicio,FechaFinal")] UsuarioAutorizado usuarioAutorizado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuarioAutorizado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuarioAutorizado);
        }

        // GET: Cnp/UsuarioAutorizadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioAutorizado usuarioAutorizado = db.UsuarioAutorizado.Find(id);
            if (usuarioAutorizado == null)
            {
                return HttpNotFound();
            }
            return View(usuarioAutorizado);
        }

        // POST: Cnp/UsuarioAutorizadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsuarioAutorizado usuarioAutorizado = db.UsuarioAutorizado.Find(id);
            db.UsuarioAutorizado.Remove(usuarioAutorizado);
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
