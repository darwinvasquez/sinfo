using Comun.DTOs;
using System.Collections.Generic;

namespace Core.General.Abstraccion
{
    public interface IConsultarMunicipiosPorDepartamento
    {
        List<MunicipioDTO> ConsultarMunicipiosPorDepartamento(string _departamentoId);
    }
}
