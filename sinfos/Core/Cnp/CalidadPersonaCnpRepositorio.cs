using Comun.DTOs;
using Core.Cnp.Abstraccion;
using Datos.Cnp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Core.Cnp
{
    public class CalidadPersonaCnpRepositorio : IAgregarCalidadPersonaCnp
    {
        public bool AgregarCalidadPersonaCnp(PersonaDTO _params, out string _mensaje)
        {
            CalidadPersonaCnp calidad = new CalidadPersonaCnp();

            calidad.CalidadPersonaCnpId = Guid.NewGuid().ToString();
            calidad.HechoId = _params.HechoId;
            calidad.PersonaId = _params.PersonaId;
            calidad.TipoInfractoId = _params.TipoInfractoId;
            calidad.MenorEdad = _params.MenorEdad;
            calidad.TipoPoblacion = _params.TipoPoblacion;
            calidad.RepresentanteMenor = _params.RepresentanteMenor;
            calidad.Vigente = true;
            calidad.FechaCreacion = DateTime.Now;
            calidad.UsuarioCreacion = HttpContext.Current.User.Identity.Name;
            calidad.MaquinaCreacion = HttpContext.Current.Request.UserHostAddress;

            using (ContextCnp db = new ContextCnp())
            {
                db.CalidadPersonaCnp.Add(calidad);

                if (db.SaveChanges() > 0)
                {
                    _mensaje = calidad.CalidadPersonaCnpId;
                    return true;
                }
                _mensaje = string.Empty;
                return false;
            }
        }
    }
}
