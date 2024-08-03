using System.Linq;
using API_DFSK.Context;
using API_DFSK.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Controllers.Articulos
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly DfskContext _context;
        public ArticulosController(DfskContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticulos()
        {
            var articulos = await _context.Articulos
            .OrderByDescending(a => a.Articulo1) 
            .Take(50)
            .ToListAsync();
            return Ok(articulos);
        }

        [HttpGet("Bodega")]
        public async Task<IActionResult> GetArticulosBodega()
        {
            var articulosbodega = await _context.ArticulosBodegaApis
                .ToListAsync();
            return Ok(articulosbodega);
        }

        [HttpGet("Bodega/Codigo/{Codigo}")]
        public async Task<IActionResult> GetArticuloBodegaByCodigo(string Codigo)
        {
            var articulosbodega = await _context.ArticulosBodegaApis
                .Where(c => c.Articulo.Contains(Codigo))
                .ToListAsync();
            return Ok(articulosbodega);
        }

        [HttpGet("Bodega/Nombre/{Nombre}")]
        public async Task<IActionResult> GetArticuloBodegaByNombre(string Nombre)
        {

            var articulosbodega = await _context.ArticulosBodegaApis
                .Where(c => c.Descripcion.Contains(Nombre))
                .ToListAsync();
            return Ok(articulosbodega);

        }

        [HttpGet("Bodega/Marca/{Marca}")]
        public async Task<IActionResult> GetArticuloBodegaByMarca(string Marca)
        {
            var articulosbodega = await _context.ArticulosBodegaApis
                .Where(c => c.Marca.Contains(Marca))
                .ToListAsync();
            return Ok(articulosbodega);
        }
    }
}

