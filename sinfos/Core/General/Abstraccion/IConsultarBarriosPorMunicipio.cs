using Comun.DTOs;
using System.Collections.Generic;

namespace Core.General.Abstraccion
{
    public interface IConsultarBarriosPorMunicipio
    {
        List<BarrioDTO> ConsultarBarriosPorMunicipio(string _municipioId);
    }
}
