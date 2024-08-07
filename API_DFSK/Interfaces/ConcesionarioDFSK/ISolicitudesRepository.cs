using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using Microsoft.AspNetCore.Http.Timeouts;
using System.Security;

namespace API_DFSK.Interfaces.ConcesionarioDFSK
{
    public interface ISolicitudesRepository
    {
        //GETS
        #region gets 
        Task<List<VehiculoDTO>> GetVehiculos();
        Task<VehiculoDTO?> GetVehiculoByIdCodigo(int Id, string codigo);
        Task<List<RepuestoVehiculoDTO>> GetRepuestosByVehiculo(int Id, string codigo);
        Task<RepuestoVehiculoDTO?> GetRepuestoCodigo(string codigo);
        Task<RepuestoVehiculoDTO?> GetRepuestoById(int Id);
        Task<List<EstadoDTO>> GetEstados();
        Task<EstadoDTO?> GetEstadoById(int Id);
        Task<List<VendedorDTO>> GetVendedores();
        Task<VendedorDTO?> GetVendedorById(int Id);
        Task<List<SolicitudDTO>> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int idrepuesto, int idvendedor, int tipofecha);
        Task<SolicitudDTO?> GetSolicitudById(int Id);
        #endregion

        //POST
        Task<bool> InsertSolicitud(List<SolicitudDTO> solicitudes);
        Task<bool> InsertSolicitudRepuesto(SolicitudRepuestoDTO solicitud);
        Task<bool> InsertRepuesto(List<RepuestoDTO> repuestos);
        Task<bool> InsertVehiculo(List<VehiculoDTO> vehiculos);
        Task<bool> InsertEstado(List<EstadoDTO> Estados);
        Task<bool> InsertVendedor(List<VendedorDTO> Vendedores);

        //PUTS
        Task<bool> UpdateSolicitud(List<SolicitudDTO> solicitudes);
        Task<SolicitudRepuestoDTO> UpdateSolicitudRepuesto(SolicitudRepuestoDTO solicitud);
        Task<RepuestoDTO> UpdateRepuesto(RepuestoDTO repuestos);
        Task<VehiculoDTO> UpdateVehiculo(VehiculoDTO vehiculos);
        Task<EstadoDTO> UpdateEstado(EstadoDTO Estados);
        Task<VendedorDTO> UpdateVendedor(VendedorDTO Vendedores);
    }
}
