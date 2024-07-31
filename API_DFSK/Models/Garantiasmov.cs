using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Garantiasmov
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public string? Serial { get; set; }

    public string? Diagnostico { get; set; }

    public string? TipoAsoc { get; set; }

    public DateTime? FechaAsoc { get; set; }

    public decimal? NumeroAsoc { get; set; }
}
