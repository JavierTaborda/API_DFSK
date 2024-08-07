using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepuestosController : ControllerBase
    {

        private readonly ISolicitudesRepository _solicitudesRepo;
        public RepuestosController(ISolicitudesRepository solicitudesRepo)
        {
            _solicitudesRepo = solicitudesRepo;
        }

        //API para repuestos y vehiculos
        #region GETS

        [HttpGet("/{id:int}")]
        public async Task<IActionResult> GetRepuestoId(int id)
        {
            var repuesto= await _solicitudesRepo.GetRepuestoById(id);
            return repuesto == null ? BadRequest("Sin Datos") : Ok(repuesto);
        }       
        
        [HttpGet("/cod/{codigo}")]
        public async Task<IActionResult> GetRepuestoCodigo(string codigo)
        {
            var repuesto = await _solicitudesRepo.GetRepuestoCodigo(codigo);
            return repuesto == null ? BadRequest("Sin Datos") : Ok(codigo);
        } 

        [HttpGet("/byvehiculo/{id:int}/{codigo}")]
        public async Task<IActionResult> GetRepuestoByVehiculo(int id,string codigo)
        {
            var repuesto = await _solicitudesRepo.GetRepuestosByVehiculo(id,codigo);
            return repuesto == null ? BadRequest("Sin Datos") : Ok(repuesto);
        }

        //VEHICULOS

        [HttpGet("/Vehiculos")]
        public async Task<IActionResult> GetVehiculos()
        {
            var vehiculos = await _solicitudesRepo.GetVehiculos();
            return vehiculos == null ? BadRequest("Sin Datos") : Ok(vehiculos);
        }

        [HttpGet("/Vehiculos/{id:int}/{codigo}")]
        public async Task<IActionResult> GetVehiculo(int id, string codigo)
        {
            var vehiculo = await _solicitudesRepo.GetVehiculoByIdCodigo(id, codigo);
            return vehiculo == null ? BadRequest("Sin Datos") : Ok(vehiculo);
        }
        #endregion

        //POST
        //[HttpPost]
        //public async Task<IActionResult> PostSolicitud(List<RepuestoDTO> repuesto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var result = await _solicitudesRepo.InsertSolicitud(solicitud);
        //    if (result)
        //    {
        //        return Ok();
        //    }
        //    else
        //    {
        //        return BadRequest("Fallo el registro.");
        //    }
        //}

    }
}
