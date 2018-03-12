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
using System.Net.Http;


namespace sinfo.Areas.Cnp.Controllers
{
    public class LocalidadsController : Controller
    {
        private ContextCnp db = new ContextCnp();

        // GET: Cnp/Localidads
        public ActionResult Index()
        {
            return View(db.Localidad.ToList());
        }

        // GET: Cnp/Localidads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Localidad localidad = db.Localidad.Find(id);
            if (localidad == null)
            {
                return HttpNotFound();
            }
            return View(localidad);
        }

        // GET: Cnp/Localidads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cnp/Localidads/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocalidadId,CodigoPonal,CodigoMunicipio,Municipio,NombreLocalidad")] Localidad localidad)
        {
            if (ModelState.IsValid)
            {
                db.Localidad.Add(localidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(localidad);
        }

        //public async Task<ActionResult> SincronizaLocalidad()
        //{
            //int codSw = (int)EnumCodigoUrlServicioWeb.ConsultarLocalidad;
            //var user = db.UrlServicioWeb.Where(x => x.UrlServicioWebId == codSw).ToList();
                       
            //foreach (var ite in user)
            //{
            //    var result = await GeneradorToken.Sincronizador(HttpContext.Request.RawUrl, 
            //                                                    ite.UsuarioAutorizado.Usuario, 
            //                                                    ite.UsuarioAutorizado.Password,
            //                                                    ite.UrlBase.Descripcion,
            //                                                    ite.Url);

            //    if (result != null)
            //    {
            //        var datos = JsonConvert.DeserializeObject<List<DominioLocalidad>>(result);

            //        foreach (var item in datos)
            //        {
            //            bool existe = db.Localidad.Any(x => x.CodigoPonal == item.ID_LOCALIDAD);
            //            if (!existe)
            //            {
            //                Localidad dato = new Localidad();
            //                dato.CodigoPonal = Convert.ToInt32(item.ID_LOCALIDAD);
            //                dato.CodigoMunicipio = (int)item.COD_MUNICIPIO;
            //                dato.Municipio = item.MUNICIPIO;
            //                dato.NombreLocalidad = item.LOCALIDAD;
            //                dato.Vigente = true;
            //                db.Localidad.Add(dato);
            //                db.SaveChanges();
            //            }
            //        }
            //    }

            //}



            //var usuario = db.UsuarioAutorizado.ToList();

            //foreach (var usr in usuario)
            //{
               


            //    //var result = await GeneradorToken.Sincronizador(HttpContext.Request.RawUrl, usr.Usuario, usr.Password);

                       
            //}           


            //return RedirectToAction("Index", "Localidads");           
        //}

        // GET: Cnp/Localidads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Localidad localidad = db.Localidad.Find(id);
            if (localidad == null)
            {
                return HttpNotFound();
            }
            return View(localidad);
        }

        // POST: Cnp/Localidads/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocalidadId,CodigoPonal,CodigoMunicipio,Municipio,NombreLocalidad")] Localidad localidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(localidad);
        }

        // GET: Cnp/Localidads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Localidad localidad = db.Localidad.Find(id);
            if (localidad == null)
            {
                return HttpNotFound();
            }
            return View(localidad);
        }

        // POST: Cnp/Localidads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Localidad localidad = db.Localidad.Find(id);
            db.Localidad.Remove(localidad);
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
