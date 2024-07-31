using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class CarteraCierre
{
    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Saldo { get; set; }

    public decimal? Recibo { get; set; }

    public string Cliente { get; set; } = null!;

    public string? Sede { get; set; }

    public decimal Plazo { get; set; }

    public decimal Iva { get; set; }

    public decimal? NumeroAsoc { get; set; }

    public decimal Total { get; set; }

    public string? TipoLog { get; set; }

    public DateTime? FechaLog { get; set; }

    public decimal? NumeroLog { get; set; }

    public decimal? Tasa { get; set; }

    public string Vendedor { get; set; } = null!;

    public string? Comentario { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Contacto { get; set; }

    public string? Retencion { get; set; }
}
