using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Usuariosfi
{
    public string Cliente { get; set; } = null!;

    public string? Username { get; set; }

    public string? Pass { get; set; }

    public string? Status { get; set; }

    public string? Rol { get; set; }
}
