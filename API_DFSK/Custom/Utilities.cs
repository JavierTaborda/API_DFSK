using System.Security.Cryptography;
using System.Security.Claims;
using System.Text;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Collections.Concurrent;

namespace API_DFSK.Custom
{
    public class Utilities
    {
        private readonly IConfiguration _configuration;
        private readonly ConcurrentDictionary<string, RefreshTokenInfo> _refreshTokens = new ConcurrentDictionary<string, RefreshTokenInfo>();

        public Utilities(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public class AuthResponse
        {
            public string? Token { get; set; }
            public string? RefreshToken { get; set; }
        }

        public class RefreshTokenInfo
        {
            public string UserId { get; set; }
            public DateTime Expiration { get; set; }
        }

        public string EncryptSHA256(string text)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public AuthResponse CreateJWT(Vendedore model)
        {
            var userClaims = new[]
            {
                new Claim("user", model.IdVendedor.ToString()),
                new Claim("mail", model.Email!),
                new Claim("name", model.Nombre!),
                new Claim("codigo", model.Codigo!),
                new Claim("role", model.IdRolNavigation!.RolName!)
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var jwtConfig = new JwtSecurityToken(
                claims: userClaims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials
            );
            var token = new JwtSecurityTokenHandler().WriteToken(jwtConfig);
            
            var refreshToken = Guid.NewGuid().ToString();
            var refreshTokenInfo = new RefreshTokenInfo
            {
                UserId = model.IdVendedor.ToString(),
                Expiration = DateTime.UtcNow.AddDays(5) // Set refresh token expiration
            };
            _refreshTokens[refreshToken] = refreshTokenInfo;

            return new AuthResponse
            {
                Token = token,
                RefreshToken = refreshToken
            };
        }

        public bool ValidateRefreshToken(string refreshToken, out string userId)
        {
            userId = null!;
            if (_refreshTokens.TryGetValue(refreshToken, out var refreshTokenInfo))
            {
                if (refreshTokenInfo.Expiration > DateTime.UtcNow)
                {
                    userId = refreshTokenInfo.UserId;
                    return true;
                }
                else
                {
                    _refreshTokens.TryRemove(refreshToken, out _); 
                }
            }
            return false;
        }

        public void RevokeRefreshToken(string refreshToken)
        {
            _refreshTokens.TryRemove(refreshToken, out _);
        }
    }
}