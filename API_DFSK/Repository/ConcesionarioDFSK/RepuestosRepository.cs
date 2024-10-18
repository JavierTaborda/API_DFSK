using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class RepuestosRepository(IMapper mapper, ConcesionarioDfskContext context) : IRepuestosRepository
    {
        private readonly IMapper _mapper = mapper;
        private readonly ConcesionarioDfskContext _context = context;

        #region GETS

        public async Task<List<RepuestoDTO>> GetRepuestos()
        {
            var repuestos = await _context.Repuestos.ToListAsync();
            return _mapper.Map<List<RepuestoDTO>>(repuestos);
              
         }
        public async Task<RepuestoVehiculoDTO> GetRepuestoById(int Id)
        {
            var repuesto = await _context.Repuestos
                .Include(v => v.IdVehiculoNavigation)
                .FirstOrDefaultAsync(r => r.IdRepuesto == Id);
            return _mapper.Map<RepuestoVehiculoDTO>(repuesto);
        }

        public async Task<RepuestoVehiculoDTO> GetRepuestoCodigo(string codigo)
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

        //public async Task<List<RepuestoDTO>> GetRepuestoFiltro(string nombre, string marca, bool inventario, string modelo)
        //{
        //    var repuestos = await _context.Repuestos.Where(r => r.Descripcion!.Contains(nombre) 
        //                                                    && r.Marca!.Contains(marca)
        //                                                    && r.EnInventario.Equals(inventario)
        //                                                    && r.IdVehiculoNavigation.Modelo!.Contains(modelo)
        //                                                    ).ToListAsync();
        //        return _mapper.Map<List<RepuestoDTO>>(repuestos) ?? [];
        //}
        public async Task<List<RepuestoDTO>> GetRepuestoFiltro(string? nombre, string? marca, bool? inventario, string? modelo)
        {
            var query = _context.Repuestos.AsQueryable();

            if (!string.IsNullOrEmpty(nombre))
            {
                query = query.Where(r => r.Nombre!.Contains(nombre));
            }

            if (!string.IsNullOrEmpty(marca))
            {
                query = query.Where(r => r.Marca!.Contains(marca));
            }

            if (inventario.HasValue)
            {
                query = query.Where(r => r.EnInventario == inventario.Value);
            }

            if (!string.IsNullOrEmpty(modelo))
            {
                query = query.Where(r => r.IdVehiculoNavigation.Modelo!.Contains(modelo));
            }


            var result = await query.ToListAsync();
            return _mapper.Map<List<RepuestoDTO>>(result);

        }

        #endregion 

        //consultar codigos e insertar si no existen
        public async Task<List<RepuestoDTO>> GetRepuestoList(List<CodigosRepuestosDTO> codigos)
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
                throw;
            }
        }

        #region POST
        public async Task<RepuestoDTO> InsertRepuesto(RepuestoDTO repuesto)
        {
            var existingCodigo = await _context.Repuestos
                .AsNoTracking()
                .Where(c => c.Codigo == repuesto.Codigo && c.Nombre == repuesto.Nombre && c.Marca == repuesto.Marca && c.IdVehiculo == repuesto.IdVehiculo)
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

               return null!;
            }
        }
        #endregion

        #region PUTS
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


        #endregion

    }
}
