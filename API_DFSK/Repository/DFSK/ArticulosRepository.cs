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
                .Where(e => e.Existencia >= 0 && ( e.Articulo.StartsWith("8") ||  e.Articulo.StartsWith("9")) && !(e.Marca.Contains("COSTEO")))
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
        public async Task<List<ApiArticulosGrupo>> GetVehiculosBodegaByCodigo(string Codigo)
        {
            var articulosbodega = await _context.ApiArticulosGrupos.AsNoTracking()
                .Where(c => c.Articulo.Equals(Codigo) && c.Ano != null).ToListAsync();
               
            return articulosbodega;
        }

        public async Task<List<ApiArticulosGrupo>> GetArticuloBodegaByMarcayGrupo(string Marca, string Grupo, string Nombre)
        {
            string queryMarca="", queryGrupo="", queryNombre="";
            if(!Marca.Equals("*"))
            {
                queryMarca = Marca;
            }
            if (!Grupo.Equals("*"))
            {
                queryGrupo = Grupo;
            }           
            if (!Nombre.Equals("*"))
            {
                queryNombre = Nombre;
            }
           
            var articulosbodega = await _context.ApiArticulosGrupos
                         .Where(c => c.Marca.Contains(queryMarca) && c.Grupo.Contains(queryGrupo) && (c.Descripcion!.Contains(queryNombre) || c.Articulo.Contains(queryNombre))
                           && !(c.Marca.Contains("COSTEO")) && (c.Articulo.StartsWith("8") || c.Articulo.StartsWith("9")))
                         .AsNoTracking()
                         .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ApiArticulosGrupo>> GetArticuloBodegaByNombre(string Nombre)
        {
            var articulosbodega = await _context.ApiArticulosGrupos
                  .Where(c => c.Descripcion!.Contains(Nombre))
                  .AsNoTracking()
                  .ToListAsync();
            return articulosbodega;
        }
     
        public async Task<List<ApiCodigosMarca>> GetCodigosByMarca()
        {
            var codigosmarcas = await _context.ApiCodigosMarcas
                    .OrderBy(e => e.Descripcion)
                    .AsNoTracking()
                    .ToListAsync();
            return codigosmarcas;
        }

        public async Task<List<ApiCodigosGrupo>> GetCodigosByGrupo()
        {
            var codigosgrupos = await _context.ApiCodigosGrupos.AsNoTracking().ToListAsync();
            return codigosgrupos;
        }
    }
}
