using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EstadoController(IEstadoRepository estadoRepo) : ControllerBase
    {
        private readonly IEstadoRepository _estadoRepo=estadoRepo;
      
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstadoById(int id)
        {
            var estado = await _estadoRepo.GetEstadoById(id);
            return estado == null ? NotFound() : Ok(estado);     
        }

        [HttpGet]
        public async Task<IActionResult> GetEstados()
        {
            var estados = await _estadoRepo.GetEstados();    
            return estados.Count==0 ? NotFound() : Ok(estados);
        }
        //POST
        [HttpPost]
        public async Task<IActionResult> PostEstados(List<EstadoDTO> estados)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _estadoRepo.InsertEstado(estados);
            return result  ? Ok(): BadRequest("Fallo el registro.");

        }


        //PUTS
        [HttpPut]
        public async Task<IActionResult> PutEstados(EstadoDTO estado)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _estadoRepo.UpdateEstado(estado);
            return result == null ? NotFound() : Ok(result);
        }
    }
}