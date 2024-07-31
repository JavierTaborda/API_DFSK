using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Costo
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public decimal? Monto { get; set; }

    public decimal Costo1 { get; set; }

    public decimal? Tasa { get; set; }

    public decimal? Tasasf { get; set; }
}
