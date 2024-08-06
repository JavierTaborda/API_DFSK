using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Estado
{
    public int IdEstado { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public bool Estatus { get; set; }

    public virtual ICollection<Solicitude> Solicitudes { get; set; } = new List<Solicitude>();
}
