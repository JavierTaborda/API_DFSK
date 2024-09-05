using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.DTOs.DFSK;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using API_DFSK.Models.DFSK;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.DFSK
{
    public class CrearTXTRepository : ICrearTXTRepository
    {
        private readonly DfskContext _context;
        private readonly IMapper _mapper;
        public CrearTXTRepository(DfskContext context, IMapper mapper)
        {
            _context = context;
            _mapper=mapper;
        }

        public async Task<ResumentxtDTO> CreateTXT(ResumentxtDTO data)
        {
          
            var insert= _mapper.Map<Resumentxt>(data);
            await _context.Resumentxts.AddAsync(insert);
            await _context.SaveChangesAsync();
            return _mapper.Map<ResumentxtDTO>(insert);
        
        }

        public async Task<ResumentxtDTO> GetTXT(int Id)
        {
            var resumens= await _context.Resumentxts
                .Include(l=>l.Lineatxts)
                .FirstAsync(r=>r.Idresumentxt.Equals(Id));
            return _mapper.Map<ResumentxtDTO>(resumens);
           
        }

        public async  Task<List<ResumentxtDTO>> ListaTxt(string factura1, string factura2)
        {
            var resumens = await _context.Resumentxts
                .AsNoTracking()
                .Include(l => l.Lineatxts)
                .ToListAsync();
            return _mapper.Map<List<ResumentxtDTO>>(resumens);

          
        }
    }
}
