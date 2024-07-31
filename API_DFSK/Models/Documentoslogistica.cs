using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Documentoslogistica
{
    public string Documento { get; set; } = null!;

    public decimal Numero { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Logistica> Logisticas { get; set; } = new List<Logistica>();
}
