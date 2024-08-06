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
        private readonly IMapper _mapper;

        public SolicitudesRepository(ConcesionarioDfskContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //GET
        #region GETS
        public async Task<EstadoDTO> GetEstadoById(int Id)
        {

            var estado = await _context.Estados.FirstOrDefaultAsync(e => e.IdEstado == Id);
            return _mapper.Map<EstadoDTO>(estado) ?? new EstadoDTO();
        }

        public async Task<List<EstadoDTO>> GetEstados()
        {
            var estados = await _context.Estados.AsNoTracking().ToListAsync();
            return _mapper.Map<List<EstadoDTO>>(estados) ?? new List<EstadoDTO>();
        }

        public async Task<RepuestoDTO> GetRepuestoById(int Id)
        {
            var repuesto = await _context.Repuestos.FirstOrDefaultAsync(r => r.IdRepuesto == Id);
            return _mapper.Map<RepuestoDTO>(repuesto) ?? new RepuestoDTO();
        }

        public async Task<RepuestoDTO> GetRepuestoCodigo(string codigo)
        {
            var repuesto = await _context.Repuestos.FirstOrDefaultAsync(r => r.Codigo.Contains(codigo));
            return _mapper.Map<RepuestoDTO>(repuesto) ?? new RepuestoDTO();
        }

        public async Task<List<RepuestoDTO>> GetRepuestosByVehiculo(int Id, string codigo)
        {
            var repuestos = await _context.Repuestos.Where(r => r.IdVehiculo == (Id) || r.IdVehiculoNavigation.Codigo.Contains(codigo))
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<RepuestoDTO>>(repuestos) ?? new List<RepuestoDTO>();
        }

        public async Task<SolicitudDTO> GetSolicitudById(int Id)
        {
            var solicitud = await _context.Solicitudes
                .Include(ven => ven.IdVendedorNavigation)
                .Include(rep => rep.IdRepuestoNavigation).ThenInclude(rep => rep.IdVehiculoNavigation)
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


        public async Task<VehiculoDTO> GetVehiculoByIdCodigo(int Id, string codigo)
        {
            var vehiculo = await _context.Vehiculos.FirstOrDefaultAsync(id => id.IdVehiculo == Id || id.Codigo.Equals(codigo));
            return _mapper.Map<VehiculoDTO>(vehiculo) ?? new VehiculoDTO();
        }

        public async Task<List<VehiculoDTO>> GetVehiculos()
        {
            var vehiculos = await _context.Vehiculos.Where(e => e.Estatus == true)
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<VehiculoDTO>>(vehiculos) ?? new List<VehiculoDTO>();
        }

        public async Task<VendedorDTO> GetVendedorById(int Id)
        {
            var vendedor = await _context.Vendedores.FirstOrDefaultAsync(id => id.IdVendedor == (Id));
            return _mapper.Map<VendedorDTO>(vendedor) ?? new VendedorDTO();
        }

        public async Task<List<VendedorDTO>> GetVendedores()
        {
            var vendedores = await _context.Vendedores.Where(e => e.Estatus == true)
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<VendedorDTO>>(vendedores) ?? new List<VendedorDTO>();
        }
        #endregion

        // POST
        public async Task<bool> InsertSolicitud(List<SolicitudDTO> solicitudes)
        {
            var insert=_mapper.Map<List<Solicitude>>(solicitudes);
            await _context.Solicitudes.AddRangeAsync(insert);
            await _context.SaveChangesAsync();
            return true;
        }
     
        public Task InsertRepuesto(List<RepuestoDTO> repuestos)
        {
            throw new NotImplementedException();
        }

        public Task InsertEstado(List<EstadoDTO> Estados)
        {
            throw new NotImplementedException();
        }


        public Task InsertVehiculo(List<VehiculoDTO> vehiculos)
        {
            throw new NotImplementedException();
        }

        public Task InsertVendedor(List<VendedorDTO> Vendedores)
        {
            throw new NotImplementedException();
        }

      

    }
}
