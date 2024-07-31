using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class PedidosZoho
{
    public decimal NumeroPed { get; set; }

    public DateTime Fecha { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string Articulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? DescuentoG { get; set; }

    public decimal Precio { get; set; }
}
