using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class TplinkCChannel
{
    public int? Year { get; set; }

    public string? Month { get; set; }

    public string CustomerId { get; set; } = null!;

    public string Customer { get; set; } = null!;

    public string? Channel { get; set; }

    public decimal? Qty { get; set; }
}
