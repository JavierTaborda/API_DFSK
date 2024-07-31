using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Tpreserva
{
    public string Articulo { get; set; } = null!;

    public decimal? Cant { get; set; }

    public decimal? Bodega { get; set; }
}
