using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Clafe
{
    public string Usuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public decimal? Prioridad { get; set; }
}
