using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Documento
{
    public string Documento1 { get; set; } = null!;

    public decimal Numero { get; set; }

    public string? Descripcion { get; set; }

    public string? Titulo { get; set; }

    public int Nrounico { get; set; }

    public int? Sucursal { get; set; }

    public virtual ICollection<Cotizacione> Cotizaciones { get; set; } = new List<Cotizacione>();

    public virtual ICollection<Despacho> Despachos { get; set; } = new List<Despacho>();
}
