using System;
using System.Collections.Generic;

namespace API_DFSK.Models.DFSK;

public partial class ApiArticulosBodega
{
    public string Articulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Unidad { get; set; }

    public string Marca { get; set; } = null!;

    public decimal? Existencia { get; set; }

    public decimal? Grupo { get; set; }

    public decimal? Cif { get; set; }

    public decimal? Venta { get; set; }

    public string? Modelo { get; set; }
}
