using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Listap
{
    public string Articulo { get; set; } = null!;

    public decimal Existencia { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Precio1 { get; set; }

    public decimal? Cif { get; set; }

    public decimal? Fob { get; set; }

    public decimal? Profit { get; set; }

    public decimal? Factor { get; set; }
}
