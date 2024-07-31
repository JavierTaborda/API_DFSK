using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Clientesat
{
    public string? Periodo { get; set; }

    public string Usuario { get; set; } = null!;

    public string Cliente { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
