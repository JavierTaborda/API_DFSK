using API_DFSK.Models.ConcesionarioDFSK;

namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class EstadoEntregaDTO
    {
        public int IdEstadosEnvio { get; set; }

        public string? Estado { get; set; }

        public int? Tiempo { get; set; }

        public bool? Activo { get; set; }

    }
}
