using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Estadofiltro
{
    public double Estado { get; set; }

    public string Marca { get; set; } = null!;

    public int? Moa { get; set; }
}
