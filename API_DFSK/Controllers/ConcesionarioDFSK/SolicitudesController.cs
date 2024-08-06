using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Interfaces.DFSK;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudesController : ControllerBase
    {
       
        private readonly ISolicitudesRepository _solicitudesRepo;
        public SolicitudesController(ISolicitudesRepository solicitudesRepo)
        {
            _solicitudesRepo = solicitudesRepo;
        }


        [HttpGet("{f1}/{f2}/{idestado}/{idrepuesto}/{idvendedor}/{tipofecha}")]
        public async Task<IActionResult> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int idrepuesto, int idvendedor, int tipofecha)
        {
            if (f1 > f2)
            {
                return BadRequest("La fecha inicial no puede ser mayor que la fecha final.");
            }
            var listasolicitudes = await _solicitudesRepo.GetSolicitudes(f1,f2,idestado,idrepuesto,idvendedor,tipofecha);
            return Ok(listasolicitudes);
        }
    }
}
