using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Logisticaseg
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public DateTime FechaSeg { get; set; }

    public decimal Estado { get; set; }

    public string? Ciudad { get; set; }
}
