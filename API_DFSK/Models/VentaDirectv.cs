using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class VentaDirectv
{
    public string Compañia { get; set; } = null!;

    public string Vendedor { get; set; } = null!;

    public string? Periodo { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Dia { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Codigo { get; set; } = null!;

    public string Producto { get; set; } = null!;

    public decimal Qty { get; set; }

    public string Marca { get; set; } = null!;

    public decimal? Venta { get; set; }

    public decimal? Ventad { get; set; }

    public decimal Costod { get; set; }

    public decimal Costo { get; set; }

    public decimal? Tasaf { get; set; }

    public decimal? Tasa { get; set; }
}
