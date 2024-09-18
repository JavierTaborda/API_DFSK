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
           _authRepo=authRepo;
    }
        [Authorize (Roles ="Admin")]
        [HttpPost("Registrar")]
        public async Task<IActionResult> Registrar(UserVendedorDTO user)
        {
            var registro = await _authRepo.Registro(user);
            return Ok(registro);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            var token = await _authRepo.Login(login);
            return token != null ? Ok(token) : BadRequest("Datos Incorrectos");
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> RefreshToken( RefreshTokenDTO refreshToken)
        {
            var token = await _authRepo.RefreshToken(refreshToken);
            return token != null ? Ok(token) : BadRequest("refresh Token Invalido");
        }

    }
}
