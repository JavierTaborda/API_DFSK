using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ActualizaCliente
{
    public string Cliente { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
