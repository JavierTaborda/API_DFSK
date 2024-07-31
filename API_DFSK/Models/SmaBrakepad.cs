using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class SmaBrakepad
{
    public string Articulo { get; set; } = null!;

    public string? Modelo { get; set; }

    public decimal? Menos1 { get; set; }

    public decimal? Menos2 { get; set; }

    public decimal? Menos3 { get; set; }

    public decimal? Menos4 { get; set; }

    public decimal? Menos5 { get; set; }

    public decimal? Menos6 { get; set; }

    public decimal? Prom { get; set; }
}
