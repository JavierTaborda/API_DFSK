using System;
using System.Collections.Generic;

namespace API_DFSK.Models.DFSK;

public partial class Modelo
{
    public int Idmodelo { get; set; }

    public string? Descripcion { get; set; }

    public string? Modelo1 { get; set; }

    public string? Ano { get; set; }

    public string? Marca { get; set; }

    public bool? Estado { get; set; }
}
