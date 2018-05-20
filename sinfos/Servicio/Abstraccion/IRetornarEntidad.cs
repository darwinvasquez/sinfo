using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Abstraccion
{
    public interface IRetornarEntidad
    {
        Task<string> RetornarEntidad();
    }
}
