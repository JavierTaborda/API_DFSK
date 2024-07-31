using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class EdoCtaSimple2
{
    public string? Cliente { get; set; }

    public string Doc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Banco { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public decimal? Monto { get; set; }

    public int Debitos { get; set; }

    public decimal? Credito { get; set; }
}
