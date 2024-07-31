using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Ser
{
    public decimal Numero { get; set; }

    public string Tipo { get; set; } = null!;

    public string Serial { get; set; } = null!;

    public string Cliente { get; set; } = null!;
}
