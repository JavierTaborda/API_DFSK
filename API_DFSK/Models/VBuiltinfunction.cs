using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class VBuiltinfunction
{
    public DateTime Gmttime { get; set; }

    public DateTime LocalTime { get; set; }

    public int? TimeDiff { get; set; }
}
