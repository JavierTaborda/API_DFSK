using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class F
{
    public DateTime Fecha { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public decimal Plazo { get; set; }

    public decimal? Descuento { get; set; }

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public decimal Bodega { get; set; }

    public string? Moneda { get; set; }

    public decimal Cambio { get; set; }

    public string? TipoAsoc { get; set; }

    public DateTime? FechaAsoc { get; set; }

    public decimal? NumeroAsoc { get; set; }

    public string Usuario { get; set; } = null!;

    public string? Comentario { get; set; }

    public string? Vendedor { get; set; }

    public string? Ensamble { get; set; }

    public decimal? Transporte { get; set; }

    public DateTime? Despachos { get; set; }

    public decimal? Tasa { get; set; }

    public string? Comentario2 { get; set; }

    public string? TipoLog { get; set; }

    public DateTime? FechaLog { get; set; }

    public decimal? NumeroLog { get; set; }

    public decimal? Bultos { get; set; }

    public string? Invoice { get; set; }

    public decimal? Tasar { get; set; }

    public decimal? Tasaasoc { get; set; }
}
