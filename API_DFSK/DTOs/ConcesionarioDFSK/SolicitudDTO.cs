using API_DFSK.Models.ConcesionarioDFSK;

namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class SolicitudDTO
    {
        public int IdSolicitud { get; set; }
        public int IdVendedor { get; set; }
        public int IdRepuesto { get; set; }
        public double? Cantidad { get; set; }
        public int IdEstado { get; set; }
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
