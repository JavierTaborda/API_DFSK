using API_DFSK.DTOs;
using static API_DFSK.Custom.Utilities;

namespace API_DFSK.Interfaces.Authentication
{
    public interface IAuth
    {
        Task<bool> Registro(UserVendedorDTO user);
        Task<AuthResponse> Login(LoginDTO login);
        Task<string> RefreshToken(RefreshTokenDTO refreshToken);
    }
}
