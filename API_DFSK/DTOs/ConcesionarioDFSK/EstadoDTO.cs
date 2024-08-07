using API_DFSK.Models.ConcesionarioDFSK;
using System.ComponentModel.DataAnnotations;

namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class EstadoDTO
    {
      
        [Range(0, int.MaxValue, ErrorMessage = "El valor de {0} debe ser mayor que 0.")]
        public int IdEstado { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Campo  {0} Requerido.")]
        public bool Estatus { get; set; }
      
    }
}
