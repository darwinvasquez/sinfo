using Comun.DTOs;

namespace Core.Cnp.Abstraccion
{
    public interface IRegistrarProcesoVerbalAbreviado
    {
        ResponseModel AdicionarProcesoVerbalAbreviado(CnpHechoDTO _cnpHechosDto);
    }
}
