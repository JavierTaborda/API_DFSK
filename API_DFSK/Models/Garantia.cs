using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Garantia
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public string Tipogar { get; set; } = null!;

    public DateTime Fechagar { get; set; }

    public decimal Numerogar { get; set; }

    public string? Comentario { get; set; }

    public string Usuario { get; set; } = null!;
}
