using API_DFSK.Models;

namespace API_DFSK.Interfaces.DFSK
{
    public interface IArticulosRepository
    {
        Task<List<Articulo>> GetArticulos();
        Task<List<ArticulosBodegaApi>> GetAllArticulosBodega();
        Task<List<ArticulosBodegaApi>> GetArticulosExistenciaBodega();
        Task<List<ArticulosBodegaApi>> GetArticuloBodegaByCodigo(string Codigo);
        Task<List<ArticulosBodegaApi>> GetArticuloBodegaByNombre(string Nombre);
        Task<List<ArticulosBodegaApi>> GetArticuloBodegaByMarca(string Marca);
    }
}
