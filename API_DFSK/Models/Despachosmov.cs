using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Despachosmov
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public string Serial { get; set; } = null!;

    public decimal? Garantia { get; set; }

    public string? Idcaja { get; set; }

    public string? Serial1 { get; set; }

    public decimal? Idnumero { get; set; }

    public decimal? Bodega { get; set; }

    public int? Nrounico { get; set; }
}
