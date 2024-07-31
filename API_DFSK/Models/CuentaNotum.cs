using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class CuentaNotum
{
    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public DateTime Fecha { get; set; }

    public string Cliente { get; set; } = null!;

    public decimal? Total { get; set; }

    public string? Cadena { get; set; }
}
