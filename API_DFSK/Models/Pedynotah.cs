using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Pedynotah
{
    public string Tipo { get; set; } = null!;

    public decimal NDoc { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Producto { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal? PDolar { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? SubtDolar { get; set; }
}
