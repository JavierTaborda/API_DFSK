using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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

        #region POST
        public async Task<bool> InsertSolicitud(List<SolicitudDTO> solicitudes)
        {
            var insert = _mapper.Map<List<Solicitude>>(solicitudes);
            await _context.Solicitudes.AddRangeAsync(insert);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> InsertSolicitudRepuesto(SolicitudRepuestoDTO solicitud)
        {
            var insert = _mapper.Map<Solicitude>(solicitud);
            await _context.Solicitudes.AddAsync(insert);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> InsertRepuesto(List<RepuestoDTO> repuestos)
        {
            var insert = _mapper.Map<List<Repuesto>>(repuestos);
            await _context.Repuestos.AddRangeAsync(insert);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> InsertEstado(List<EstadoDTO> Estados)
        {
            var insert = _mapper.Map<List<Estado>>(Estados);
            await _context.Estados.AddRangeAsync(insert);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> InsertVehiculo(List<VehiculoDTO> vehiculos)
        {
            var insert = _mapper.Map<List<Vehiculo>>(vehiculos);
            await _context.Vehiculos.AddRangeAsync(insert);
            await _context.SaveChangesAsync();
            return true;

        }
        public async  Task<bool> InsertVendedor(List<VendedorDTO> Vendedores)
        {
            var insert = _mapper.Map<List<Vendedore>>(Vendedores);
            await _context.Vendedores.AddRangeAsync(insert);
            await _context.SaveChangesAsync();
            return true;

        }

        #endregion

        //PUTS
        #region PUTS
        public async Task<bool> UpdateSolicitud(List<SolicitudDTO> solicitudes)
        {
            var entity = _mapper.Map<List<Solicitude>>(solicitudes);
            _context.UpdateRange(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<SolicitudRepuestoDTO> UpdateSolicitudRepuesto(SolicitudRepuestoDTO solicitud)
        {
            var soli = await _context.Solicitudes.AsNoTracking().FirstOrDefaultAsync(s=>s.IdSolicitud==solicitud.IdSolicitud);
            
            if (soli == null)
            {
                return null;
            }

            var entity = _mapper.Map<Solicitude>(solicitud);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<SolicitudRepuestoDTO>(entity);
            return result;
        }

        public async Task<RepuestoDTO> UpdateRepuesto(RepuestoDTO repuestos)
        {
            var entity = await _context.Repuestos.FindAsync(repuestos.IdRepuesto);
            if (entity == null)
            {
                return null;
            }           
            _mapper.Map(repuestos, entity);
            entity.IdVehiculoNavigation = null;//Limpiar para no insertar 
            _context.Update(entity);
            await _context.SaveChangesAsync();
            var result = _mapper.Map<RepuestoDTO>(entity);
           
            return result;
        }

        public async Task<VehiculoDTO> UpdateVehiculo(VehiculoDTO vehiculos)
        {
            var entity = await _context.Vehiculos.FindAsync(vehiculos.IdVehiculo);
            if (entity == null)
            {
                return null;
            }

            _mapper.Map(vehiculos, entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<VehiculoDTO>(entity);
            return result;
        }

        public async Task<EstadoDTO> UpdateEstado(EstadoDTO Estados)
        {
            var entity = await _context.Estados.FindAsync(Estados.IdEstado);
            if (entity == null)
            {
                return null;
            }

            _mapper.Map(Estados, entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<EstadoDTO>(entity);
            return result;
        }

        public async Task<VendedorDTO> UpdateVendedor(VendedorDTO Vendedores)
        {
            var entity = await _context.Vendedores.FindAsync(Vendedores.IdVendedor);
            if (entity == null)
            {
                return null;
            }

            _mapper.Map(Vendedores, entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<VendedorDTO>(entity);
            return result;
        }
        #endregion
    }
}
