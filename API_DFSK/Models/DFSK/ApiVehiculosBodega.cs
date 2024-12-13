using System;
using System.Collections.Generic;

namespace API_DFSK.Models.DFSK;

public partial class ApiVehiculosBodega
{
    public string? Articulo { get; set; }

    public string? Descripcion { get; set; }

    public string Marca { get; set; } = null!;

    public decimal? Venta { get; set; }

    public string? Modelo { get; set; }

    public string? Ano { get; set; }

    public string? Color { get; set; }

    public string? Modeloi { get; set; }

    public string? Tipoc { get; set; }

    public string? Puestos { get; set; }

    public int? Bodega { get; set; }

    public string? Urlimagen { get; set; }

    public int? Existencia { get; set; }
}
