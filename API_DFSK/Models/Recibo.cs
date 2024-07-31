using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Recibo
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public decimal Total { get; set; }

    public string TipoAsoc { get; set; } = null!;

    public DateTime FechaAsoc { get; set; }

    public decimal NumeroAsoc { get; set; }

    public string Usuario { get; set; } = null!;

    public string? Comentario { get; set; }

    public string? Igtf { get; set; }

    public decimal? Bigtf { get; set; }
}
