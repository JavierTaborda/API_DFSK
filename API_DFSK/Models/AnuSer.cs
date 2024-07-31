using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class AnuSer
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Docasoc { get; set; } = null!;

    public DateTime Fechaasoc { get; set; }

    public decimal Numeroasoc { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal? Canu { get; set; }
}
