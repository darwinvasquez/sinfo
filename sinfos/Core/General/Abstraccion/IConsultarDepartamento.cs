using Comun.DTOs;
using System.Collections.Generic;

namespace Core.General.Abstraccion
{
    public interface IConsultarDepartamento
    {
        List<DepartamentoDTO> ConsultarDepartamento();
    }
}
