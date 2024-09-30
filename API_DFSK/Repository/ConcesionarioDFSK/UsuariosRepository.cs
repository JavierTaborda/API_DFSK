using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class UsuariosRepository(ConcesionarioDfskContext context, IMapper mapper) : IUsuariosRepository
    {
        private readonly ConcesionarioDfskContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<List<RolDTO>> GetRoles()
        {
            var roles = await _context.Rols.Where(e => e.Estado == true && e.RolName != "admin")
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<RolDTO>>(roles) ?? [];
        }

        public async Task<UsuarioDTO> GetusuarioById(int Id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(id => id.IdUsuario == (Id));
            return _mapper.Map<UsuarioDTO>(usuario);
        }

        public async Task<List<UsuarioDTO>> GetUsuarios()
        {
            var users = await _context.Usuarios.Where(e => e.Estatus == true)
                         .AsNoTracking()
                         .ToListAsync();
            return _mapper.Map<List<UsuarioDTO>>(users) ??  [];
        }

        public async Task<UsuarioDTO> UpdateUsuario(UsuarioDTO Usuario)
        {
            var entity = await _context.Usuarios.FindAsync(Usuario.IdUsuario);
            if (entity == null)
            {
                return null!;
            }

            _mapper.Map(Usuario, entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<UsuarioDTO>(entity);
            return result;
        }
    }
}
