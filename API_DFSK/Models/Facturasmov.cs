using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Facturasmov
{
    public DateTime Fecha { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Valor { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Precio { get; set; }

    public decimal Bodega { get; set; }

    public decimal Despacho { get; set; }

    public string? TipoAsoc { get; set; }

    public DateTime? FechaAsoc { get; set; }

    public decimal? NumeroAsoc { get; set; }

    public decimal? Valord { get; set; }

    public decimal? Costod { get; set; }

    public decimal? Costobs { get; set; }

    public decimal? Obs { get; set; }

    public decimal? Puntos { get; set; }

    public int Nrounico { get; set; }

    public string? Serialm { get; set; }

    public string? Placa { get; set; }
}
