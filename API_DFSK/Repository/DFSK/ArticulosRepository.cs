using API_DFSK.Context;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API_DFSK.Repository.DFSK
{
    public class ArticulosRepository : IArticulosRepository
    {
        private readonly DfskContext _context;
        public ArticulosRepository(DfskContext context)
        {
            _context = context;
        }

        public async Task<List<Articulo>> GetArticulos()
        {
            var articulos = await _context.Articulos
                           .OrderByDescending(a => a.Articulo1)
                           .Take(50)
                           .AsNoTracking()
                           .ToListAsync();

            return articulos;
        }
        public async Task<List<ArticulosBodegaApi>> GetAllArticulosBodega()
        {
            var articulos = await _context.ArticulosBodegaApis
                .AsNoTracking()
                .ToListAsync();

            return articulos;
        }

        public async Task<List<ArticulosBodegaApi>> GetArticulosExistenciaBodega()
        {
            var articulosbodega = await _context.ArticulosBodegaApis
                .Where(e => e.Existencia > 0 && ( e.Articulo.StartsWith("8") ||  e.Articulo.StartsWith("9")))
                .OrderByDescending(e => e.Existencia)
                .AsNoTracking()
                .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ArticulosBodegaApi>> GetArticuloBodegaByCodigo(string Codigo)
        {
            var articulosbodega = await _context.ArticulosBodegaApis
               .Where(c => c.Articulo.Contains(Codigo))
               .AsNoTracking()
               .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ArticulosBodegaApi>> GetArticuloBodegaByMarca(string Marca)
        {
            var articulosbodega = await _context.ArticulosBodegaApis
                         .Where(c => c.Marca.Contains(Marca))
                         .AsNoTracking()
                         .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ArticulosBodegaApi>> GetArticuloBodegaByNombre(string Nombre)
        {
            var articulosbodega = await _context.ArticulosBodegaApis
                  .Where(c => c.Descripcion.Contains(Nombre))
                  .AsNoTracking()
                  .ToListAsync();
            return articulosbodega;
        }

    }
}
