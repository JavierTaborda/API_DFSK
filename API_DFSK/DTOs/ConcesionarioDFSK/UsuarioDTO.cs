using System.ComponentModel.DataAnnotations;

namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Nombre { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string Telefono { get; set; } = null!;
        public int IdRol { get; set; }

  

        public bool Estatus { get; set; }
    }
}
