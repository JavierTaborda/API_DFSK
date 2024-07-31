using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class FacturassaldosMod
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public decimal Saldo { get; set; }

    public decimal? Recibo { get; set; }

    public string? Tipoasoc { get; set; }

    public DateTime? Fechaasoc { get; set; }

    public decimal? Numeroasoc { get; set; }

    public string? Tipom { get; set; }

    public string? Numerom { get; set; }

    public DateTime? Fecham { get; set; }

    public string? Tipo { get; set; }

    public string? Usuario { get; set; }
}
