using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Sellin
{
    public string? Period { get; set; }

    public string? Año { get; set; }

    public int? Mesn { get; set; }

    public string? Mes { get; set; }

    public string Marca { get; set; } = null!;

    public string Grupo { get; set; } = null!;

    public string? Modelo { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Cost { get; set; }
}
