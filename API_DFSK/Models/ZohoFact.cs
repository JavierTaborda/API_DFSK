using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoFact
{
    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public decimal Plazo { get; set; }

    public DateTime? FechaVenc { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public string DetalleFac { get; set; } = null!;

    public string Despacho { get; set; } = null!;

    public DateTime? FechaDesp { get; set; }

    public string? Estatus { get; set; }

    public string Estado { get; set; } = null!;

    public decimal? TotaIva { get; set; }

    public string? Link { get; set; }
}
