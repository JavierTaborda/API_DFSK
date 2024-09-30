using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class SolicitudesRepository(ConcesionarioDfskContext context, IMapper mapper) : ISolicitudesRepository
    {
        private readonly ConcesionarioDfskContext _context=context;
        private readonly IMapper _mapper=mapper;

        //GET
        #region GETS
        public async Task<EstadoDTO?> GetEstadoById(int Id)
        {

            var estado = await _context.Estados.FirstOrDefaultAsync(e => e.IdEstado == Id);
            return _mapper.Map<EstadoDTO?>(estado);
        }

        public async Task<List<EstadoDTO>> GetEstados()
        {
            var estados = await _context.Estados.AsNoTracking().ToListAsync();
            return _mapper.Map<List<EstadoDTO>>(estados);
        }

        public async Task<RepuestoVehiculoDTO?> GetRepuestoById(int Id)
        {
            var repuesto = await _context.Repuestos
                .Include(v => v.IdVehiculoNavigation)
                .FirstOrDefaultAsync(r => r.IdRepuesto == Id);
            return _mapper.Map<RepuestoVehiculoDTO>(repuesto);
        }

        public async Task<RepuestoVehiculoDTO?> GetRepuestoCodigo(string codigo)
        {
            var repuesto = await _context.Repuestos
                .Include(v => v.IdVehiculoNavigation)
                .FirstOrDefaultAsync(r => r.Codigo!.Contains(codigo));
            return _mapper.Map<RepuestoVehiculoDTO>(repuesto);
        }

        public async Task<List<RepuestoVehiculoDTO>> GetRepuestosByVehiculo(int Id, string codigo)
        {
            var repuestos = await _context.Repuestos.Where(r => r.IdVehiculo == (Id) || r.IdVehiculoNavigation.Codigo!.Contains(codigo))
                .Include(v => v.IdVehiculoNavigation)
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<RepuestoVehiculoDTO>>(repuestos) ?? [];
        }

        //consultar codigos e insertar si no existen
        public async Task<List<RepuestoDTO?>> GetRepuestoList(List<CodigosRepuestosDTO> codigos)
        {
            var codigoList = codigos.Select(c => c.Codigo).ToList();

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var repuestos = await _context.Repuestos
                    .Where(r => codigoList.Contains(r.Codigo))
                    //.Include(v => v.IdVehiculoNavigation)
                    .AsNoTracking()
                    .ToListAsync();

                var vehiculo = await _context.Vehiculos
                    .Where(c => c.Modelo!.Contains("Sin Modelo"))
                    .Select(id => id.IdVehiculo)
                    .FirstOrDefaultAsync();

                var existingCodigos = repuestos.Select(r => r.Codigo).ToList();
                var newCodigos = codigoList.Except(existingCodigos).ToList();
                var insertCodigos = codigos.Where(c => newCodigos.Contains(c.Codigo)).ToList();

                foreach (var c in insertCodigos)
                {
                    if (!await _context.Repuestos.AnyAsync(r => r.Codigo == c.Codigo))
                    {
                        var newRepuesto = new Repuesto
                        {
                            IdRepuesto = 0,
                            Codigo = c.Codigo,
                            Nombre = c.Nombre,
                            Descripcion = "",
                            Precio = 0,
                            IdVehiculo = vehiculo,
                            Estatus = true,
                            Marca = c.Marca,
                            EnInventario = true
                        };
                        _context.Repuestos.Add(newRepuesto);
                        repuestos.Add(newRepuesto);
                    }
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                var result = await _context.Repuestos
              .Where(r => codigoList.Contains(r.Codigo))
              //.Include(v => v.IdVehiculoNavigation)
              .AsNoTracking()
              .ToListAsync();
                return _mapper.Map<List<RepuestoDTO>>(result)!;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw ;
            }
        }


        public async Task<SolicitudDTO?> GetSolicitudById(int Id)
        {
            var solicitud = await _context.Solicitudes
                .Include(ven => ven.IdResumenSolicitudNavigation.IdUsuarioNavigation)
                .Include(rep => rep.IdRepuestoNavigation).ThenInclude(rep => rep.IdVehiculoNavigation)
                .Include(rep => rep.IdEstadoNavigation)
                .FirstOrDefaultAsync(id => id.IdSolicitud == Id);

            if (solicitud == null)
                return null;

            return _mapper.Map<SolicitudDTO>(solicitud);
        }
        public async Task<List<SolicitudDTO>> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int iduser)
        {

            IQueryable<Solicitude> query = _context.Solicitudes
                .Include(ven => ven.IdResumenSolicitudNavigation.IdUsuarioNavigation)
                .Include(rep => rep.IdRepuestoNavigation).ThenInclude(rep => rep.IdVehiculoNavigation)
                .Include(rep => rep.IdEstadoNavigation)
                .AsNoTracking();

            query = query.Where(f => f.FechaSolicitud!.Value.Date >= f1.Date && f.FechaSolicitud.Value.Date <= f2.Date);

            //switch (tipofecha)
            //{
            //    case 0:
            //        query = query.Where(f => f.FechaSolicitud.Value.Date >= f1.Date && f.FechaSolicitud.Value.Date <= f2.Date);
            //        break;
            //    case 1:
            //        query = query.Where(f => f.FechaCompra.Value.Date >= f1.Date && f.FechaCompra.Value.Date <= f2.Date);
            //        break;
            //    case 2:
            //        query = query.Where(f => f.FechaLlegada.Value.Date >= f1.Date && f.FechaLlegada.Value.Date <= f2.Date);
            //        break;
            //    default:
            //        throw new ArgumentException("tipofecha no válido");
            //}

            query = query.Where(f => f.IdEstado == idestado
                                     && f.IdResumenSolicitudNavigation.IdUsuario == iduser);

            var solicitudes = await query.ToListAsync();

            return _mapper.Map<List<SolicitudDTO>>(solicitudes) ?? [];
        }

        public async Task<List<ResumenSolicitudDTO>> GetResumenSolicitudes(DateTime f1, DateTime f2, string estado, int iduser)
        {
            IQueryable<ResumenSolicitud> query = _context.ResumenSolicituds
                .AsNoTracking()
                .Include(ven => ven.IdUsuarioNavigation)
                .Include(f => f.Solicitudes).ThenInclude(rep => rep.IdRepuestoNavigation).ThenInclude(rep => rep.IdVehiculoNavigation)
                .Include(rep => rep.Solicitudes).ThenInclude(e => e.IdEstadoNavigation)
                .Include(r => r.Solicitudes).ThenInclude(re => re.IdResponsableSolicitudNavigation);

            query = query.Where(f => f.FechaCreacion!.Value.Date >= f1.Date && f.FechaCreacion!.Value.Date <= f2.Date);

            if (estado != "Todos")
            {
                if (bool.TryParse(estado, out bool esta))
                {
                    query = query.Where(f => f.Estatus == esta);
                }
            }
            if (iduser > 0)
            {
                query = query.Where(v => v.IdUsuario == iduser);
            }
            var resumen = await query.ToListAsync();

            return _mapper.Map<List<ResumenSolicitudDTO>>(resumen);
        }

        public async Task<VehiculoDTO> GetVehiculoById(int Id)
        {
            var vehiculo = await _context.Vehiculos.FirstOrDefaultAsync(id => id.IdVehiculo == Id);
            return _mapper.Map<VehiculoDTO>(vehiculo);
        }
        public async Task<List<VehiculoDTO>> GetVehiculoByCodigo(string codigo)
        {
            var vehiculo = await _context.Vehiculos
                .Where(co => co.Codigo!.Contains(codigo))
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<VehiculoDTO>>(vehiculo);
        }

        public async Task<List<VehiculoDTO>> GetVehiculos()
        {
            var vehiculos = await _context.Vehiculos
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<VehiculoDTO>>(vehiculos) ?? [];
        }

  

        public async Task<Dictionary<string, int>> GetIdsSolicitudIncial()
        {
            var idestadoinicial = await _context.Estados
                    .Where(c => c.Descripcion!.Contains("Registro Inicial"))
                    .Select(id => id.IdEstado)
                    .FirstOrDefaultAsync();

            var idresponsableinicial = await _context.ResponsableSolicituds
             .Where(c => c.Nombre!.Contains("Sin Definir"))
             .Select(id => id.IdResponsableSolicitud)
             .FirstOrDefaultAsync();

            Dictionary<string, int> ids = [];
            if (idestadoinicial != 0)
            {
                ids.Add("Estado", idestadoinicial);
            }


            if (idresponsableinicial != 0)
            {
                ids.Add("Responsable", idresponsableinicial);
            }
            return ids;
        }

        #endregion

        // POST

        #region POST

        public async Task<bool> InsertResumenSolicitud(ResumenSolicitudDTO Solicitud)
        {
            var insert = _mapper.Map<ResumenSolicitud>(Solicitud);
            await _context.ResumenSolicituds.AddAsync(insert);
            await _context.SaveChangesAsync();
            return true;
        }
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
        public async Task<RepuestoDTO> InsertRepuesto(RepuestoDTO repuesto)
        {
            var existingCodigo = await _context.Repuestos
                .AsNoTracking()
                .Where(c => c.Codigo == repuesto.Codigo && c.Nombre==repuesto.Nombre && c.Marca==repuesto.Marca && c.IdVehiculo==repuesto.IdVehiculo )
                .Select(r => r.Codigo)
                .FirstOrDefaultAsync();

            if (existingCodigo == null)
            {
                var insert = _mapper.Map<Repuesto>(repuesto);
                await _context.Repuestos.AddAsync(insert);
                await _context.SaveChangesAsync();
                return _mapper.Map<RepuestoDTO>(insert);
            }
            else
            {
              
                throw new InvalidOperationException("Ya existe este código de repuesto.");
            }
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
        public async Task<bool> InsertVendedor(List<VendedorDTO> Vendedores)
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
            var soli = await _context.Solicitudes.AsNoTracking().FirstOrDefaultAsync(s => s.IdSolicitud == solicitud.IdSolicitud);

            if (soli == null)
            {
                return null!;
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
                return null!;
            }
            _mapper.Map(repuestos, entity);
            entity.IdVehiculoNavigation = null!;//Limpiar para no insertar 
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
                return null!;
            }
            _mapper.Map(vehiculos, entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();
            var result = _mapper.Map<VehiculoDTO>(entity);
            return result;
        }
        public async Task<VehiculoDTO> AddUpdateVehiculo(VehiculoDTO vehiculos)
        {
            var entity = await _context.Vehiculos.FirstOrDefaultAsync(c => c.Codigo == vehiculos.Codigo);
            if (entity == null)
            {
                entity = _mapper.Map<Vehiculo>(vehiculos);
            }
            else
            {
                if (entity.IdVehiculo > 0)
                {
                    vehiculos.IdVehiculo = entity.IdVehiculo;
                }
                _mapper.Map(vehiculos, entity);
            }

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
                return null!;
            }

            _mapper.Map(Estados, entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<EstadoDTO>(entity);
            return result;
        }

  
        #endregion
    }
}
