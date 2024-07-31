using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class DbStorageCurrent
{
    public string Name { get; set; } = null!;

    public object? VValue { get; set; }

    public string? CValue { get; set; }

    public string? NcValue { get; set; }

    public byte[]? BValue { get; set; }
}
