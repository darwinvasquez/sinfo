using Comun.DTOs;
using System.Collections.Generic;

namespace Core.Cnp.Abstraccion
{
    public interface IConsultarPersonaPorIdHecho
    {
        List<PersonaDTO> ConsultarPersonaPorIdHecho(string id);
    }
}
