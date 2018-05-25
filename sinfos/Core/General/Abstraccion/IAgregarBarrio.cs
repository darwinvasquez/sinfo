using Comun.DTOs;

namespace Core.General.Abstraccion
{
    public interface IAgregarBarrio
    {
        bool AgregarBarrio(BarrioDTO _params, out string _barrioId);
    }
}
