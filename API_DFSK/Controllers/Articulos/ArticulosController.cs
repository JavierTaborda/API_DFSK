using API_DFSK.Interfaces.DFSK;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace API_DFSK.Controllers.Articulos
{
    [Route("api/[controller]")]
    [EnableCors("AllowAnyOrigin")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly IArticulosRepository _articuloRepo;
        public ArticulosController( IArticulosRepository articulosRepo)
        {
            _articuloRepo = articulosRepo;
        }


       
        
        [HttpGet("Existencia")]
        public async Task<IActionResult> GetArticulosExistencia()
        {
            var articulosexistencia = await _articuloRepo.GetArticulosExistenciaBodega();
            return Ok(articulosexistencia);
        }

        [HttpGet("Bodega")]
        public async Task<IActionResult> GetArticulosBodega()
        {
            var articulosbodega = await _articuloRepo.GetAllArticulosBodega();
            return Ok(articulosbodega);
        }

        [HttpGet("Bodega/Codigo/{Codigo}")]
        public async Task<IActionResult> GetArticuloBodegaByCodigo(string Codigo)
        {
            var articulosbodega = await _articuloRepo.GetArticuloBodegaByCodigo(Codigo);
            return Ok(articulosbodega);
        }

        [HttpGet("Bodega/Nombre/{Nombre}")]
        public async Task<IActionResult> GetArticuloBodegaByNombre(string Nombre)
        {
            var articulosbodega = await _articuloRepo.GetArticuloBodegaByNombre(Nombre);
            return Ok(articulosbodega);
        }

        [HttpGet("Bodega/Marca/{Marca}")]
        public async Task<IActionResult> GetArticuloBodegaByMarca(string Marca)
        {
            var articulosbodega = await _articuloRepo.GetArticuloBodegaByMarca(Marca);
            return Ok(articulosbodega);
        }
    }
}

