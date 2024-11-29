using System.ComponentModel.DataAnnotations;

namespace API_DFSK.DTOs
{
    public class UserDTO
    {
        [Required(ErrorMessage = "Campo  {0} Requerido.")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Campo  {0} Requerido.")]
        public string? Nombre { get; set; }

        public string? Email { get; set; }
        [Required(ErrorMessage = "Campo  {0} Requerido.")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Campo  {0} Requerido.")]
        public string? Clave { get; set; }
        public bool? Estatus { get; set; }

        public int IdRol {  get; set; }

    }
}
