using System.ComponentModel.DataAnnotations;

namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class SolicitudRepuestoDTO
    {
        public int IdSolicitud { get; set; }

        [Required(ErrorMessage = "Campo  Vendedor Requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor de IdVendedor debe ser mayor que 0.")]
        public int IdVendedor { get; set; }
        public int IdRepuesto { get; set; }
        public double? Cantidad { get; set; }

        [Required(ErrorMessage = "Campo Estado  Requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor de IdEstado debe ser mayor que 0.")]
        public int IdEstado { get; set; }

        [Required(ErrorMessage = "Campo Fecha de Solicitud Requerido.")]
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaCompra { get; set; }
        public DateTime? FechaLlegada { get; set; }
        public string? Observacion { get; set; }

        //Repuesto

        [Required(ErrorMessage = "Campo Vehiculo  Requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor de IdVehiculo debe ser mayor que 0.")]
        public int? IdVehiculo { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "El nombre no debe ser mayor a 30 characters")]
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Precio { get; set; }
        public bool Estatus { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
    }
}
