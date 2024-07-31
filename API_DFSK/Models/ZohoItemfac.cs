using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoItemfac
{
    public decimal Numero { get; set; }

    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string? Items { get; set; }
}
