using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RepuestosController(IRepuestosRepository repuestosRepo) : ControllerBase
    {

        private readonly IRepuestosRepository _repuestosRepo = repuestosRepo;
    

        //API para repuestos y vehiculos
        #region GETS

        [HttpGet()]
        public async Task<IActionResult> GetRepuestoId()
        {
            var repuesto = await _repuestosRepo.GetRepuestos();
            return repuesto == null ? BadRequest("Sin Datos") : Ok(repuesto);
        }    
        
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRepuestoId(int id)
        {
            var repuesto= await _repuestosRepo.GetRepuestoById(id);
            return repuesto == null ? BadRequest("Sin Datos") : Ok(repuesto);
        }       
        
        [HttpGet("cod/{codigo}")]
        public async Task<IActionResult> GetRepuestoCodigo(string codigo)
        {
            var repuesto = await _repuestosRepo.GetRepuestoCodigo(codigo);
            return repuesto == null ? BadRequest("Sin Datos") : Ok(repuesto);
        } 

        [HttpGet("byvehiculo/{id:int}/{codigo}")]
        public async Task<IActionResult> GetRepuestoByVehiculo(int id,string codigo)
        {
            var repuesto = await _repuestosRepo.GetRepuestosByVehiculo(id,codigo);
            return !repuesto.Any()  ? BadRequest("Sin Datos") : Ok(repuesto);
        }


        #endregion

        //POST

       
        [HttpPost]
        public async Task<IActionResult> PostRepuestos(RepuestoDTO repuesto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _repuestosRepo.InsertRepuesto(repuesto);
            return result.IdRepuesto>0  ?  Ok(result):BadRequest(result);
        }
        [HttpPost("codigos")]
        public async Task<IActionResult> RecibirCodigos([FromBody] List<CodigosRepuestosDTO> request)
        {
            if (request == null || !request.Any())
            {
                return BadRequest("Lista de códigos vacía o nula");
            }

            var result = await _repuestosRepo.GetRepuestoList(request);
            return result.Any() ? Ok(result) : BadRequest("Ocurrio un error");
        }


        //PUT
        [HttpPut]
        public async Task<IActionResult> PutRepuesto(RepuestoDTO repuesto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var result = await _repuestosRepo.UpdateRepuesto(repuesto);
            return result == null ? NotFound():Ok(result);
        }

       


    }
}
