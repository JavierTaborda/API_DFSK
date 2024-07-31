using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class EdoCuenta2
{
    public string Cliente { get; set; } = null!;

    public decimal? Total { get; set; }

    public decimal? PorVencer { get; set; }

    public decimal? Vencido { get; set; }
}
