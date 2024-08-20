using API_DFSK.Models.ConcesionarioDFSK;

namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class ResumenSolicitudDTO
    {
        public int IdResumenSolicitud { get; set; }

        public DateTime? FechaCreacion{ get; set; }

        public bool Estatus { get; set; }

        public DateTime? FechaCierre { get; set; }

        public string? Observacion { get; set; }

        public int IdVendedor { get; set; }

        public virtual ICollection<SolicitudDTO> Solicitudes { get; set; } = new List<SolicitudDTO>();
    }
}
