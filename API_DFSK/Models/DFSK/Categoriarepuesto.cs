using System;
using System.Collections.Generic;

namespace API_DFSK.Models.DFSK;

public partial class Categoriarepuesto
{
    public int Idcategoria { get; set; }

    public int Idgrupo { get; set; }

    public string? Categoria { get; set; }

    public bool? Estado { get; set; }

    public virtual Gruposrepuesto IdgrupoNavigation { get; set; } = null!;
}
