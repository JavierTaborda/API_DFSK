using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Modusuario
{
    public string Usuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public string? Modulo { get; set; }

    public decimal Prioridad { get; set; }

    public decimal Descuento { get; set; }

    public decimal Bodega { get; set; }

    public string? Grafico { get; set; }

    public string? Remoto { get; set; }

    public string Plazo { get; set; } = null!;

    public string? Bodegas { get; set; }

    public decimal? Presupuesto { get; set; }

    public virtual ICollection<Usuariospermiso> Usuariospermisos { get; set; } = new List<Usuariospermiso>();
}
