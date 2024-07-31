using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Logisticamov
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string TipoAsoc { get; set; } = null!;

    public DateTime FechaAsoc { get; set; }

    public decimal NumeroAsoc { get; set; }

    public string? TipoLog { get; set; }

    public DateTime? FechaLog { get; set; }

    public int? NumeroLog { get; set; }

    public decimal? NroArticulos { get; set; }

    public int? Bultos { get; set; }

    public int? Zona { get; set; }

    public decimal? Cambio { get; set; }

    public decimal? Total { get; set; }

    public int? Entrega { get; set; }

    public int? NumeroPic { get; set; }
}
