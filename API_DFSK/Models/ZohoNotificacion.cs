using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoNotificacion
{
    public int Nrounico { get; set; }

    public string? Cliente { get; set; }

    public string? Celular { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Tipo { get; set; }

    public string? Estado { get; set; }

    public string? Link { get; set; }

    public decimal? Numero { get; set; }

    public string? Tipon { get; set; }

    public decimal? Total { get; set; }

    public decimal? Vencido { get; set; }

    public decimal? PorVencer { get; set; }

    public decimal? SaldoFavor { get; set; }
}
