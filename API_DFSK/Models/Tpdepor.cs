using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Tpdepor
{
    public string CodProd { get; set; } = null!;

    public string? CodUbic { get; set; }

    public decimal? Existen { get; set; }

    public int ExUnidad { get; set; }

    public int CantPed { get; set; }

    public int UnidPed { get; set; }

    public int CantCom { get; set; }

    public int UnidCom { get; set; }
}
