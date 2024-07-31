using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Garantiasactual
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public string? Serial { get; set; }

    public string? Diagnostico { get; set; }
}
