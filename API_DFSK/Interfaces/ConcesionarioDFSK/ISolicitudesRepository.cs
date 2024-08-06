using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using Microsoft.AspNetCore.Http.Timeouts;
using System.Security;

namespace API_DFSK.Interfaces.ConcesionarioDFSK
{
    public interface ISolicitudesRepository
    {
        Task<List<VehiculoDTO>> GetVehiculos();
        Task<VehiculoDTO> GetVehiculoByIdCodigo(int Id, string codigo);
        Task<List<RepuestoDTO>> GetRepuestosByVehiculo(int Id, string codigo);
        Task<RepuestoDTO> GetRepuestoCodigo(string codigo);
        Task<RepuestoDTO> GetRepuestoById(int Id);
        Task<List<EstadoDTO>> GetEstados();
        Task<EstadoDTO> GetEstadoById(int Id);
        Task<List<VendedorDTO>> GetVendedores();
        Task<VendedorDTO> GetVendedorById(int Id);
        Task<List<SolicitudDTO>> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int idrepuesto, int idvendedor, int tipofecha);
        Task<SolicitudDTO> GetSolicitudById(int Id);
    }
}
