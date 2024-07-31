using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class DtvHist
{
    public string Rif { get; set; } = null!;

    public string Cliente { get; set; } = null!;

    public DateOnly? Fecha { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Acum { get; set; }
}
