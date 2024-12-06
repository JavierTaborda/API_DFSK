using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_DFSK.Controllers.ConcesionarioDFSK
{
    [Route("api/[controller]")]
    [Authorize(Roles = "admin")]
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

        [HttpGet("Edit")]       
         public async Task<IActionResult> GetUsersEdit()
        {
            var users = await _userRepo.GetUsuariosEdit();
            return users.Count == 0 ? BadRequest("Sin Datos") : Ok(users);
        }

        [HttpGet("{id:int})")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userRepo.GetusuarioById(id);
            return user == null ? BadRequest("Sin Datos") : Ok(user);
        }

       
        [HttpGet("Roles")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _userRepo.GetRoles();
            return roles == null ? BadRequest("Sin Datos") : Ok(roles);
        }


        //PUTS
        
        [HttpPut]
        public async Task<IActionResult> PutUsers(UpdateUsuarioDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userRepo.UpdateUsuario(request);
            return result == null ? NotFound() : Ok(result);
        }
          
    }
}
