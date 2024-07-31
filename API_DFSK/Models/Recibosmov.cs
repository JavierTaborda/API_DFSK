using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Recibosmov
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string? Cliente { get; set; }

    public string TipoAsoc { get; set; } = null!;

    public DateTime FechaAsoc { get; set; }

    public decimal NumeroAsoc { get; set; }

    public decimal Valor { get; set; }

    public string Tipo { get; set; } = null!;
}
