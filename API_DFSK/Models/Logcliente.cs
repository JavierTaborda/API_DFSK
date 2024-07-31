using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Logcliente
{
    public string? TipoDoc { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Numero { get; set; }

    public decimal? Saldo { get; set; }

    public decimal? Saldod { get; set; }

    public DateTime? Fechalog { get; set; }

    public decimal? Cambio { get; set; }

    public int Nrounico { get; set; }
}
