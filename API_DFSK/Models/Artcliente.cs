using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Artcliente
{
    public string Articulo { get; set; } = null!;

    public decimal? Cant { get; set; }

    public string Cliente { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal? Estado { get; set; }
}
