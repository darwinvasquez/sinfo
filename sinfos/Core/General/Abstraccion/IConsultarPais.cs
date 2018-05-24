using Comun.DTOs;
using System.Collections.Generic;

namespace Core.General.Abstraccion
{
    public interface IConsultarPais
    {
        List<PaisDTO> ConsultarPais();
    }
}
