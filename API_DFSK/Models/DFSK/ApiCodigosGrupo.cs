using System;
using System.Collections.Generic;

namespace API_DFSK.Models.DFSK;

public partial class ApiCodigosGrupo
{
    public decimal Codigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Tipo { get; set; } = null!;
}
