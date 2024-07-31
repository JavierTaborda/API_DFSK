using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class LatestFob
{
    public DateTime? Fecha { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal? Fob { get; set; }
}
