using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using API_DFSK.Repository.ConcesionarioDFSK;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    
    [Route("api/[controller]")]
    [EnableCors("AllowAnyOrigin")]
    [Authorize]
    [ApiController]
    public class SolicitudesController : ControllerBase
    {
        //APIS DE SOLICITUDES 

        private readonly ISolicitudesRepository _solicitudesRepo;
        public SolicitudesController(ISolicitudesRepository solicitudesRepo)
        {
            _solicitudesRepo = solicitudesRepo;
        }

        #region GETS

        [HttpGet("{f1}/{f2}/{estado}/{idvendedor:int}")]
        public async Task<IActionResult> GetResumen(DateTime f1, DateTime f2, string estado, int iduser)
        {
            if (f1 > f2)
            {
                return BadRequest("La fecha inicial no puede ser mayor que la fecha final.");
            }
            var resumen = await _solicitudesRepo.GetResumenSolicitudes(f1, f2, estado, iduser);
            return Ok(resumen);
        }

        [HttpGet("List/{f1}/{f2}/{idestado}/{idvendedor}")]
        public async Task<IActionResult> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int iduser)
        {
            if (f1 > f2)
            {
                return BadRequest("La fecha inicial no puede ser mayor que la fecha final.");
            }
            var listasolicitudes = await _solicitudesRepo.GetSolicitudes(f1, f2, idestado, iduser);
            return Ok(listasolicitudes);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetSolicitud(int Id)
        {
            var solictud = await _solicitudesRepo.GetSolicitudById(Id);
            return solictud == null ? BadRequest("Sin Solicitudes") : Ok(solictud);
        }  
        
        [HttpGet("DatosIniciales")]
        public async Task<IActionResult> GetDatosIniciales()
        {
            var result = await _solicitudesRepo.GetIdsSolicitudIncial();
            return result == null ? BadRequest("Sin Datos en Estados y Responsable") : Ok(result);
        }


        #endregion

        //POST
        #region POST

        [HttpPost]
        public async Task<IActionResult> PostSolicitud(ResumenSolicitudDTO solicitud)
        {
            if (!ModelState.IsValid) //Chequea los Required de los DTO
                return BadRequest(ModelState);

            var result = await _solicitudesRepo.InsertResumenSolicitud(solicitud);

            return !result ? BadRequest("Fallo el registro") : Ok();

        }

        //Inserta Solicitud + Un nuevo Repuesto
        [HttpPost("Repuesto")]
        public async Task<IActionResult> PostSolicitudRepuestoNuevo(SolicitudRepuestoDTO solicitud)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _solicitudesRepo.InsertSolicitudRepuesto(solicitud);
            return result ? Ok() : BadRequest("Error en registro.");

        }
        #endregion

        //PUTS

        //Edita Solicitud + Un nuevo Repuesto
        [HttpPut("Repuesto")]
        public async Task<IActionResult> PutSolicitudRepuesto([FromBody] SolicitudRepuestoDTO solicitud)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _solicitudesRepo.UpdateSolicitudRepuesto(solicitud);

            return result == null ? NotFound() : Ok(result);

        }
    }
}
