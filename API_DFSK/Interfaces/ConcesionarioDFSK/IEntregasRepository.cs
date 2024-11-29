using API_DFSK.DTOs.ConcesionarioDFSK;

namespace API_DFSK.Interfaces.ConcesionarioDFSK
{
    public interface IEntregasRepository
    {
        Task<List<EstadoEntregaDTO>> getEstadosEntrega();
        Task<EstadoEntregaDTO> getEstadoEntregaId(int Id);
        Task<string> InsertEstadoEntrega(EstadoEntregaDTO estado );
        Task<string> UpdateEstadoEntrega(EstadoEntregaDTO estado );
    }
}
