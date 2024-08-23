using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
            
        private readonly ISolicitudesRepository _solicitudesRepo;       
        public VehiculosController(ISolicitudesRepository solicitudesRepo)
            {
                _solicitudesRepo = solicitudesRepo;
            }
  

        [HttpGet]
        public async Task<IActionResult> GetVehiculos()
        {
            var vehiculos = await _solicitudesRepo.GetVehiculos();
            return !vehiculos.Any() ? BadRequest("Sin Datos") : Ok(vehiculos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetVehiculoId(int id)
        {
            var vehiculo = await _solicitudesRepo.GetVehiculoById(id);
            return vehiculo == null ? BadRequest("Sin Datos") : Ok(vehiculo);
        }
         [HttpGet("Codigo/{codigo}")]
        public async Task<IActionResult> GetVehiculoCodigo( string codigo)
        {
            var vehiculo = await _solicitudesRepo.GetVehiculoByCodigo(codigo);
            return vehiculo == null ? BadRequest("Sin Datos") : Ok(vehiculo);
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> PostVehiculos(List<VehiculoDTO> vehiculos)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _solicitudesRepo.InsertVehiculo(vehiculos);
            return result ? Ok(): BadRequest("Fallo el registro.");
            
        }

        //PUTS
        [HttpPut]
        public async Task<IActionResult> PutVehiculo(VehiculoDTO vehiculo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _solicitudesRepo.UpdateVehiculo(vehiculo);
            return result == null ? NotFound() : Ok(result);
            
        }
        [HttpPut("AddUpdate")]
        public async Task<IActionResult> PutAddVehiculo(VehiculoDTO vehiculo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _solicitudesRepo.AddUpdateVehiculo(vehiculo);
            return result == null ? NotFound() : Ok(result);
            
        }
    }
}
