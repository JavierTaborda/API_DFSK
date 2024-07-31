using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Cotizacione
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public string? TipoAsoc { get; set; }

    public decimal? NumeroAsoc { get; set; }

    public string? Comentario { get; set; }

    public string Vendedor { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public DateTime? FechaAsoc { get; set; }

    public decimal? Bodega { get; set; }

    public decimal? Cambio { get; set; }

    public decimal? Tasa { get; set; }

    public int? Solicitud { get; set; }

    public decimal? Pago { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Cuotai { get; set; }

    public decimal? Dias { get; set; }

    public decimal? Interes { get; set; }

    public decimal? Ncuotas { get; set; }

    public DateTime? Fechai { get; set; }

    public DateTime? FProd { get; set; }

    public DateTime? FEmb { get; set; }

    public DateTime? FNac { get; set; }

    public DateTime? FEnt { get; set; }

    public virtual Documento TipoDocNavigation { get; set; } = null!;
}
