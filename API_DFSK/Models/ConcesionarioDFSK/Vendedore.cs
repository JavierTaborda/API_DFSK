using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Vendedore
{
    public int IdVendedor { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Solicitude> Solicitudes { get; set; } = new List<Solicitude>();
}
