using API_DFSK.Context;
using API_DFSK.DTOs.DFSK;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Models;
using API_DFSK.Models.DFSK;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
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
        public async Task<List<ApiVehiculosBodega>> GetArticulosExistenciaBodegaVehiculos(string bodega)
        {
            decimal bod= decimal.Parse(bodega);
            var articulosbodega = await _context.ApiVehiculosBodegas
                .Where( b=>b.Bodega==bod )
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


        public async Task<List<ApiRepuestosMostrar>> GetArticuloBodegaByMarcayGrupo(string Marca, string Grupo, string Categoria, string Nombre, string Modelo)
        {

            var query = _context.ApiRepuestosMostrars.AsQueryable();

            if (!Marca.Equals("*"))
            {
                query = query.Where(c => c.Marca.Contains(Marca));
            }
            if (!Grupo.Equals("*"))
            {
                query = query.Where(c => c.Grupo!.Contains(Grupo));
            }
            if (!Categoria.Equals("*"))
            {
                query = query.Where(c => c.Categoria!.Contains(Categoria));
            }
            if (!Nombre.Equals("*"))
            {
                query = query.Where(c => c.Descripcion!.Contains(Nombre) || c.Articulo.Contains(Nombre) || c.Numeroparte!.Contains(Nombre) || c.Aplica!.Contains(Nombre));
            }
            if (!Modelo.Equals("*"))
            {
                query = query.Where(c => c.Modelo!.Contains(Modelo) || c.Aplica!.Contains(Modelo));
            }

            query = query.Where(c => !c.Marca.Contains("COSTEO"))
                         .Where(c => !c.Descripcion!.Contains("OXIDADAS") || c.Descripcion == null)
                         .Where(c => (c.Articulo.StartsWith("8") || c.Articulo.StartsWith("9")))
                         .Where(c => c.Venta > 0);

            query = query.OrderByDescending(e => e.Existencia)
                         .AsNoTracking();

            var articulosbodega = await query.ToListAsync();
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

        public async Task<List<Modelo>> GetModelos()
        {
            var modelos = await _context.Modelos.AsNoTracking().ToListAsync();
            return modelos ?? [];
        }

        public async Task<List<Modelo>> GetModelosByNombre(string Modelo)
        {
            var modelos = await _context.Modelos.Where(m => m.Modelo1!.Contains(Modelo)).AsNoTracking().ToListAsync();
            return modelos ?? [];
        }

        public async Task<List<Modelo>> GetModelosByFilters(string Modelo, string marca, string ano)
        {
            var modelos = await _context.Modelos.Where(m => m.Modelo1!.Equals(Modelo)
            && m.Marca!.Equals(marca)
            && m.Ano!.Equals(ano)
            ).AsNoTracking().ToListAsync();
            return modelos ?? [];
        }

        public async Task<List<ApiSerialesBodega>> GetSerialesBodega(string bodega, string articulo)
        {
          
            var query = _context.ApiSerialesBodegas.AsQueryable();
            
            if (!string.IsNullOrWhiteSpace(articulo) && !articulo.Equals("*"))
            {
                query = query.Where(c => c.Articulo!.Contains(articulo));
            }
           
            if (!string.IsNullOrWhiteSpace(bodega) && !bodega.Equals("*"))
            {
                if (int.TryParse(bodega, out int bodegaInt))
                {
                    query = query.Where(c => c.Bodega == bodegaInt);
                }
                else
                {
                    throw new ArgumentException("El valor de bodega debe ser un número válido.", nameof(bodega));
                }
            }
          
            query = query.OrderByDescending(e => e.Bodega)
                         .AsNoTracking();

            return await query.ToListAsync();
        }

    }
}
