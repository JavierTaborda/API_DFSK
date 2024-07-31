using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Reportevt2
{
    public string? Periodo { get; set; }

    public DateTime Flarga { get; set; }

    public DateTime Fecha { get; set; }

    public string? Dia { get; set; }

    public string Compañia { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Marca { get; set; }

    public decimal? Monto { get; set; }

    public decimal? Tasa { get; set; }

    public decimal? Tasar { get; set; }

    public decimal? Montod { get; set; }

    public decimal? Montof { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Costob { get; set; }
}
