using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Cartera
{
    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public DateTime Fecha { get; set; }

    public string Cliente { get; set; } = null!;

    public string? TipoLog { get; set; }

    public DateTime? FechaLog { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string? Ciudad { get; set; }

    public decimal Plazo { get; set; }

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public decimal Saldo { get; set; }

    public decimal? Tasa { get; set; }

    public string? Retencion { get; set; }

    public decimal ReciboRet { get; set; }

    public decimal ReciboNro { get; set; }

    public string Recolecta { get; set; } = null!;

    public string? Comentario { get; set; }
}
