using API_DFSK.DTOs.DFSK;
using API_DFSK.Models.DFSK;

namespace API_DFSK.Interfaces.DFSK
{
    public interface IArticulosRepository
    {

        Task<List<ApiRepuestosMostrar>> GetAllArticulosBodega();
        Task<List<ApiRepuestosMostrar>> GetArticulosExistenciaBodega();
        Task<List<ApiRepuestosMostrar>> GetArticuloBodegaByCodigo(string Codigo);
        Task<List<ApiRepuestosMostrar>> GetVehiculosBodegaByCodigo(string Codigo);
        Task<List<ApiRepuestosMostrar>> GetArticuloBodegaByNombre(string Nombre);
        Task<List<ApiRepuestosMostrar>> GetArticuloBodegaByMarcayGrupo(string Marca, string Grupo, string Categoria, string Nombre);
        Task<List<ApiCodigosMarca>> GetCodigosByMarca();
        Task<List<ApiCodigosGrupo>> GetCodigosByGrupo();// eliminar
        Task<List<Gruposrepuesto>> GetGrupos();
        Task<List<Categoriarepuesto>> GetCategorias();

        Task<string> UpdateImagenURL( UpdateImagenDTO updateimagen);
    }
}
