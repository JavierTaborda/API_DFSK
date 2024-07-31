using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Menuydocumento
{
    public string Programa { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Tipodocs { get; set; }

    public string? Nombredocs { get; set; }
}
