using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Solicitude
{
    public int IdSolicitud { get; set; }

    public int IdVendedor { get; set; }

    public int IdRepuesto { get; set; }

    public double? Cantidad { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public int IdEstado { get; set; }

    public DateTime? FechaCompra { get; set; }

    public string? Observacion { get; set; }

    public DateTime? FechaLlegada { get; set; }

    public int IdResumenSolicitud { get; set; }

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual Repuesto IdRepuestoNavigation { get; set; } = null!;

    public virtual ResumenSolicitud IdResumenSolicitudNavigation { get; set; } = null!;

    public virtual Vendedore IdVendedorNavigation { get; set; } = null!;
}
