using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class TplinkCGroup
{
    public int? Year { get; set; }

    public string? Month { get; set; }

    public string CustomerId { get; set; } = null!;

    public string Customer { get; set; } = null!;

    public string Category { get; set; } = null!;

    public decimal? Qty { get; set; }
}
