using API_DFSK.Models.ConcesionarioDFSK;
using Microsoft.AspNetCore.Http.Timeouts;
using System.Security;

namespace API_DFSK.Interfaces.ConcesionarioDFSK
{
    public interface ISolicitudesRepository
    {
        Task<List<Vehiculo>> GetVehiculos();
        Task<Vehiculo> GetVehiculoByIdCodigo(int Id, string codigo);
        Task<List<Repuesto>> GetRuestosByVehiculo(int Id, string codigo);
        Task<Repuesto> GetRuestoCodigo(string codigo);
        Task<Repuesto> GetRuestoById(int Id);
        Task<List<Estado>> GetEstados();
        Task<Estado> GetEstadoById(int Id);
        Task<List<Vendedore>> GetVendedores();
        Task<Vendedore> GetVendedorById(int Id);

        Task<List<Solicitude>> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int idrepuesto, int idvendedor, int tipofecha);
        Task<Solicitude> GetSolicitudById(int Idtipofecha);
    }
}
