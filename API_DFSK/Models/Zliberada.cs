using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Zliberada
{
    public int Numero { get; set; }

    public DateTime Fecha { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string? TipoLog { get; set; }

    public DateTime? FechaLog { get; set; }

    public int? NumeroLog { get; set; }

    public int? Ejecutado { get; set; }
}
