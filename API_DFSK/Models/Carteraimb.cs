using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Carteraimb
{
    public string? A2 { get; set; }

    public decimal? Numeroasoc { get; set; }

    public decimal? NumeroAsoc1 { get; set; }

    public string? TipoAsoc { get; set; }

    public DateTime? FechaAsoc { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Plazo { get; set; }

    public string Sede { get; set; } = null!;

    public string Cliente { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Retencion { get; set; }

    public string? Telefono { get; set; }

    public string? Ciudad { get; set; }

    public string Estado { get; set; } = null!;

    public string? Vendedor { get; set; }

    public string? Ejecutivo { get; set; }

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public decimal Saldo { get; set; }

    public decimal? Recibo { get; set; }

    public string? Contacto { get; set; }

    public string? R2 { get; set; }

    public string? TipoLog { get; set; }

    public DateTime? FechaLog { get; set; }

    public decimal? NumeroLog { get; set; }

    public decimal? Tasa { get; set; }

    public string? Comentario { get; set; }

    public decimal? N2 { get; set; }

    public decimal Interes { get; set; }

    public decimal? Ncuotas { get; set; }
}
