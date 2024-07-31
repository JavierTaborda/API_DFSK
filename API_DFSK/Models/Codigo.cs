using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Codigo
{
    public decimal Codigo1 { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Tipo { get; set; } = null!;
}
