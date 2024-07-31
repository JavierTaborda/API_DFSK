using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Seriale
{
    public decimal NumeroFac { get; set; }

    public DateTime FechaFac { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal NotaSerial { get; set; }

    public string Serial { get; set; } = null!;

    public string? Cliente { get; set; }
}
