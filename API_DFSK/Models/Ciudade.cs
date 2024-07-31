using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Ciudade
{
    public double Estado { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual Estado EstadoNavigation { get; set; } = null!;
}
