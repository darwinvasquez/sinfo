using Comun.DTOs;
using Core.General.Abstraccion;
using Datos.Cnp;
using System.Collections.Generic;
using System.Linq;

namespace Core.General
{
    public class LugarGeografico : IConsultarPais
    {
        public List<PaisDTO> ConsultarPais()
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Pais.Where(x => x.Vigente == true).Select(x => new PaisDTO
                {
                    PaisId = x.PaisId,
                    Descripcion = x.Descripcion,
                    CodigoDane = x.CodigoDane,
                    CodigoPonal = x.CodigoPonal                   
                });
                return resultado.ToList();
            }
        }
    }
}
