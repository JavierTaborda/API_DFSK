﻿using System.Security.Cryptography;
using System.Security.Claims;
using System.Text;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace API_DFSK.Custom
{
    public class Utilities
    {
        private readonly IConfiguration _configuration;
        public Utilities(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string EncryptSHA256(string text)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //Crear Array de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                //Array a un string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public string CreateJWT(Vendedore model)
        {
            var userClaims = new[]
            {
                new Claim ("user", model.IdVendedor.ToString()),
                new Claim("mail", model.Email!),
                new Claim("name", model.Nombre!),
                new Claim("codigo", model.Codigo!),
                new Claim("role", model.IdRolNavigation!.RolName!)
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:key"]!));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256Signature);

            var jwtConfig = new JwtSecurityToken(
                claims: userClaims,
                expires:DateTime.UtcNow.AddMinutes(30),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(jwtConfig);
        }

    }
}
