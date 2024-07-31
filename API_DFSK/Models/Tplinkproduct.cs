using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Tplinkproduct
{
    public int? Year { get; set; }

    public string? Month { get; set; }

    public string Grupo { get; set; } = null!;

    public string? Modelo { get; set; }

    public decimal? Qty { get; set; }
}
