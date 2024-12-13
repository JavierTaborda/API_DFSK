using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class SolicitudServicio
{
    public int IdSolicitudServicio { get; set; }

    public int IdCliente { get; set; }

    public int IdPrecioServicio { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public DateTime? FechaCita { get; set; }

    public DateTime? FechaCulminada { get; set; }

    public bool Estado { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual PrecioServicio IdPrecioServicioNavigation { get; set; } = null!;
}
