using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Dne
{
    public decimal? NumeroAsoc { get; set; }

    public DateTime? FechaAsoc { get; set; }

    public string Articulo { get; set; } = null!;

    public string? Cadena { get; set; }
}
