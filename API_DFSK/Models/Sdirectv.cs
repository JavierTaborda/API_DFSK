using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Sdirectv
{
    public string TipoDoc { get; set; } = null!;

    public string? NumeroDoc { get; set; }

    public DateTime FechaF { get; set; }

    public string Rif { get; set; } = null!;

    public string Cliente { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public string Serial { get; set; } = null!;
}
