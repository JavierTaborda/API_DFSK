using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Zactdespacho
{
    public int? Numero { get; set; }

    public DateTime? Fecha { get; set; }

    public string? TipoDoc { get; set; }

    public string? Articulo { get; set; }

    public int? Despacho { get; set; }
}
