using Comun.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.General.Abstraccion
{
    public interface IConsultarLocalidades
    {
        List<LocalidadDTO> ConsultarLocalidades();
    }
}
