using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Revcicpc
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Docasoc { get; set; } = null!;

    public decimal Numeroasoc { get; set; }

    public string Articulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public string Serial { get; set; } = null!;
}
