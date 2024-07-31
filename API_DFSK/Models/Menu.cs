using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Menu
{
    public string Programa { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Progasoc { get; set; }

    public string? Esreporte { get; set; }
}
