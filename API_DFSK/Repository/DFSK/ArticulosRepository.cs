using API_DFSK.Context;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Models;
using API_DFSK.Models.DFSK;
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

    
        public async Task<List<ApiArticulosGrupo>> GetAllArticulosBodega()
        {
            var articulos = await _context.ApiArticulosGrupos
                .AsNoTracking()
                .ToListAsync();

            return articulos;
        }

        public async Task<List<ApiArticulosGrupo>> GetArticulosExistenciaBodega()
        {
            var articulosbodega = await _context.ApiArticulosGrupos
                .Where(e => e.Existencia > 0 && ( e.Articulo.StartsWith("8") ||  e.Articulo.StartsWith("9")))
                .OrderByDescending(e => e.Existencia)
                .AsNoTracking()
                .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ApiArticulosGrupo>> GetArticuloBodegaByCodigo(string Codigo)
        {
            var articulosbodega = await _context.ApiArticulosGrupos
               .Where(c => c.Articulo.Contains(Codigo))
               .AsNoTracking()
               .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ApiArticulosGrupo>> GetArticuloBodegaByMarca(string Marca)
        {
            var articulosbodega = await _context.ApiArticulosGrupos
                         .Where(c => c.Marca.Contains(Marca))
                         .AsNoTracking()
                         .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ApiArticulosGrupo>> GetArticuloBodegaByNombre(string Nombre)
        {
            var articulosbodega = await _context.ApiArticulosGrupos
                  .Where(c => c.Descripcion.Contains(Nombre))
                  .AsNoTracking()
                  .ToListAsync();
            return articulosbodega;
        }

    }
}
