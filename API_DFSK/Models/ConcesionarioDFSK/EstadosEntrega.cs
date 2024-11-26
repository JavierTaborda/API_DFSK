using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class EstadosEntrega
{
    public int IdEstadosEnvio { get; set; }

    public string? Estado { get; set; }

    public int? Tiempo { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<ResumenSolicitud> ResumenSolicituds { get; set; } = new List<ResumenSolicitud>();
}
