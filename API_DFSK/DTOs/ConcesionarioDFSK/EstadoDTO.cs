using API_DFSK.Models.ConcesionarioDFSK;

namespace API_DFSK.DTOs.ConcesionarioDFSK
{
    public class EstadoDTO
    {
        public int IdEstado { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public bool Estatus { get; set; }

        public virtual ICollection<Solicitude> Solicitudes { get; set; } = new List<Solicitude>();
    }
}
