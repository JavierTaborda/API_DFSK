using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Recibosprov
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string? Cliente { get; set; }

    public decimal Banco { get; set; }

    public decimal Cuenta { get; set; }

    public decimal Cheque { get; set; }

    public DateTime FechaAsoc { get; set; }

    public decimal Valor { get; set; }

    public decimal Causal { get; set; }
}
