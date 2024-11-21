using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Cupone
{
    public int IdCupones { get; set; }

    public string Codigo { get; set; } = null!;

    public string Decsripcion { get; set; } = null!;

    public DateTime FechaExpìracion { get; set; }

    public bool Estado { get; set; }
}
