using System.Linq;
using API_DFSK.Context;
using API_DFSK.DTOs;
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
        public IActionResult GetArticulos()
        {
            var articulos = _context.Articulos
                 .AsEnumerable()
                .TakeLast(50)
                .ToList();
            return Ok(articulos);
        }

        [HttpGet("ArticulosBodega")]
        public IActionResult GetArticulosBodega()
        {

            var articulosbodega = _context.ArticulosBodegaApis
                .ToList();
            return Ok(articulosbodega);

        }
    }
}

