using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoEstadocuenta
{
    public string Cliente { get; set; } = null!;

    public string? DetalleSaldo { get; set; }
}
