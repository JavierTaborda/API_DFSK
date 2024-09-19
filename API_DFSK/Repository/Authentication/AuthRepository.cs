using API_DFSK.Context;
using API_DFSK.Custom;
using API_DFSK.DTOs;
using API_DFSK.Interfaces.Authentication;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static API_DFSK.Custom.Utilities;

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
        public async Task<AuthResponse> Login(LoginDTO login)
        {
            var usuarioEncontrado = await _context.Vendedores
                .Include(r=>r.IdRolNavigation)
                .Where(l => ((l.Codigo == login.Username) || (l.Email==login.Username)) &&
                l.Clave == _utilities.EncryptSHA256(login.Password!)
                ).FirstOrDefaultAsync();

            if (usuarioEncontrado == null)
                return null!;
            else
                return _utilities.CreateJWT(usuarioEncontrado);

        }
        
        public async Task<string> RefreshToken(RefreshTokenDTO refreshtoken)
        {
            
            if (_utilities.ValidateRefreshToken(refreshtoken.refreshToken!, out var userId))
            {
                var user = await  _context.Vendedores.Include(r => r.IdRolNavigation).FirstOrDefaultAsync(u => u.IdVendedor == int.Parse(userId));
                if (user != null)
                {
                    return _utilities.CreateJWT(user).Token!;
                }
            }
            return null!;
        }

        public async Task<bool> Registro(UserVendedorDTO user)
        {
            var vendedor = _context.Vendedores
                .Include(l => l.IdRolNavigation)
                .Where(l => l.Codigo == user.Codigo)
                .FirstOrDefaultAsync();

            if (vendedor.Result == null)
            {
                user.Clave = _utilities.EncryptSHA256(user.Clave!);//Encriptarclave

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
