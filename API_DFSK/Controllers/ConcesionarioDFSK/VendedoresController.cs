using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class VendedoresController : ControllerBase
    {
        private readonly ISolicitudesRepository _solicitudesRepo;
        public VendedoresController(ISolicitudesRepository solicitudesRepo)
        {
            _solicitudesRepo = solicitudesRepo;
        }

        //GETS
        
        [HttpGet]       
         public async Task<IActionResult> GetVendedores()
        {
            var vendedores = await _solicitudesRepo.GetVendedores();
            return !vendedores.Any() ? BadRequest("Sin Datos") : Ok(vendedores);
        }

        [HttpGet("{id:int})")]
        public async Task<IActionResult> GetVendedor(int id)
        {
            var vendedor = await _solicitudesRepo.GetVendedorById(id);
            return vendedor == null ? BadRequest("Sin Datos") : Ok(vendedor);
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> PostVendedores(List<VendedorDTO> vendedors)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _solicitudesRepo.InsertVendedor(vendedors);
            return result ? Ok(result): BadRequest("Fallo el registro.");

        }

        //PUTS
        [HttpPut]
        public async Task<IActionResult> PutVendedores(VendedorDTO vendedor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _solicitudesRepo.UpdateVendedor(vendedor);
            return result == null ? NotFound() : Ok(result);
           
        }


    }
}
