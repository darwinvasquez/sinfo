using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    public class ContextCnp : DbContext
    {
        public ContextCnp()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<TipoLugar> TipoLugar { get; set; }
        public virtual DbSet<ListaComportamiento> ListaComportamiento { get; set; }
        public virtual DbSet<EstadoMedida> EstadoMedida { get; set; }
        public virtual DbSet<UsuarioAutorizado> UsuarioAutorizado { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<StatusCodeWebService> StatusCodeWebService { get; set; }
        public virtual DbSet<CodigoResponse> CodigoResponse { get; set; }
        public virtual DbSet<UrlBase> UrlBase { get; set; }
        public virtual DbSet<UrlServicioWeb> UrlServicioWeb { get; set; }
        public virtual DbSet<PermisoServicioWeb> PermisoServicioWeb { get; set; }
    }
}