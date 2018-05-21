using Comun.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cnp.Abstraccion
{
    public interface IConsultarHechosVerbalAbreviadoId
    {
        CnpHechoDTO ConsultarHechosVerbalAbreviadoId(string id);
    }
}
