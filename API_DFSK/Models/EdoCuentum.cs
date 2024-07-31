using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class EdoCuentum
{
    public string Cliente { get; set; } = null!;

    public decimal Numero { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Plazo { get; set; }

    public decimal? Saldo { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? PorVencer { get; set; }

    public decimal? Vencido { get; set; }
}
