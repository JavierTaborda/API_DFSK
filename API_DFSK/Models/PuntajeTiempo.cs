using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class PuntajeTiempo
{
    public string Cliente { get; set; } = null!;

    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public DateTime? Despacho { get; set; }

    public decimal Numero { get; set; }

    public decimal? Monto { get; set; }

    public decimal Diascredito { get; set; }

    public DateTime? Fechacierre { get; set; }

    public int? Diasacierre { get; set; }

    public decimal? Antcierre { get; set; }
}
