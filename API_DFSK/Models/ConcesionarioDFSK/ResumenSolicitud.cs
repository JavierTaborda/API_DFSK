using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class ResumenSolicitud
{
    public int IdResumenSolicitud { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public bool Estatus { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? Observacion { get; set; }

    public virtual ICollection<Solicitude> Solicitudes { get; set; } = new List<Solicitude>();
}
