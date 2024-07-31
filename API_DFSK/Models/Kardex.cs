using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Kardex
{
    public DateTime Fecha { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal Saldo { get; set; }

    public decimal CantEnt { get; set; }

    public decimal CantIn { get; set; }

    public decimal CantFact { get; set; }

    public decimal CantOut { get; set; }

    public decimal CantEns { get; set; }
}
