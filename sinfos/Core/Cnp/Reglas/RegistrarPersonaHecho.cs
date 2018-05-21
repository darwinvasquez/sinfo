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
            string mensaje = string.Empty;

            IAgregarPersonaProcesoVerbalAbreviado persona = new PersonaRepositorio();
            return persona.AgregarPersonaProcesoVerbalAbreviado(_params, out mensaje);
        }
    }
}
