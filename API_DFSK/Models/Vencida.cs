using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Vencida
{
    public string Cliente { get; set; } = null!;

    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string? Celular { get; set; }

    public string Estado { get; set; } = null!;

    public decimal Link { get; set; }

    public string Tipon { get; set; } = null!;
}
