using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Serialesvehiculo
{
    public string? Articulo { get; set; }

    public string? Scarroceria { get; set; }

    public string? Smotor { get; set; }

    public string? Puertoentrada { get; set; }

    public string? Nimpuestos { get; set; }

    public string? Fimpuestos { get; set; }

    public int? NumCompra { get; set; }

    public DateTime? FCompra { get; set; }

    public string? Sniv { get; set; }

    public string? Schasis { get; set; }

    public string? Scarrozado { get; set; }
}
