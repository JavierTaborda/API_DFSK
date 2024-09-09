using API_DFSK.DTOs;

namespace API_DFSK.Interfaces.Authentication
{
    public interface IAuth
    {
        Task<bool> Registro(UserVendedorDTO user);
        Task<string> Login(LoginDTO login);
    }
}
