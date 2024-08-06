using API_DFSK.Context;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class SolicitudesRepository : ISolicitudesRepository
    {
        private readonly ConcesionarioDfskContext _context;

        public SolicitudesRepository(ConcesionarioDfskContext context)
        {
            _context = context;
        }
        public Task<Estado> GetEstadoById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Estado>> GetEstados()
        {
            throw new NotImplementedException();
        }

        public Task<Repuesto> GetRuestoById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Repuesto> GetRuestoCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<List<Repuesto>> GetRuestosByVehiculo(int Id, string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<Solicitude> GetSolicitudById(int Idtipofecha)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Solicitude>> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int idrepuesto, int idvendedor, int tipofecha)
        {

            IQueryable<Solicitude> query = _context.Solicitudes.AsNoTracking();

            switch (tipofecha)
            {
                case 0:
                    query = query.Where(f => f.FechaSolicitud.Value.Date >= f1.Date && f.FechaSolicitud.Value.Date <= f2.Date);
                    break;
                case 1:
                    query = query.Where(f => f.FechaCompra >= f1 && f.FechaCompra <= f2);
                    break;
                case 2:
                    query = query.Where(f => f.FechaLlegada >= f1 && f.FechaLlegada <= f2);
                    break;
                default:
                    throw new ArgumentException("tipofecha no válido");
            }

            query = query.Where(f => f.IdEstado == idestado
                                     && f.IdRepuesto == idrepuesto
                                     && f.IdVendedor == idvendedor);

            var solicitudes = await query.ToListAsync();

            return solicitudes ?? new List<Solicitude>();
        }


        public Task<Vehiculo> GetVehiculoByIdCodigo(int Id, string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vehiculo>> GetVehiculos()
        {
            throw new NotImplementedException();
        }

        public Task<Vendedore> GetVendedorById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vendedore>> GetVendedores()
        {
            throw new NotImplementedException();
        }
    }
}
