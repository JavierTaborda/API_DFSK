using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estado { get; set; }

    public string? PlacaVehiculo { get; set; }

    public virtual ICollection<SolicitudServicio> SolicitudServicios { get; set; } = new List<SolicitudServicio>();
}
