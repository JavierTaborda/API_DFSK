using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Ensamble
{
    public string Articulo { get; set; } = null!;

    public string ArticuloAsoc { get; set; } = null!;

    public decimal? Cantidad { get; set; }

    public virtual Articulo ArticuloNavigation { get; set; } = null!;
}
