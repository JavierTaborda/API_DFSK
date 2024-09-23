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
    public class RepuestosController : ControllerBase
    {

        private readonly ISolicitudesRepository _solicitudesRepo;
        public RepuestosController(ISolicitudesRepository solicitudesRepo)
        {
            _solicitudesRepo = solicitudesRepo;
        }

        //API para repuestos y vehiculos
        #region GETS

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRepuestoId(int id)
        {
            var repuesto= await _solicitudesRepo.GetRepuestoById(id);
            return repuesto == null ? BadRequest("Sin Datos") : Ok(repuesto);
        }       
        
        [HttpGet("cod/{codigo}")]
        public async Task<IActionResult> GetRepuestoCodigo(string codigo)
        {
            var repuesto = await _solicitudesRepo.GetRepuestoCodigo(codigo);
            return repuesto == null ? BadRequest("Sin Datos") : Ok(repuesto);
        } 

        [HttpGet("byvehiculo/{id:int}/{codigo}")]
        public async Task<IActionResult> GetRepuestoByVehiculo(int id,string codigo)
        {
            var repuesto = await _solicitudesRepo.GetRepuestosByVehiculo(id,codigo);
            return !repuesto.Any()  ? BadRequest("Sin Datos") : Ok(repuesto);
        }


        #endregion

        //POST

       
        [HttpPost]
        public async Task<IActionResult> PostRepuestos(RepuestoDTO repuesto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _solicitudesRepo.InsertRepuesto(repuesto);
            return result.IdRepuesto>0  ?  Ok(result):BadRequest(result);
        }
        [HttpPost("codigos")]
        public async Task<IActionResult> RecibirCodigos([FromBody] List<CodigosRepuestosDTO> request)
        {
            if (request == null || !request.Any())
            {
                return BadRequest("Lista de códigos vacía o nula");
            }

            var result = await _solicitudesRepo.GetRepuestoList(request);
            return result.Any() ? Ok(result) : BadRequest("Ocurrio un error");
        }


        //PUT
        [HttpPut]
        public async Task<IActionResult> PutRepuesto(RepuestoDTO repuesto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var result = await _solicitudesRepo.UpdateRepuesto(repuesto);
            return result == null ? NotFound():Ok(result);
        }

       


    }
}
