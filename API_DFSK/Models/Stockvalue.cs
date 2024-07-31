using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Stockvalue
{
    public string Brand { get; set; } = null!;

    public decimal? Stock { get; set; }

    public decimal? Tcif { get; set; }

    public decimal? Tsale { get; set; }
}
