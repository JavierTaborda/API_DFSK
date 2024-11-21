using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Oferta
{
    public int IdOfertas { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Observacion { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<RepuestosOferta> RepuestosOferta { get; set; } = new List<RepuestosOferta>();
}
