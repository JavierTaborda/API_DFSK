using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class CajaSerial
{
    public string? Serial { get; set; }

    public int? Caja { get; set; }

    public int? Paleta { get; set; }

    public string? Articulo { get; set; }
}
