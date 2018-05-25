using Comun.DTOs;
using Core.Cnp.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cnp.Reglas
{
    public class RegistrarProcesoVerbalAbreviado : IRegistrarProcesoVerbalAbreviado
    {
        public ResponseModel AdicionarProcesoVerbalAbreviado(CnpHechoDTO _cnpHechosDto)
        {
            var rm = new ResponseModel();

            //AtiendeApelacion = Si e ciudadano apelana la decesion el inspector no atiende de lo contrario..  

            IAgregarHechoProcesoVerbalAbreviado registrar = new HechoRepositorio();
            registrar.AgregarHechoProcesoVerbalAbreviado(_cnpHechosDto);

            rm.SetResponse(true);

            return rm;

        }
    }
}
