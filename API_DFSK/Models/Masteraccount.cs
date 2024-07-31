using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Masteraccount
{
    public string Cliente { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Master { get; set; }

    public string Nmaster { get; set; } = null!;
}
