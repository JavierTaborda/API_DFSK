using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Articulosficha
{
    public string Articulo { get; set; } = null!;

    public byte[]? Foto { get; set; }

    public string? Caracteristicas { get; set; }
}
