using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class PrecioServicio
{
    public int IdPrecioServicio { get; set; }

    public int IdUsuario { get; set; }

    public double Precio { get; set; }

    public int IdServicios { get; set; }

    public bool Estado { get; set; }

    public virtual Servicio IdServiciosNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<SolicitudServicio> SolicitudServicios { get; set; } = new List<SolicitudServicio>();
}
