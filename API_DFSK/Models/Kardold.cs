using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Kardold
{
    public string Articulo { get; set; } = null!;

    public decimal? Saldo { get; set; }

    public decimal? CantEnt { get; set; }

    public decimal? CantOut { get; set; }

    public decimal? CantFact { get; set; }

    public decimal? CantEns { get; set; }
}
