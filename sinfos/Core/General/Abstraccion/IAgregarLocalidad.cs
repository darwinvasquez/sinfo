using Comun.DTOs;

namespace Core.General.Abstraccion
{
    public interface IAgregarLocalidad
    {
        bool AgregarLocalidad(LocalidadDTO _params, out string _localidadId);
    }
}
