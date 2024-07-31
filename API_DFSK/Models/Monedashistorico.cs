using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Monedashistorico
{
    public string Moneda { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public decimal Cambio { get; set; }

    public decimal? Costo { get; set; }

    public string? Usuario { get; set; }

    public string? Comentario { get; set; }
}
