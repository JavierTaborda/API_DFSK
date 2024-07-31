using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class DbLobOutputSession
{
    public int Ordinal { get; set; }

    public string? CValue { get; set; }

    public string? NcValue { get; set; }

    public byte[]? BValue { get; set; }
}
