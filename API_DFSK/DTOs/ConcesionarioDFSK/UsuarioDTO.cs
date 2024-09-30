namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        public string Username { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public bool Estatus { get; set; }
    }
}
