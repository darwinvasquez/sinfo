using Comun.DTOs;

namespace Core.General.Abstraccion
{
    public interface IAgregarPais
    {
        bool AgregarPais(PaisDTO _params, out string _paisId);
    }
}
