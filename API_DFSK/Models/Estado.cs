using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Estado
{
    public double Estado1 { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? Codzona { get; set; }

    public int? Porcentaje { get; set; }

    public int? Tplink { get; set; }

    public virtual ICollection<Ciudade> Ciudades { get; set; } = new List<Ciudade>();
}
