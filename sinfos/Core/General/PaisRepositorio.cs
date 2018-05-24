using Comun.DTOs;
using Core.General.Abstraccion;
using Datos.Cnp;
using System;

namespace Core.General
{
    public class PaisRepositorio : IAgregarPais
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
    }
}
