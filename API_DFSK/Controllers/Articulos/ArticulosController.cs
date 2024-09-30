using API_DFSK.Interfaces.DFSK;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace API_DFSK.Controllers.Articulos
{
    [Route("api/[controller]")]
    [EnableCors("AllowAnyOrigin")]
    [Authorize]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly IArticulosRepository _articuloRepo;
        public ArticulosController( IArticulosRepository articulosRepo)
        {
            _articuloRepo = articulosRepo;
        }

        [AllowAnonymous]
        [HttpGet("Online")]
        public  IActionResult Online()
        {
            return   Ok(true);
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
            var result = await _articuloRepo.GetArticuloBodegaByCodigo(Codigo);
            return result == null ? NotFound("Sin Vehiculos.") : Ok(result);
        }
        
        [HttpGet("Bodega/Vehiculos/{Codigo}")]
        public async Task<IActionResult> GetVehiculosBodegaByCodigo(string Codigo)
        {
            var articulosbodega = await _articuloRepo.GetVehiculosBodegaByCodigo(Codigo);
            return Ok(articulosbodega);
        }

        [HttpGet("Bodega/Nombre/{Nombre}")]
        public async Task<IActionResult> GetArticuloBodegaByNombre(string Nombre)
        {
            var articulosbodega = await _articuloRepo.GetArticuloBodegaByNombre(Nombre);
            return Ok(articulosbodega);
        }

        [HttpGet("Bodega/Marca/{Marca}/{Grupo}/{Nombre}")]
        public async Task<IActionResult> GetArticuloBodegaByMarca(string Marca, string Grupo, string Nombre)
        {
            var marcaDecodificada = WebUtility.UrlDecode(Marca);
            var grupoDecodificada = WebUtility.UrlDecode(Grupo);
            var nombreDecodificada = WebUtility.UrlDecode(Nombre);

            var articulosbodega = await _articuloRepo.GetArticuloBodegaByMarcayGrupo(marcaDecodificada, grupoDecodificada, nombreDecodificada);
            return Ok(articulosbodega);
        }

        [HttpGet("CodigosMarca")]
        public async Task<IActionResult> GetCodigosByMarca()
        {
            var codigosmarca = await _articuloRepo.GetCodigosByMarca();
            return Ok(codigosmarca);
        }

        [HttpGet("CodigosGrupo")]
        public async Task<IActionResult> GetCodigosByGrupo()
        {
            var coodigosgrupo = await _articuloRepo.GetCodigosByGrupo();
            return Ok(coodigosgrupo);
        }
    }
}

