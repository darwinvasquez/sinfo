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
using sinfo.Models;
using Newtonsoft.Json;

namespace sinfo.Areas.Cnp.Controllers
{
    public class EntidadsController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/Entidads
        public ActionResult Index()
        {
            return View(db.Entidad.ToList());
        }

        // GET: Cnp/Entidads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidad entidad = db.Entidad.Find(id);
            if (entidad == null)
            {
                return HttpNotFound();
            }
            return View(entidad);
        }

        // GET: Cnp/Entidads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cnp/Entidads/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EntidadId,CodigoPonal,CodigoTipoEntidad,TipoEntidad,Descripcion,Direccion,Correo,Telefono,Celular,Nit,Web,Latitud,Longitud,CodMunicipio,Municipio,CodDepartamento,Departamento,Vigente")] Entidad entidad)
        {
            if (ModelState.IsValid)
            {
                db.Entidad.Add(entidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entidad);
        }
        public async Task<ActionResult> Sincronizar()
        {
            int codSw = (int)EnumCodigoUrlServicioWeb.ConsultarEntidad;
            var user = db.PermisoServicioWeb.Where(x => x.UrlServicioWebId == codSw).ToList();

            foreach (var ite in user)
            {
                var result = await GeneradorToken.Sincronizador(HttpContext.Request.RawUrl,
                                                                ite.UsuarioAutorizado.Usuario,
                                                                ite.UsuarioAutorizado.Password,
                                                                ite.UrlBase.Descripcion,
                                                                ite.UrlServicioWeb.Url);

                if (result != null)
                {
                    var datos = JsonConvert.DeserializeObject<List<DominioEntidad>>(result);

                    foreach (var item in datos)
                    {
                        bool existe = db.Entidad.Any(x => x.CodigoPonal == item.ID_ENTIDAD);
                        if (!existe)
                        {
                            Entidad dato = new Entidad();
                            dato.CodigoPonal = Convert.ToInt32(item.ID_ENTIDAD);
                            dato.CodigoTipoEntidad = Convert.ToInt32(item.COD_TIPO_ENTIDAD);
                            dato.TipoEntidad = item.TIPO_ENTIDAD;
                            dato.Descripcion = item.DESCRIPCION;
                            dato.Direccion = item.DIRECCION;
                            dato.Correo = item.CORREO;
                            dato.Telefono = item.TELEFONO;
                            dato.Celular = item.CELULAR;
                            dato.Nit = item.NIT;
                            dato.Web = item.WEB;
                            dato.Latitud = Convert.ToInt32(item.LATITUD);
                            dato.Longitud = Convert.ToInt32(item.LONGITUD);
                            dato.CodMunicipio = (int)item.COD_MUNICIPIO;
                            dato.Municipio = item.MUNICIPIO;
                            dato.CodDepartamento = (int)item.COD_DEPARTAMENTO;
                            dato.Municipio = item.MUNICIPIO;
                            dato.Vigente = true;
                            db.Entidad.Add(dato);
                            db.SaveChanges();
                        }
                    }
                }
            }
            return RedirectToAction("Index", "Entidads");
        }

        // GET: Cnp/Entidads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidad entidad = db.Entidad.Find(id);
            if (entidad == null)
            {
                return HttpNotFound();
            }
            return View(entidad);
        }

        // POST: Cnp/Entidads/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EntidadId,CodigoPonal,CodigoTipoEntidad,TipoEntidad,Descripcion,Direccion,Correo,Telefono,Celular,Nit,Web,Latitud,Longitud,CodMunicipio,Municipio,CodDepartamento,Departamento,Vigente")] Entidad entidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entidad);
        }

        // GET: Cnp/Entidads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidad entidad = db.Entidad.Find(id);
            if (entidad == null)
            {
                return HttpNotFound();
            }
            return View(entidad);
        }

        // POST: Cnp/Entidads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entidad entidad = db.Entidad.Find(id);
            db.Entidad.Remove(entidad);
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
