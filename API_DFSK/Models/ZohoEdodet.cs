using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoEdodet
{
    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public DateTime Fecha { get; set; }

    public string Cliente { get; set; } = null!;

    public string? Cadena { get; set; }
}
