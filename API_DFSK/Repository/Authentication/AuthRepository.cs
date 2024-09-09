using API_DFSK.Context;
using API_DFSK.Custom;
using API_DFSK.DTOs;
using API_DFSK.Interfaces.Authentication;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Repository.Authentication
{
    public class AuthRepository : IAuth
    {
        private readonly ConcesionarioDfskContext _context;
        private readonly IMapper _mapper;
        private readonly Utilities _utilities;

        public AuthRepository(ConcesionarioDfskContext context, IMapper mapper, Utilities utilities)
        {
            _context = context;
            _mapper = mapper;
            _utilities = utilities;
        }
        public async Task<string> Login(LoginDTO login)
        {
            var usuarioEncontrado = await _context.Vendedores
                .Include(r=>r.IdRolNavigation)
                .Where(l => ((l.Codigo == login.User) || (l.Email==login.User)) &&
                l.Clave == _utilities.encryptSHA256(login.Clave!)
                ).FirstOrDefaultAsync();

            if (usuarioEncontrado == null)
                return "";
            else
                return _utilities.createJWT(usuarioEncontrado);

        }

        public async Task<bool> Registro(UserVendedorDTO user)
        {
            var vendedor = _context.Vendedores
                .Include(l => l.IdRolNavigation)
                .Where(l => l.Codigo == user.Codigo)
                .FirstOrDefaultAsync();

            if (vendedor.Result == null)
            {
                user.Clave = _utilities.encryptSHA256(user.Clave!);//Encriptarclave

                var insert = _mapper.Map<Vendedore>(user);
                await _context.Vendedores.AddAsync(insert);
                await _context.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
