using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class EntregasRepository(IMapper mapper, ConcesionarioDfskContext context) : IEntregasRepository
    {
        private readonly IMapper _mapper = mapper;
        private readonly ConcesionarioDfskContext _context = context;

        public async Task<EstadoEntregaDTO> getEstadoEntregaId(int Id)
        {

            var estadosentrega =await _context.EstadosEntregas.AsNoTracking().FirstAsync(entrega=>entrega.IdEstadosEnvio==Id);
            return  _mapper.Map<EstadoEntregaDTO>(estadosentrega);
        }

        public async Task<List<EstadoEntregaDTO>> getEstadosEntrega()
        {
            var estadosentrega = await _context.EstadosEntregas
                .AsNoTracking()
                .OrderBy(e=>e.Estado)
                .ToListAsync();
            return _mapper.Map<List<EstadoEntregaDTO>>(estadosentrega);
        }

        public async Task<string> InsertEstadoEntrega(EstadoEntregaDTO estado)
        {
            

            var insert = _mapper.Map<EstadosEntrega>(estado);
            await _context.EstadosEntregas.AddAsync(insert);
            await _context.SaveChangesAsync();
            return "Exito";
        }

        public async Task<string> UpdateEstadoEntrega(EstadoEntregaDTO estado)
        {

            var entity = await _context.EstadosEntregas.FindAsync(estado.IdEstadosEnvio);
            if (entity == null)
            {
                return null!;
            }

            _mapper.Map(estado, entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return "Exito";
        }
    }
}
