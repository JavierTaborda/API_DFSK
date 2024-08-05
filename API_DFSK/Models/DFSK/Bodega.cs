using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Bodega
{
    public string Articulo { get; set; } = null!;

    public decimal Bodega1 { get; set; }

    public decimal Existencia { get; set; }

    public virtual Articulo ArticuloNavigation { get; set; } = null!;
}
