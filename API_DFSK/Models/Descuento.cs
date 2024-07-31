using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Descuento
{
    public DateTime Fecha { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public decimal? Descuentobs { get; set; }
}
