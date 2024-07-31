using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Importacionesmov
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public decimal Codigo { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal Valor { get; set; }
}
