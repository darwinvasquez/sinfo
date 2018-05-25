using Comun.DTOs;
using System.Collections.Generic;

namespace Core.General.Abstraccion
{
    public interface IConsultarLocalidadesPorMunicipio
    {
        List<LocalidadDTO> ConsultarLocalidadesPorMunicipio(string _municipioId);
    }
}
