using API_DFSK.Context;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Models.DFSK;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.DFSK
{
    public class CrearTXTRepository : ICrearTXTRepository
    {
        private readonly DfskContext _context;
        public CrearTXTRepository(DfskContext context)
        {
            _context = context;
        }

        public async Task<Resumentxt> CreateTXT(Resumentxt data)
        {
            await _context.Resumentxts.AddAsync(data);
            await _context.SaveChangesAsync();
            return new Resumentxt();
        }

        public async Task<Resumentxt> GetTXT(int Id)
        {
            var resumens= await _context.Resumentxts
                .Include(l=>l.Lineatxts)
                .FirstAsync(r=>r.Idresumentxt.Equals(Id));
            return resumens;
        }

        public async  Task<List<Resumentxt>> ListaTxt(string factura1, string factura2)
        {
            var resumens = await _context.Resumentxts
                .AsNoTracking()
                .Include(l => l.Lineatxts)
                .ToListAsync();
            return resumens ?? new List<Resumentxt>();
        }
    }
}
