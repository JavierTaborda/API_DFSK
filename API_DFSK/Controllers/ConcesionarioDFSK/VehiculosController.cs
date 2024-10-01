using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VehiculosController(IVehiculoRepository vehiculoRepo) : ControllerBase
    {
            
        private readonly IVehiculoRepository _vehiculoRepo=vehiculoRepo;       
   
  

        [HttpGet]
        public async Task<IActionResult> GetVehiculos()
        {
            var vehiculos = await _vehiculoRepo.GetVehiculos();
            return !vehiculos.Any() ? BadRequest("Sin Datos") : Ok(vehiculos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetVehiculoId(int id)
        {
            var vehiculo = await _vehiculoRepo.GetVehiculoById(id);
            return vehiculo == null ? BadRequest("Sin Datos") : Ok(vehiculo);
        }
         [HttpGet("Codigo/{codigo}")]
        public async Task<IActionResult> GetVehiculoCodigo( string codigo)
        {
            var vehiculo = await _vehiculoRepo.GetVehiculoByCodigo(codigo);
            return vehiculo == null ? BadRequest("Sin Datos") : Ok(vehiculo);
        }

        //POST
        [Authorize(Roles = "admin, subadmin")]
        [HttpPost]
        public async Task<IActionResult> PostVehiculos(List<VehiculoDTO> vehiculos)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _vehiculoRepo.InsertVehiculo(vehiculos);
            return result ? Ok(): BadRequest("Fallo el registro.");
            
        }




        //PUTS
        [Authorize(Roles = "admin, subadmin")]
        [HttpPut]
        public async Task<IActionResult> PutVehiculo(VehiculoDTO vehiculo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _vehiculoRepo.UpdateVehiculo(vehiculo);
            return result == null ? NotFound() : Ok(result);
            
        }
        [Authorize(Roles = "admin, subadmin")]
        [HttpPut("AddUpdate")]
        public async Task<IActionResult> PutAddVehiculo(VehiculoDTO vehiculo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _vehiculoRepo.AddUpdateVehiculo(vehiculo);
            return result == null ? NotFound() : Ok(result);
            
        }
    }
}
