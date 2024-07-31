using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Recordanula
{
    public int? Bodega { get; set; }

    public int? ExisA { get; set; }

    public int? ExisN { get; set; }

    public string? Prod { get; set; }

    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }
}
