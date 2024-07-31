using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Facturassaldo
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public decimal Saldo { get; set; }

    public decimal? Recibo { get; set; }

    public string? Tipoasoc { get; set; }

    public DateTime? Fechaasoc { get; set; }

    public decimal? Numeroasoc { get; set; }
}
