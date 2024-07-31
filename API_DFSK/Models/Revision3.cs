using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Revision3
{
    public decimal Numero { get; set; }

    public DateTime Fecha { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string Articulo { get; set; } = null!;

    public string? Modelo { get; set; }

    public decimal? Marca { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Despacho { get; set; }

    public decimal Dev { get; set; }

    public decimal Ser { get; set; }
}
