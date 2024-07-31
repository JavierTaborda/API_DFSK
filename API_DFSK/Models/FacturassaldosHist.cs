using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class FacturassaldosHist
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public decimal? Descuento { get; set; }

    public decimal Saldo { get; set; }

    public decimal? Recibo { get; set; }

    public string? Periodo { get; set; }
}
