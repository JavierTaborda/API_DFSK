using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class VDbmsSqlBindVariable
{
    public int CursorId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public object? VValue { get; set; }

    public string? CValue { get; set; }

    public string? NcValue { get; set; }

    public byte[]? BValue { get; set; }
}
