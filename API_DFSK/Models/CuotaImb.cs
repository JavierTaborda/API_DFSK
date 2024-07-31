using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class CuotaImb
{
    public string Nombre { get; set; } = null!;

    public string? Tipofac { get; set; }

    public decimal? Nrofact { get; set; }

    public decimal Nrocuota { get; set; }

    public DateTime? Fcuota { get; set; }

    public string Cliente { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Telefono { get; set; }

    public string Vendedor { get; set; } = null!;

    public decimal? Saldo { get; set; }

    public decimal? Interes { get; set; }

    public string? Articulo { get; set; }

    public string? Placa { get; set; }

    public string? Serialm { get; set; }

    public string? Correo { get; set; }

    public string? TelefonoAnalista { get; set; }
}
