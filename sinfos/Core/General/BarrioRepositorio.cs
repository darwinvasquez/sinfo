using Comun.DTOs;
using Core.General.Abstraccion;
using Datos.Cnp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.General
{
    public class BarrioRepositorio : IAgregarBarrio, IConsultarBarrios, IConsultarBarriosPorMunicipio
    {
        /// <summary>
        /// Agergar barrio
        /// </summary>
        /// <param name="_params"></param>
        /// <param name="_barrioId"></param>
        /// <returns></returns>
        public bool AgregarBarrio(BarrioDTO _params, out string _barrioId)
        {
            Barrio barrio = new Barrio();

            barrio.BarrioId = Guid.NewGuid().ToString();
            barrio.MunicipioId = _params.MunicipioId;
            barrio.Tipo = _params.Tipo;
            barrio.Descripcion = _params.Descripcion;
            barrio.CodigoDane = _params.CodigoDane;
            barrio.CodigoPonal = _params.CodigoPonal;
            barrio.Vigente = true;

            using (ContextCnp db = new ContextCnp())
            {
                db.Barrio.Add(barrio);

                if (db.SaveChanges() > 0)
                {
                    _barrioId = barrio.BarrioId;
                    return true;
                }
                _barrioId = string.Empty;
                return false;
            }
        }

        /// <summary>
        /// Concultar barrios
        /// </summary>
        /// <returns></returns>
        public List<BarrioDTO> ConsultarBarrios()
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Barrio.Where(x => x.Vigente == true).Select(x => new BarrioDTO
                {
                    BarrioId = x.BarrioId,
                    MunicipioId = x.MunicipioId,
                    Tipo = x.Tipo,
                    Descripcion = x.Descripcion,
                    CodigoDane = x.CodigoDane,
                    CodigoPonal = x.CodigoPonal
                });
                return resultado.ToList();
            }
        }

        /// <summary>
        /// Consuktar barrios por municipios
        /// </summary>
        /// <param name="_municipioId"></param>
        /// <returns></returns>
        public List<BarrioDTO> ConsultarBarriosPorMunicipio(string _municipioId)
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Barrio.Where(x => x.Vigente == true && x.MunicipioId == _municipioId).Select(x => new BarrioDTO
                {
                    BarrioId = x.BarrioId,
                    MunicipioId = x.MunicipioId,
                    Tipo = x.Tipo,
                    Descripcion = x.Descripcion,
                    CodigoDane = x.CodigoDane,
                    CodigoPonal = x.CodigoPonal
                });
                return resultado.ToList();
            }
        }
    }
}
