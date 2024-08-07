using API_DFSK.Models.ConcesionarioDFSK;
using System.ComponentModel.DataAnnotations;

namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class SolicitudDTO
    {
        public int IdSolicitud { get; set; }
        
        [Required(ErrorMessage = "Campo  Requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor de IdVendedor debe ser mayor que 0.")]
        public int IdVendedor { get; set; }

        [Required(ErrorMessage = "Campo  Requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor de IdRepuesto debe ser mayor que 0.")]
        public int IdRepuesto { get; set; }
        public double? Cantidad { get; set; }

        [Required(ErrorMessage = "Campo  Requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor de IdEstado debe ser mayor que 0.")]
        public int IdEstado { get; set; }

        [Required(ErrorMessage = "Campo  Requerido.")]
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaCompra { get; set; }
        public DateTime? FechaLlegada { get; set; }    
        public string? Observacion { get; set; }
        public string? Estado { get; set; }
        public string? Repuesto { get; set; }
        public string? Vendedor { get; set; }
        public string? Vehiculo { get; set; }

    }
}
