using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class VehiculoRepository(IMapper mapper, ConcesionarioDfskContext context):IVehiculoRepository
    {
        private readonly IMapper _mapper=mapper;
        private readonly ConcesionarioDfskContext _context=context;

        //GET
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

        //POST
        public async Task<bool> InsertVehiculo(List<VehiculoDTO> vehiculos)
        {
            var insert = _mapper.Map<List<Vehiculo>>(vehiculos);
            await _context.Vehiculos.AddRangeAsync(insert);
            await _context.SaveChangesAsync();
            return true;

        }
        //PUT
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


    }
}
