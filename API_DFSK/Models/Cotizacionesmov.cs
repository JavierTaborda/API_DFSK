using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Cotizacionesmov
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Valor { get; set; }

    public decimal? Bodega { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Precio { get; set; }
}
