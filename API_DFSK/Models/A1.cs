using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class A1
{
    public string Programa { get; set; } = null!;

    public decimal Id { get; set; }

    public decimal? Bodega { get; set; }

    public decimal? Bodegaf { get; set; }

    public string? Impresora { get; set; }

    public string? Progasoc { get; set; }
}
