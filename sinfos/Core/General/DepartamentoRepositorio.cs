using Comun.DTOs;
using Core.General.Abstraccion;
using Datos.Cnp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.General
{
    public class DepartamentoRepositorio : IAgregarDepartamento, IConsultarDepartamento, IConsultarDepartamentosPorPais
    {
        public bool AgregarDepartamento(DepartamentoDTO _params, out string _departamentoId)
        {
            Departamento departamento = new Departamento();

            departamento.DepartamentoId = Guid.NewGuid().ToString();
            departamento.PaisId = _params.PaisId;
            departamento.Descripcion = _params.Descripcion;
            departamento.CodigoDane = _params.CodigoDane;
            departamento.CodigoPonal = _params.CodigoPonal;
            departamento.Vigente = true;

            using (ContextCnp db = new ContextCnp())
            {
                db.Departamento.Add(departamento);

                if (db.SaveChanges() > 0)
                {
                    _departamentoId = departamento.DepartamentoId;
                    return true;
                }
                _departamentoId = string.Empty;
                return false;
            }
        }

        public List<DepartamentoDTO> ConsultarDepartamento()
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Departamento.Where(x => x.Vigente == true).Select(x => new DepartamentoDTO
                {
                    DepartamentoId = x.DepartamentoId,
                    PaisId = x.PaisId,
                    Descripcion = x.Descripcion,
                    CodigoDane = x.CodigoDane,
                    CodigoPonal = x.CodigoPonal
                });
                return resultado.ToList();
            }
        }

        public List<DepartamentoDTO> ConsultarDepartamentosPorPais(string _paisId)
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.Departamento.Where(x => x.Vigente == true && x.DepartamentoId == _paisId).Select(x => new DepartamentoDTO
                {
                    DepartamentoId = x.DepartamentoId,
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
