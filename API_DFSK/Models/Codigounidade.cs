using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Codigounidade
{
    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Valor { get; set; }
}
