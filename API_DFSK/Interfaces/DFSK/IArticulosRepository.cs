using API_DFSK.DTOs.DFSK;
using API_DFSK.Models.DFSK;

namespace API_DFSK.Interfaces.DFSK
{
    public interface IArticulosRepository
    {

        Task<List<ApiArticulosGrupo>> GetAllArticulosBodega();
        Task<List<ApiArticulosGrupo>> GetArticulosExistenciaBodega();
        Task<List<ApiArticulosGrupo>> GetArticuloBodegaByCodigo(string Codigo);
        Task<List<ApiArticulosGrupo>> GetVehiculosBodegaByCodigo(string Codigo);
        Task<List<ApiArticulosGrupo>> GetArticuloBodegaByNombre(string Nombre);
        Task<List<ApiArticulosGrupo>> GetArticuloBodegaByMarcayGrupo(string Marca, string Grupo, string Nombre);
        Task<List<ApiCodigosMarca>> GetCodigosByMarca();
        Task<List<ApiCodigosGrupo>> GetCodigosByGrupo();

        Task<string> UpdateImagenURL( UpdateImagenDTO updateimagen);
    }
}
