using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;

namespace API_DFSK.Interfaces.ConcesionarioDFSK
{
    public interface IUsuariosRepository
    {
        Task<List<UsuarioDTO>> GetUsuarios();
        Task<UsuarioDTO> GetusuarioById(int Id);
        Task<List<RolDTO>> GetRoles();
        Task<UsuarioDTO> UpdateUsuario(UsuarioDTO Usuario);

    }
}
