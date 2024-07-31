using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Revseriale
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public string Serial { get; set; } = null!;

    public string? Cliente { get; set; }

    public string? Docasoc { get; set; }

    public DateTime? Fechaasoc { get; set; }

    public decimal? Numeroasoc { get; set; }
}
