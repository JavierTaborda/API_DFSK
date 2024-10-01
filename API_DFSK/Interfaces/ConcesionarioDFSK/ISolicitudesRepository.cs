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
        
        Task<List<ResumenSolicitudDTO>> GetResumenSolicitudes(DateTime f1, DateTime f2, string estado, int idvendedor);
        Task<List<SolicitudDTO>> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int idvendedor);
        Task<SolicitudDTO?> GetSolicitudById(int Id);     
        Task<Dictionary<string, int>> GetIdsSolicitudIncial();
        #endregion

        //POST
        Task<bool> InsertSolicitud(List<SolicitudDTO> solicitudes);
        Task<bool> InsertSolicitudRepuesto(SolicitudRepuestoDTO solicitud);
 
        Task<bool> InsertResumenSolicitud(ResumenSolicitudDTO Solicitud);

        //PUTS
        Task<bool> UpdateSolicitud(List<SolicitudDTO> solicitudes);
        Task<SolicitudRepuestoDTO> UpdateSolicitudRepuesto(SolicitudRepuestoDTO solicitud);

    }
}
