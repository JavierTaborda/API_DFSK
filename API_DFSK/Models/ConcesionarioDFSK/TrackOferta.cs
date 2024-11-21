using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class TrackOferta
{
    public int IdTrackOferta { get; set; }

    public int IdRepuestoOferta { get; set; }

    public virtual RepuestosOferta IdRepuestoOfertaNavigation { get; set; } = null!;
}
