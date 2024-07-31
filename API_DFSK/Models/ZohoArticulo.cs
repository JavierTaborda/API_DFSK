using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoArticulo
{
    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Marca { get; set; } = null!;

    public string? Unidad { get; set; }

    public decimal? Iva { get; set; }

    public DateTime? Fechacif { get; set; }

    public decimal? Cif { get; set; }

    public decimal? Garantia { get; set; }

    public decimal? Descuento { get; set; }

    public DateTime? Fechaactual { get; set; }

    public decimal? Venta { get; set; }

    public decimal? Existencia { get; set; }
}
