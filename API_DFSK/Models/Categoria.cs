using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Categoria
{
    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Tipo { get; set; }
}
