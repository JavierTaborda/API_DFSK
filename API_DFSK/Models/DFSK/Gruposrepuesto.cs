using System;
using System.Collections.Generic;

namespace API_DFSK.Models.DFSK;

public partial class Gruposrepuesto
{
    public int Idgrupo { get; set; }

    public string? Grupo { get; set; }

    public string? Detalle { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Categoriarepuesto> Categoriarepuestos { get; set; } = new List<Categoriarepuesto>();
}
