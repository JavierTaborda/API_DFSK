using API_DFSK.Context;
using API_DFSK.DTOs.DFSK;
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


        public async Task<List<ApiRepuestosMostrar>> GetAllArticulosBodega()
        {
            var articulos = await _context.ApiRepuestosMostrars
                .AsNoTracking()
                .ToListAsync();

            return articulos;
        }

        public async Task<List<ApiRepuestosMostrar>> GetArticulosExistenciaBodega()
        {
            var articulosbodega = await _context.ApiRepuestosMostrars
                .Where(e => e.Venta > 0 
                && (e.Articulo.StartsWith("8") || e.Articulo.StartsWith("9"))
                && !(e.Marca.Contains("COSTEO"))
                && !(e.Descripcion!.Contains("OXIDADAS"))
                )
                .OrderByDescending(e => e.Existencia)
                .AsNoTracking()
                .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ApiRepuestosMostrar>> GetArticuloBodegaByCodigo(string Codigo)
        {
            var articulosbodega = await _context.ApiRepuestosMostrars
               .Where(c => c.Articulo.Contains(Codigo))
               .AsNoTracking()
               .ToListAsync();
            return articulosbodega;
        }
        public async Task<List<ApiRepuestosMostrar>> GetVehiculosBodegaByCodigo(string Codigo)
        {
            var articulosbodega = await _context.ApiRepuestosMostrars.AsNoTracking()
                .Where(c => c.Articulo.Equals(Codigo) && c.Ano != null).ToListAsync();

            return articulosbodega;
        }

        public async Task<List<ApiRepuestosMostrar>> GetArticuloBodegaByMarcayGrupo(string Marca, string Grupo, string Categoria, string Nombre)
        {
            string queryMarca = "", queryGrupo = "",queryCat="", queryNombre = "";
            if (!Marca.Equals("*"))
            {
                queryMarca = Marca;
            }
            if (!Grupo.Equals("*"))
            {
                queryGrupo = Grupo;
            }
            if (!Categoria.Equals("*"))
            {
                queryCat = Categoria;
            }
            if (!Nombre.Equals("*"))
            {
                queryNombre = Nombre;
            }

            var articulosbodega = await _context.ApiRepuestosMostrars
                         .Where(c => c.Marca.Contains(queryMarca) 
                            && c.Grupo!.Contains(queryGrupo) 
                            && c.Categoria!.Contains(queryCat)
                            && (c.Descripcion!.Contains(queryNombre) || c.Articulo.Contains(queryNombre) || c.Numeroparte!.Contains(queryNombre))
                            && !(c.Marca.Contains("COSTEO")) 
                            && !(c.Descripcion.Contains("OXIDADAS")) 
                            && (c.Articulo.StartsWith("8") || c.Articulo.StartsWith("9"))
                            && c.Venta>0)
                         .AsNoTracking()
                         .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ApiRepuestosMostrar>> GetArticuloBodegaByNombre(string Nombre)
        {
            var articulosbodega = await _context.ApiRepuestosMostrars
                  .Where(c => c.Descripcion!.Contains(Nombre))
                  .AsNoTracking()
                  .ToListAsync();
            return articulosbodega;
        }

        public async Task<List<ApiCodigosMarca>> GetCodigosByMarca()
        {
            var codigosmarcas = await _context.ApiCodigosMarcas
                .Where(c => !c.Descripcion.Contains("DESUSO") && !c.Descripcion.Contains("MATERIAL POP"))
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

        public async Task<List<Gruposrepuesto>> GetGrupos()
        {
            var grupos = await _context.Gruposrepuestos.AsNoTracking().ToListAsync();
            return grupos;
        }
        public async Task<List<Categoriarepuesto>> GetCategorias()
        {
            var categorias = await _context.Categoriarepuestos.AsNoTracking().ToListAsync();
            return categorias;
        }

        public async Task<string> UpdateImagenURL(UpdateImagenDTO updateimagen)  
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    await _context.Database.ExecuteSqlRawAsync(
                        "EXEC UpdateImagenUrl @Articulo = {0}, @UrlImagen = {1}",
                        updateimagen.Articulo, updateimagen.UrlImagen);

                    await transaction.CommitAsync();
                    return "Exitoso";
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }
    }
}
