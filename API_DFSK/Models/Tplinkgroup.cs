using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Tplinkgroup
{
    public int? Year { get; set; }

    public string? Month { get; set; }

    public string Grupo { get; set; } = null!;

    public decimal? Qty { get; set; }
}
