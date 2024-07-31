using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Importacione
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public decimal TotalFob { get; set; }

    public decimal TotalCif { get; set; }

    public decimal Total { get; set; }

    public string? Moneda { get; set; }

    public decimal Cambio { get; set; }

    public string? TipoAsoc { get; set; }

    public DateTime? FechaAsoc { get; set; }

    public decimal? NumeroAsoc { get; set; }

    public string? Usuario { get; set; }

    public string? Invoice { get; set; }
}
