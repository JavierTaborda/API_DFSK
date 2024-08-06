using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class SolicitudesRepository : ISolicitudesRepository
    {
        private readonly ConcesionarioDfskContext _context;
        private readonly IMapper  _mapper;

        public SolicitudesRepository(ConcesionarioDfskContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //GET
        public async Task<Estado> GetEstadoById(int Id)
        {
            var estado = await _context.Estados.FirstOrDefaultAsync(e=>e.IdEstado==Id);
            return estado ?? new Estado();
        }

        public async Task<List<Estado>> GetEstados()
        {
            var estados = await _context.Estados.AsNoTracking().ToListAsync();
            return estados ?? new List<Estado>();
        }

        public async Task<Repuesto> GetRuestoById(int Id)
        {
            var repuesto = await _context.Repuestos.FirstOrDefaultAsync(r=>r.IdRepuesto==Id);
            return repuesto ?? new Repuesto();
        }

        public async Task<Repuesto> GetRuestoCodigo(string codigo)
        {
            var repuesto = await _context.Repuestos.FirstOrDefaultAsync(r => r.Codigo.Contains(codigo));
            return repuesto ?? new Repuesto();
        }

        public async Task<List<Repuesto>> GetRuestosByVehiculo(int Id, string codigo)
        {
            var repuesto = await _context.Repuestos.Where(r => r.IdVehiculo==(Id) || r.IdVehiculoNavigation.Codigo.Contains(codigo))
                .AsNoTracking()
                .ToListAsync();
            return repuesto ?? new List<Repuesto>();
        }

        public async Task<SolicitudDTO> GetSolicitudById(int Id)
        {
            var solicitud = await _context.Solicitudes
                .Include(ven => ven.IdVendedorNavigation)
                .Include(rep => rep.IdRepuestoNavigation).ThenInclude(rep=>rep.IdVehiculoNavigation)
                .Include(rep => rep.IdEstadoNavigation)
                .FirstOrDefaultAsync(id => id.IdSolicitud == Id);

            if (solicitud == null)
                return null;

            return _mapper.Map<SolicitudDTO>(solicitud);
        }
        public async Task<List<SolicitudDTO>> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int idrepuesto, int idvendedor, int tipofecha)
        {

            IQueryable<Solicitude> query = _context.Solicitudes
                .Include(ven => ven.IdVendedorNavigation)
                .Include(rep => rep.IdRepuestoNavigation).ThenInclude(rep => rep.IdVehiculoNavigation)
                .Include(rep => rep.IdEstadoNavigation)
                .AsNoTracking();

            switch (tipofecha)
            {
                case 0:
                    query = query.Where(f => f.FechaSolicitud.Value.Date >= f1.Date && f.FechaSolicitud.Value.Date <= f2.Date);
                    break;
                case 1:
                    query = query.Where(f => f.FechaCompra.Value.Date >= f1.Date && f.FechaCompra.Value.Date <= f2.Date);
                    break;
                case 2:
                    query = query.Where(f => f.FechaLlegada.Value.Date >= f1.Date && f.FechaLlegada.Value.Date <= f2.Date);
                    break;
                default:
                    throw new ArgumentException("tipofecha no válido");
            }

            query = query.Where(f => f.IdEstado == idestado
                                     && f.IdRepuesto == idrepuesto
                                     && f.IdVendedor == idvendedor);

            var solicitudes = await query.ToListAsync();

            return _mapper.Map<List<SolicitudDTO>>(solicitudes) ?? new List<SolicitudDTO>();
        }


        public async Task<Vehiculo> GetVehiculoByIdCodigo(int Id, string codigo)
        {
            var vehiculo = await _context.Vehiculos.FirstOrDefaultAsync(id=>id.IdVehiculo == Id || id.Codigo.Equals(codigo));
                return vehiculo ?? new Vehiculo();
        }

        public async Task<List<Vehiculo>> GetVehiculos()
        {
            var vehiculos = await _context.Vehiculos.Where(e=>e.Estatus==true)
                .AsNoTracking()
                .ToListAsync();
            return vehiculos ?? new List<Vehiculo>();
        }

        public async Task<Vendedore> GetVendedorById(int Id)
        {
           var vendedor = await _context.Vendedores.FirstOrDefaultAsync(id=>id.IdVendedor==(Id));
            return vendedor ??    new Vendedore();
        }

        public async Task<List<Vendedore>> GetVendedores()
        {
            var vendedores = await _context.Vendedores.Where(e=>e.Estatus==true)
                .AsNoTracking()
                .ToListAsync();
            return vendedores ?? new List<Vendedore>();
        }

        // UPDATES
    }
}
