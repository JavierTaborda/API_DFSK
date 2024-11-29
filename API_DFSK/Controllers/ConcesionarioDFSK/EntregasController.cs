using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntregasController(IEntregasRepository entregaRepo) : ControllerBase
    {
        private readonly IEntregasRepository _entregaRepo = entregaRepo;

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstadoEntregaById(int id)
        {
            var estados = await _entregaRepo.getEstadoEntregaId(id);
            return estados == null ? NotFound() : Ok(estados);
        }

        [HttpGet]
        public async Task<IActionResult> GetEstados()
        {
            var estados = await _entregaRepo.getEstadosEntrega();
            return estados.Count == 0 ? NotFound() : Ok(estados);
        }
        //POST
        [HttpPost]
        public async Task<IActionResult> PostEstados(EstadoEntregaDTO estados)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var result = await _entregaRepo.InsertEstadoEntrega(estados);
            return result == "Exito" ? Ok() : BadRequest(result);

        }


        //PUTS
        [HttpPut]
        public async Task<IActionResult> PutEstados(EstadoEntregaDTO estado)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _entregaRepo.UpdateEstadoEntrega(estado);
            return result == null ? NotFound() : Ok(result);
        }
    }
}
