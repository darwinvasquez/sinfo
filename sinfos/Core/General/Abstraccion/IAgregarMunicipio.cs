using Comun.DTOs;

namespace Core.General.Abstraccion
{
    public interface IAgregarMunicipio
    {
        bool AgregarMunicipio(MunicipioDTO _params, out string _municipioId);
    }
}
