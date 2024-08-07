using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Repository.ConcesionarioDFSK;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudesController : ControllerBase
    {
        //APIS DE SOLICITUDES Y ESTADOS DE SOLICITUDES
       
        private readonly ISolicitudesRepository _solicitudesRepo;
        public SolicitudesController(ISolicitudesRepository solicitudesRepo)
        {
            _solicitudesRepo = solicitudesRepo;
        }

        #region GETS

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

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetSolicitud(int Id)
        {
            var solictud = await _solicitudesRepo.GetSolicitudById(Id);
            return solictud == null?  BadRequest("Sin Solicitudes"):  Ok(solictud); 
        }

        [HttpGet("estados/{id}")]
        public async Task<IActionResult> GetEstadoById(int id)
        {
            var estado = await _solicitudesRepo.GetEstadoById(id);
            if (estado == null)
                return NotFound();

            return Ok(estado);
        } 

        [HttpGet("estados/")]
        public async Task<IActionResult> GetEstados()
        {
            var estados = await _solicitudesRepo.GetEstados();
            if (estados == null)
                return NotFound();

            return Ok(estados);
        }
        #endregion

        //POST

        [HttpPost]
        public async Task<IActionResult> PostSolicitud(List<SolicitudDTO> solicitud)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

             var result=await _solicitudesRepo.InsertSolicitud(solicitud);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Fallo el registro.");
            }
        } 
        [HttpPost("Repuesto")]
        public async Task<IActionResult> PostSolicitudRepuestoNuevo(SolicitudRepuestoDTO solicitud)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

             var result=await _solicitudesRepo.InsertSolicitudRepuesto(solicitud);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Fallo el registro.");
            }
        }


    }
}
