using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Factura
{
    public DateTime Fecha { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public decimal Plazo { get; set; }

    public decimal Iva { get; set; }

    public decimal? Exento { get; set; }

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

    public decimal? Transporte { get; set; }

    public decimal? Tasa { get; set; }

    public string? Comentario2 { get; set; }

    public string? TipoLog { get; set; }

    public DateTime? FechaLog { get; set; }

    public decimal? NumeroLog { get; set; }

    public decimal? Bultos { get; set; }

    public string? Invoice { get; set; }

    public decimal? Tasar { get; set; }

    public decimal? Tasaasoc { get; set; }

    public decimal? Despachado { get; set; }

    public DateTime? FechaDes { get; set; }

    public string? Estatus { get; set; }

    public DateTime? Modificacion { get; set; }

    public string? Estado { get; set; }

    public string? Link { get; set; }

    public decimal? Porcentaje { get; set; }

    public string? Sede { get; set; }

    public decimal? Cuotai { get; set; }

    public decimal? Dias { get; set; }

    public decimal? Interes { get; set; }

    public decimal? Ncuotas { get; set; }

    public DateTime? Fechai { get; set; }

    public decimal? Igtf { get; set; }

    public decimal? Baseigtf { get; set; }

    public decimal? Tipof { get; set; }

    public string? Rcon { get; set; }

    public string? Ncon { get; set; }

    public string? Ejecutivo { get; set; }

    public string? Documento { get; set; }

    public string? Despacho { get; set; }
}
