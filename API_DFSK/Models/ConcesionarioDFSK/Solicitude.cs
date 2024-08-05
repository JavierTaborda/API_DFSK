using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Solicitude
{
    public int IdSolicitud { get; set; }

    public int? IdVendedor { get; set; }

    public int? IdRepuesto { get; set; }

    public double? Cantidad { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public int? IdEstado { get; set; }

    public DateOnly? FechaCompra { get; set; }

    public string? Observacion { get; set; }

    public DateOnly? FechaLlegada { get; set; }

    public virtual Estado? IdEstadoNavigation { get; set; }

    public virtual Repuesto? IdRepuestoNavigation { get; set; }

    public virtual Vendedore? IdVendedorNavigation { get; set; }
}
