using API_DFSK.Models.DFSK;

namespace API_DFSK.Interfaces.DFSK
{
    public interface IArticulosRepository
    {

        Task<List<ApiArticulosGrupo>> GetAllArticulosBodega();
        Task<List<ApiArticulosGrupo>> GetArticulosExistenciaBodega();
        Task<List<ApiArticulosGrupo>> GetArticuloBodegaByCodigo(string Codigo);
        Task<List<ApiArticulosGrupo>> GetArticuloBodegaByNombre(string Nombre);
        Task<List<ApiArticulosGrupo>> GetArticuloBodegaByMarca(string Marca);
    }
}
