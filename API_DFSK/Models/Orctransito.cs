using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Orctransito
{
    public decimal Odc { get; set; }

    public DateTime FechaOdc { get; set; }

    public string? Marca { get; set; }

    public string Articulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Pedido { get; set; }

    public decimal Cargado { get; set; }

    public decimal? Transito { get; set; }

    public string? Comentario { get; set; }
}
