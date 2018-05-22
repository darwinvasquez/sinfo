using Comun.DTOs;
using Core.Cnp.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cnp.Reglas
{
    public class RegistrarPersonaHecho : IRegistrarPersonaHecho
    {
        public bool AdicionarPersonaHecho(PersonaDTO _params)
        {
            string personaId = string.Empty;
            string calidadId = string.Empty;
            
            IAgregarPersonaProcesoVerbalAbreviado persona = new PersonaRepositorio();
            persona.AgregarPersonaProcesoVerbalAbreviado(_params, out personaId);

            _params.PersonaId = personaId;

            IAgregarCalidadPersonaCnp calidad = new CalidadPersonaCnpRepositorio();
            calidad.AgregarCalidadPersonaCnp(_params, out calidadId);


            return true;


        }
    }
}
