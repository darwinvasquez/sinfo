using Comun.DTOs;
using Core.General.Abstraccion;
using Datos.Cnp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.General
{
    public class LocalidadRepositorio : IAgregarLocalidad, IConsultarLocalidades, IConsultarLocalidadesPorMunicipio
    {
        /// <summary>
        /// Agregar una localidad
        /// </summary>
        /// <param name="_params"></param>
        /// <param name="_localidadId"></param>
        /// <returns></returns>
        public bool AgregarLocalidad(LocalidadDTO _params, out string _localidadId)
        {
            Localidad localidad = new Localidad();

            localidad.LocalidadId = Guid.NewGuid().ToString();
            localidad.MunicipioId = _params.MunicipioId;          
            localidad.Descripcion = _params.Descripcion;
            localidad.CodigoDane = _params.CodigoDane;
            localidad.CodigoPonal = _params.CodigoPonal;
            localidad.Vigente = true;

            using (ContextCnp db = new ContextCnp())
            {
                db.Localidad.Add(localidad);

                if (db.SaveChanges() > 0)
                {
                    _localidadId = localidad.LocalidadId;
                    return true;
                }
                _localidadId = string.Empty;
                return false;
            }
        }

        /// <summary>
        /// Consultar localidades
        /// </summary>
        /// <returns></returns>
        public List<LocalidadDTO> ConsultarLocalidades()
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Localidad.Where(x => x.Vigente == true).Select(x => new LocalidadDTO
                {
                    LocalidadId = x.LocalidadId,
                    MunicipioId = x.MunicipioId,
                    Municipio = x.Municipio.Descripcion,
                    Descripcion = x.Descripcion,
                    CodigoDane = x.CodigoDane,
                    CodigoPonal = x.CodigoPonal
                });
                return resultado.ToList();
            }
        }

        /// <summary>
        /// Consultar las localidades por municipio
        /// </summary>
        /// <param name="_municipioId"></param>
        /// <returns></returns>
        public List<LocalidadDTO> ConsultarLocalidadesPorMunicipio(string _municipioId)
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Localidad.Where(x => x.Vigente == true && x.MunicipioId == _municipioId).Select(x => new LocalidadDTO
                {
                    LocalidadId = x.LocalidadId,
                    MunicipioId = x.MunicipioId,
                    Municipio = x.Municipio.Descripcion,
                    Descripcion = x.Descripcion,
                    CodigoDane = x.CodigoDane,
                    CodigoPonal = x.CodigoPonal
                });
                return resultado.ToList();
            }
        }
    }
}
