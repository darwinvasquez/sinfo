using Comun.DTOs;

namespace Core.General.Abstraccion
{
    public interface IAgregarDepartamento
    {
        bool AgregarDepartamento(DepartamentoDTO _params, out string _departamentoId);
    }
}
