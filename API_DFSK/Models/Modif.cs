using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Modif
{
    public DateTime? Fecha { get; set; }

    public string? TipoDoc { get; set; }

    public decimal? Numero { get; set; }

    public decimal? Interes { get; set; }

    public decimal? Ncuotas { get; set; }

    public DateTime? Fechai { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Vcuota { get; set; }

    public decimal? Vinteres { get; set; }

    public DateTime? FechaAsoc { get; set; }

    public string? TipoAsoc { get; set; }

    public decimal? NumeroAsoc { get; set; }

    public decimal? Cuotatotal { get; set; }

    public decimal? Interestotal { get; set; }

    public decimal? Saldoa { get; set; }

    public decimal? Interesa { get; set; }

    public decimal? SaldoAntes { get; set; }

    public decimal? InteresAntes { get; set; }
}
