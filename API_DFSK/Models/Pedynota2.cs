using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Pedynota2
{
    public string Tipo { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal? Tasa { get; set; }

    public decimal? Cambio { get; set; }

    public string Usuario { get; set; } = null!;

    public decimal Total { get; set; }

    public decimal Iva { get; set; }

    public string? Vendedor { get; set; }

    public string? Comentario { get; set; }

    public decimal? Porcentaje { get; set; }
}
