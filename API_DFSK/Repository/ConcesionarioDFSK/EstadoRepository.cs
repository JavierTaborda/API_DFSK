using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class EstadoRepository(IMapper mapper, ConcesionarioDfskContext context) : IEstadoRepository
    {
        private readonly IMapper _mapper = mapper;
        private readonly ConcesionarioDfskContext _context = context;

        //GET
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

        //POST
        public async Task<string> InsertEstado(EstadoDTO Estados)
        {
            if (await CheckOrden(Estados.Orden))
            {
                return "Orden no Disponinle";
            }

            var insert = _mapper.Map<Estado>(Estados);
            await _context.Estados.AddAsync(insert);
            await _context.SaveChangesAsync();
            return "Exito";
        }

        //PUT
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

        
        public async Task<bool> CheckOrden(int orden)
        {
            var exists = await _context.Estados.AnyAsync(e => e.Orden == orden && e.Estatus);
            return exists;
        }


    }
}
