using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Logisticaseriale
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Articulo { get; set; } = null!;

    public int Bodega { get; set; }

    public int? Cantidad { get; set; }

    public string Serial { get; set; } = null!;

    public string? Serial1 { get; set; }

    public virtual Articulo ArticuloNavigation { get; set; } = null!;
}
