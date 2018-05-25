using Comun.DTOs;
using Core.General.Abstraccion;
using Datos.Cnp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.General
{
    public class PaisRepositorio : IAgregarPais, IConsultarPais
    {
        public bool AgregarPais(PaisDTO _params, out string _paisId)
        {
            Pais pais = new Pais();

            pais.PaisId = Guid.NewGuid().ToString();
            pais.Descripcion = _params.Descripcion;
            pais.CodigoDane = _params.CodigoDane;
            pais.CodigoPonal = _params.CodigoPonal;
            pais.Vigente = true;

            using (ContextCnp db = new ContextCnp())
            {
                db.Pais.Add(pais);

                if (db.SaveChanges() > 0)
                {
                    _paisId = pais.PaisId;
                    return true;
                }
                _paisId = string.Empty;
                return false;
            }

        }
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
