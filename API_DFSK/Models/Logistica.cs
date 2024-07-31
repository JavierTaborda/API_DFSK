using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Logistica
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public int? Camara { get; set; }

    public int? TipoEnvio { get; set; }

    public int? Zona { get; set; }

    public string? Vehiculo { get; set; }

    public decimal? Otros { get; set; }

    public decimal? Flete { get; set; }

    public decimal? Total { get; set; }

    public string? Comentario { get; set; }

    public virtual ICollection<Logisticamovart> Logisticamovarts { get; set; } = new List<Logisticamovart>();

    public virtual Documentoslogistica TipoDocNavigation { get; set; } = null!;
}
