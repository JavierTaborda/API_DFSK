using API_DFSK.DTOs.DFSK;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Models.DFSK;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.CrearTXT
{
    [Route("api/[controller]")]
    [EnableCors("AllowAnyOrigin")]
    [ApiController]
    public class TxtController : ControllerBase
    {


        private readonly ICrearTXTRepository _txtRepo;
        public TxtController(ICrearTXTRepository txtRepo)
        {
            _txtRepo = txtRepo;
        }
        
        [HttpPost]
        public async Task<IActionResult> PostResumentxt(ResumentxtDTO txt)
        {
            var resumentxt = await _txtRepo.CreateTXT(txt);
            return Ok(resumentxt);
        }

        [HttpGet("{Id:int}")]
        public async Task<IActionResult> GetResumentxt(int Id)
        {
            var resumentxt = await _txtRepo.GetTXT(Id);
            return Ok(resumentxt);
        }

    }
}
