using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Revision2
{
    public string? TipoAsoc { get; set; }

    public decimal? NumeroAsoc { get; set; }

    public DateTime? FechaAsoc { get; set; }

    public string Articulo { get; set; } = null!;
}
