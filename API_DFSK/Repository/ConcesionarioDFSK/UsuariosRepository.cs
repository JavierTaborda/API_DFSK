using API_DFSK.Context;
using API_DFSK.Custom;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class UsuariosRepository(ConcesionarioDfskContext context, IMapper mapper, Utilities utilities) : IUsuariosRepository
    {
        private readonly ConcesionarioDfskContext _context = context;
        private readonly IMapper _mapper = mapper;
        private readonly Utilities _utilities = utilities;

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
                .Include(r => r.IdRolNavigation)
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<UsuarioDTO>>(users) ?? [];
        }
        public async Task<List<UsuarioDTO>> GetUsuariosEdit()
        {
            var users = await _context.Usuarios.Where(e => !e.IdRolNavigation.RolName!.Contains("admin") ) 
                .Include(r => r.IdRolNavigation)
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<UsuarioDTO>>(users) ?? [];
        }
        public async Task<UsuarioDTO> UpdateUsuario(UpdateUsuarioDTO request)
        {
            var entity = await _context.Usuarios.FindAsync(request.User.IdUsuario);
            if (entity == null)
            {
                return null!;
            }

            if (!string.IsNullOrEmpty(request.NewPass))
            {
                entity.Clave = _utilities.EncryptSHA256(request.NewPass);
            }

            _mapper.Map(request.User, entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<UsuarioDTO>(entity);
            return result;
        }



    }
}
