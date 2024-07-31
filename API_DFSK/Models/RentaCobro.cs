using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class RentaCobro
{
    public string? Periodo { get; set; }

    public DateTime? Fechaf { get; set; }

    public DateTime? Fechab { get; set; }

    public decimal? Numerof { get; set; }

    public string? TipoDoc { get; set; }

    public decimal? Tasaf { get; set; }

    public decimal? Costof { get; set; }

    public decimal? Monto { get; set; }

    public decimal NroRecibo { get; set; }

    public decimal Montobs { get; set; }

    public decimal? TasaAct { get; set; }

    public decimal? Equiv { get; set; }

    public decimal? Dif { get; set; }

    public decimal Banco { get; set; }
}
