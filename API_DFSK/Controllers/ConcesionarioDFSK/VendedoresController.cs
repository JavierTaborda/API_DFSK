using API_DFSK.Interfaces.ConcesionarioDFSK;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedoresController : ControllerBase
    {
        private readonly ISolicitudesRepository _solicitudesRepo;
        public VendedoresController(ISolicitudesRepository solicitudesRepo)
        {
            _solicitudesRepo = solicitudesRepo;
        }

        [HttpGet]       
         public async Task<IActionResult> GetVendedores()
        {
            var vendedores = await _solicitudesRepo.GetVendedores();
            return vendedores == null ? BadRequest("Sin Datos") : Ok(vendedores);
        }

        [HttpGet("/{id:int})")]
        public async Task<IActionResult> GetVendedor(int id)
        {
            var vendedor = await _solicitudesRepo.GetVendedorById(id);
            return vendedor == null ? BadRequest("Sin Datos") : Ok(vendedor);
        }


       
    }
}
