using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Sucursal
{
    public string Sucursal1 { get; set; } = null!;

    public string Cliente { get; set; } = null!;

    public decimal? Estado { get; set; }

    public string? Ciudad { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }
}
