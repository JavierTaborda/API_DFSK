using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoEvento
{
    public int Nro { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Correo { get; set; }

    public string? Propietario { get; set; }

    public string? Contenido { get; set; }

    public string? Estatus { get; set; }
}
