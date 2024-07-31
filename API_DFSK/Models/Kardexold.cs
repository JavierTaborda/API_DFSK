using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Kardexold
{
    public string Fecha { get; set; } = null!;

    public string Articulo { get; set; } = null!;

    public decimal? Saldo { get; set; }
}
