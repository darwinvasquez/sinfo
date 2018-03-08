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

    }
}