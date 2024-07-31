using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Pcompra
{
    public string Cliente { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Pcvend { get; set; }

    public string? Pcompra1 { get; set; }

    public DateTime? Fecha { get; set; }
}
