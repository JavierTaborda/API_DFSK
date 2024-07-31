using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class FacturassaldoCierre
{
    public string? Periodo { get; set; }

    public string? Cliente { get; set; }

    public decimal? Total { get; set; }
}
