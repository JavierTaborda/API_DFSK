﻿using API_DFSK.DTOs;
using API_DFSK.Interfaces.Authentication;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Repository.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public async Task<IActionResult> Registrar(UserVendedorDTO user)
        {
            var registro = await _authRepo.Registro(user);
            return Ok(registro);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            var token = await _authRepo.Login(login);
            return !String.IsNullOrEmpty(token) ? Ok(token) : BadRequest("Datos Incorrectos");
        }

    }
}
