using API_DFSK.Custom;
using API_DFSK.DTOs;
using API_DFSK.Interfaces.Authentication;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Repository.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Controllers.Auth
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth _authRepo;

        public AuthController(IAuth authRepo)
        {
            _authRepo = authRepo;
        }
        [Authorize(Roles = "admin")]
        [HttpPost("Registrar")]
        public async Task<IActionResult> Registrar(UserDTO user)
        {
            var registro = await _authRepo.Registro(user);
            return Ok(registro);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            var token = await _authRepo.Login(login);

            if (token == null)
            {
                return BadRequest("Usuario no encontrado");
            }
            else if (token.Token == "Desactivado")
            {
                return BadRequest("Este usuario se encuentra desactivado, comuníquese con el administrador.");
            }
            else if (token.Token == "Password")
            {
                return BadRequest("Contrseña incorrecta");
            }
            else
            {
                return Ok(token);
            }
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> RefreshToken(RefreshTokenDTO refreshToken)
        {
            var token = await _authRepo.RefreshToken(refreshToken);
            return token != null ? Ok(token) : BadRequest("refresh Token Invalido");
        }

    }
}
