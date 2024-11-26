namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class QrCodeDTO
    {

        public int IdResumenSolicitud { get; set; }
        public int IdEstadosEnvio { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public bool Estatus { get; set; }

        public DateTime? FechaCierre { get; set; }

        public string? Observacion { get; set; }

        public string? Usuario { get; set; }
        public string? CodigoUnico { get; set; }




        public virtual ICollection<SolicitudDTO> Solicitudes { get; set; } = new List<SolicitudDTO>();
    }
}
