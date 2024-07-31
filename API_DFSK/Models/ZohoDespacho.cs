using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoDespacho
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string TipoAsoc { get; set; } = null!;

    public DateTime FechaAsoc { get; set; }

    public decimal NumeroAsoc { get; set; }

    public int? Nrounico { get; set; }
}
