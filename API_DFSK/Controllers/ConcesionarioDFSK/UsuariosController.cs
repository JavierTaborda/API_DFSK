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
    public class UsuariosController(IUsuariosRepository userRepo ) : ControllerBase
    {
        private readonly IUsuariosRepository _userRepo=userRepo;
   
        //GETS
        
        [HttpGet]       
         public async Task<IActionResult> GetUsers()
        {
            var users = await _userRepo.GetUsuarios();
            return users.Count == 0 ? BadRequest("Sin Datos") : Ok(users);
        }

        [HttpGet("{id:int})")]
        public async Task<IActionResult> GetVendedor(int id)
        {
            var user = await _userRepo.GetusuarioById(id);
            return user == null ? BadRequest("Sin Datos") : Ok(user);
        }

        [Authorize(Roles = "admin")]
        [HttpGet("Roles")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _userRepo.GetRoles();
            return roles == null ? BadRequest("Sin Datos") : Ok(roles);
        }


        //PUTS

        [HttpPut]
        public async Task<IActionResult> PutVendedores(UsuarioDTO user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _userRepo.UpdateUsuario(user);
            return result == null ? NotFound() : Ok(result);
           
        }


    }
}
