using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Suli
{
    public string Compañia { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string? Periodo { get; set; }

    public string? Dia { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Vend { get; set; }

    public string Cliente { get; set; } = null!;

    public decimal Numero { get; set; }

    public decimal? Tasa { get; set; }

    public decimal? Fncr { get; set; }

    public decimal? Monto { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Utilidad { get; set; }

    public decimal? Renta { get; set; }
}
