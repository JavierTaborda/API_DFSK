using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Profit2019
{
    public string Tipo { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Articulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Cant { get; set; }

    public decimal Precio { get; set; }

    public decimal? Precio1 { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Costou { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Utilidad { get; set; }

    public decimal? Desct { get; set; }

    public decimal? Profit { get; set; }
}
