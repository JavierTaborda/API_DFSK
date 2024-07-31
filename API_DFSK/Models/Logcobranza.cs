using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Logcobranza
{
    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Cobrado { get; set; }
}
