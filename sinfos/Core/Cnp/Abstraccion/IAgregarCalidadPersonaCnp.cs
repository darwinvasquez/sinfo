﻿using Comun.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cnp.Abstraccion
{
    public interface IAgregarCalidadPersonaCnp
    {
        bool AgregarCalidadPersonaCnp(PersonaDTO _params, out string _mensaje);
    }
}
