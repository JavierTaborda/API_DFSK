using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Wholesaler
{
    public int? Año { get; set; }

    public string? Mes { get; set; }

    public string Rif { get; set; } = null!;

    public string Cliente { get; set; } = null!;

    public string? Doc { get; set; }

    public string Marca { get; set; } = null!;

    public decimal? Montos { get; set; }

    public decimal? Costos { get; set; }
}
