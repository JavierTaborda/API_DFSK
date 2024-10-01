using API_DFSK.DTOs.ConcesionarioDFSK;

namespace API_DFSK.Interfaces.ConcesionarioDFSK
{
    public interface IVehiculoRepository
    {
        Task<List<VehiculoDTO>> GetVehiculos();
        Task<List<VehiculoDTO>> GetVehiculoByCodigo(string Codigo);
        Task<VehiculoDTO> GetVehiculoById(int Id);
        Task<bool> InsertVehiculo(List<VehiculoDTO> vehiculos);
        Task<VehiculoDTO> UpdateVehiculo(VehiculoDTO vehiculos);
        Task<VehiculoDTO> AddUpdateVehiculo(VehiculoDTO vehiculos);
    }
}
