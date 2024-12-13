using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Servicio
{
    public int IdServicios { get; set; }

    public string Servicio1 { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<PrecioServicio> PrecioServicios { get; set; } = new List<PrecioServicio>();
}
