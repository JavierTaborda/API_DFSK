using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class ResumenSolicitud
{
    public int IdResumenSolicitud { get; set; }

    public DateTime? FechaCreacion{ get; set; }

    public bool Estatus { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? Observacion { get; set; }

    public int IdVendedor { get; set; }

    public virtual Vendedore IdVendedorNavigation { get; set; } = null!;

    public virtual ICollection<Solicitude> Solicitudes { get; set; } = new List<Solicitude>();
}
