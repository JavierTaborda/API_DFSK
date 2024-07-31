using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Recibosmovfp
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string? Cliente { get; set; }

    public decimal Banco { get; set; }

    public string? Cheque { get; set; }

    public decimal Valor { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FechaAsoc { get; set; }

    public string? TipoAsoc { get; set; }

    public decimal? NumeroAsoc { get; set; }

    public DateTime? Fecharef { get; set; }

    public string? Tipo { get; set; }
}
