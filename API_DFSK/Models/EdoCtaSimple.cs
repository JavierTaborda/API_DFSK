using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class EdoCtaSimple
{
    public string? Cliente { get; set; }

    public string Doc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Banco { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public decimal? Monto { get; set; }

    public decimal? Debitos { get; set; }

    public decimal? Creditos { get; set; }
}
