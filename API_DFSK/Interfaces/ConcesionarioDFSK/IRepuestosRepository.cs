using API_DFSK.DTOs.ConcesionarioDFSK;

namespace API_DFSK.Interfaces.ConcesionarioDFSK
{
    public interface IRepuestosRepository
    {
        Task<List<RepuestoDTO>> GetRepuestoList(List<CodigosRepuestosDTO> codigos);
        Task<RepuestoVehiculoDTO> GetRepuestoCodigo(string codigo);
        Task<RepuestoVehiculoDTO> GetRepuestoById(int Id);
        Task<List<RepuestoVehiculoDTO>> GetRepuestosByVehiculo(int Id, string codigo);

        Task<RepuestoDTO> InsertRepuesto(RepuestoDTO repuesto);
        Task<RepuestoDTO> UpdateRepuesto(RepuestoDTO repuestos);
    }
}
