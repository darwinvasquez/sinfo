using Comun.DTOs;
using Core.Cnp.Abstraccion;
using Datos.Cnp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Cnp
{
    public class PersonaRepositorio : IAgregarPersonaProcesoVerbalAbreviado, IConsultarPersonaPorIdHecho
    {
        public bool AgregarPersonaProcesoVerbalAbreviado(PersonaDTO _params, out string _personaId)
        {
            Persona persona = new Persona();

            persona.PersonaId = Guid.NewGuid().ToString();
            persona.Nombres = _params.Nombres;
            persona.Apellidos = _params.Apellidos;
            persona.TipoIdentificacion = _params.TipoIdentificacion;
            persona.Identificacion = _params.Identificacion;
            persona.FechaNacimiento = _params.FechaNacimiento;
            persona.Telefono = _params.Telefono;
            persona.Email = _params.Email;
            persona.NacionalidadId = _params.NacionalidadId;
            persona.IdPaisReside = _params.IdPaisReside;
            persona.IdMunicipioReside = _params.IdMunicipioReside;
            persona.IdDepartamentoReside = _params.IdDepartamentoReside;
            persona.DireccionReside = _params.DireccionReside;
            persona.Vigente = true;
            persona.FechaCreacion = DateTime.Now;
            persona.UsuarioCreacion = HttpContext.Current.User.Identity.Name;
            persona.MaquinaCreacion = HttpContext.Current.Request.UserHostAddress;

            using (ContextCnp db = new ContextCnp())
            {
                db.Persona.Add(persona);

                if (db.SaveChanges() > 0)
                {
                    _personaId = persona.PersonaId;
                    return true;
                }
                _personaId = string.Empty;
                return false;
            }

        }

        public List<PersonaDTO> ConsultarPersonaPorIdHecho(string id)
        {
            using (ContextCnp db = new ContextCnp())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.AutoDetectChangesEnabled = false;

                var resultado = db.CalidadPersonaCnp.Where(x => x.Vigente == true && x.HechoId == id).
                    Select(x => new PersonaDTO
                    {
                        Nombres = x.Persona.Nombres,
                        Apellidos = x.Persona.Apellidos,
                        TipoIdentificacion = x.Persona.TipoIdentificacion,
                        Identificacion = x.Persona.Identificacion,
                        FechaNacimiento = x.Persona.FechaNacimiento,
                        Telefono = x.Persona.Telefono,
                        Email = x.Persona.Email,
                        NacionalidadId = x.Persona.NacionalidadId,
                        IdPaisReside = x.Persona.IdPaisReside,
                        IdMunicipioReside = x.Persona.IdMunicipioReside,
                        IdDepartamentoReside = x.Persona.IdDepartamentoReside,
                        DireccionReside = x.Persona.DireccionReside
                    });
                return resultado.ToList();
            }
        }

    }
}
