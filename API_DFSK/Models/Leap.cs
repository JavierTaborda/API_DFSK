using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Leap
{
    public string Cliente { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public string? Representante { get; set; }

    public string? Cargo { get; set; }
}
