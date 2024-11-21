using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class RepuestosOferta
{
    public int IdRepuestoOferta { get; set; }

    public int IdOfertas { get; set; }

    public int IdRepuesto { get; set; }

    public double Porcentaje { get; set; }

    public int CantidadMin { get; set; }

    public int UsosMaximos { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public bool Estado { get; set; }

    public virtual Oferta IdOfertasNavigation { get; set; } = null!;

    public virtual ICollection<TrackOferta> TrackOferta { get; set; } = new List<TrackOferta>();
}
