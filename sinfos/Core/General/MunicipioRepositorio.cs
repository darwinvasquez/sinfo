using Comun.DTOs;
using Core.General.Abstraccion;
using Datos.Cnp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.General
{
    public class MunicipioRepositorio : IAgregarMunicipio, IConsultarMunicipios, IConsultarMunicipiosPorDepartamento
    {
        /// <summary>
        /// Agregar un muncipio
        /// </summary>
        /// <param name="_params"></param>
        /// <param name="_municipioId"></param>
        /// <returns></returns>
        public bool AgregarMunicipio(MunicipioDTO _params, out string _municipioId)
        {
            Municipio municipio = new Municipio();

            municipio.MunicipioId = Guid.NewGuid().ToString();
            municipio.DepartamentoId = _params.DepartamentoId;
            municipio.Descripcion = _params.Descripcion;
            municipio.CodigoDane = _params.CodigoDane;
            municipio.CodigoPonal = _params.CodigoPonal;
            municipio.Vigente = true;

            using (ContextCnp db = new ContextCnp())
            {
                db.Municipio.Add(municipio);

                if (db.SaveChanges() > 0)
                {
                    _municipioId = municipio.MunicipioId;
                    return true;
                }
                _municipioId = string.Empty;
                return false;
            }
        }

        /// <summary>
        /// Consultar los municipios
        /// </summary>
        /// <returns></returns>
        public List<MunicipioDTO> ConsultarMunicipios()
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Municipio.Where(x => x.Vigente == true).Select(x => new MunicipioDTO
                {
                    MunicipioId = x.MunicipioId,
                    DepartamentoId = x.DepartamentoId,
                    Departamento = x.Departamento.Descripcion,
                    Descripcion = x.Descripcion,
                    CodigoDane = x.CodigoDane,
                    CodigoPonal = x.CodigoPonal
                });
                return resultado.ToList();
            }
        }

        /// <summary>
        /// Consultar municipios de por departamentos
        /// </summary>
        /// <param name="_departamentoId"></param>
        /// <returns></returns>
        public List<MunicipioDTO> ConsultarMunicipiosPorDepartamento(string _departamentoId)
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Municipio.Where(x => x.Vigente == true && x.DepartamentoId == _departamentoId).Select(x => new MunicipioDTO
                {
                    MunicipioId = x.MunicipioId,
                    DepartamentoId = x.DepartamentoId,
                    Descripcion = x.Descripcion,
                    CodigoDane = x.CodigoDane,
                    CodigoPonal = x.CodigoPonal
                });
                return resultado.ToList();
            }
        }
    }
}
