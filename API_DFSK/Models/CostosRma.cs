using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class CostosRma
{
    public string? Mes { get; set; }

    public DateOnly? Fecha { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Modelo { get; set; }

    public string? Marca { get; set; }

    public string? Grupo { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal Doc { get; set; }

    public decimal Origen { get; set; }

    public decimal Destino { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Costou { get; set; }

    public decimal? Costot { get; set; }
}
