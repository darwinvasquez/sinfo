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
    public class PermisoServicioWebsController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/PermisoServicioWebs
        public ActionResult Index()
        {
            var permisoServicioWeb = db.PermisoServicioWeb.Include(p => p.UrlBase).Include(p => p.UrlServicioWeb).Include(p => p.UsuarioAutorizado);
            return View(permisoServicioWeb.ToList());
        }

        // GET: Cnp/PermisoServicioWebs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermisoServicioWeb permisoServicioWeb = db.PermisoServicioWeb.Find(id);
            if (permisoServicioWeb == null)
            {
                return HttpNotFound();
            }
            return View(permisoServicioWeb);
        }

        // GET: Cnp/PermisoServicioWebs/Create
        public ActionResult Create()
        {
            ViewBag.UrlBaseId = new SelectList(db.UrlBase, "UrlBaseId", "Descripcion");
            ViewBag.UrlServicioWebId = new SelectList(db.UrlServicioWeb, "UrlServicioWebId", "Url");
            ViewBag.UsuarioAutorizadoId = new SelectList(db.UsuarioAutorizado, "UsuarioAutorizadoId", "Usuario");
            return View();
        }

        // POST: Cnp/PermisoServicioWebs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PermisoServicioWebId,UsuarioAutorizadoId,UrlBaseId,UrlServicioWebId,Vigente")] PermisoServicioWeb permisoServicioWeb)
        {
            if (ModelState.IsValid)
            {
                db.PermisoServicioWeb.Add(permisoServicioWeb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UrlBaseId = new SelectList(db.UrlBase, "UrlBaseId", "Descripcion", permisoServicioWeb.UrlBaseId);
            ViewBag.UrlServicioWebId = new SelectList(db.UrlServicioWeb, "UrlServicioWebId", "Metodo", permisoServicioWeb.UrlServicioWebId);
            ViewBag.UsuarioAutorizadoId = new SelectList(db.UsuarioAutorizado, "UsuarioAutorizadoId", "Usuario", permisoServicioWeb.UsuarioAutorizadoId);
            return View(permisoServicioWeb);
        }

        // GET: Cnp/PermisoServicioWebs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermisoServicioWeb permisoServicioWeb = db.PermisoServicioWeb.Find(id);
            if (permisoServicioWeb == null)
            {
                return HttpNotFound();
            }
            ViewBag.UrlBaseId = new SelectList(db.UrlBase, "UrlBaseId", "Descripcion", permisoServicioWeb.UrlBaseId);
            ViewBag.UrlServicioWebId = new SelectList(db.UrlServicioWeb, "UrlServicioWebId", "Metodo", permisoServicioWeb.UrlServicioWebId);
            ViewBag.UsuarioAutorizadoId = new SelectList(db.UsuarioAutorizado, "UsuarioAutorizadoId", "Usuario", permisoServicioWeb.UsuarioAutorizadoId);
            return View(permisoServicioWeb);
        }

        // POST: Cnp/PermisoServicioWebs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PermisoServicioWebId,UsuarioAutorizadoId,UrlBaseId,UrlServicioWebId,Vigente")] PermisoServicioWeb permisoServicioWeb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permisoServicioWeb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UrlBaseId = new SelectList(db.UrlBase, "UrlBaseId", "Descripcion", permisoServicioWeb.UrlBaseId);
            ViewBag.UrlServicioWebId = new SelectList(db.UrlServicioWeb, "UrlServicioWebId", "Metodo", permisoServicioWeb.UrlServicioWebId);
            ViewBag.UsuarioAutorizadoId = new SelectList(db.UsuarioAutorizado, "UsuarioAutorizadoId", "Usuario", permisoServicioWeb.UsuarioAutorizadoId);
            return View(permisoServicioWeb);
        }

        // GET: Cnp/PermisoServicioWebs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermisoServicioWeb permisoServicioWeb = db.PermisoServicioWeb.Find(id);
            if (permisoServicioWeb == null)
            {
                return HttpNotFound();
            }
            return View(permisoServicioWeb);
        }

        // POST: Cnp/PermisoServicioWebs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PermisoServicioWeb permisoServicioWeb = db.PermisoServicioWeb.Find(id);
            db.PermisoServicioWeb.Remove(permisoServicioWeb);
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
