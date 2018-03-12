using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    public enum EnumCodigoResponse
    {
        [Description("Unauthorized")]
        Unauthorized = 1,
        [Description("Internal Server Error")]
        InternalServerError = 2      
    }

    public enum EnumCodigoUrlServicioWeb
    {
        [Description("Consultar localidades por municipio")]
        ConsultarLocalidad = 1 ,        
    
        [Description("Consultar enitdades por municipio")]
        ConsultarEntidad = 2
    }
}