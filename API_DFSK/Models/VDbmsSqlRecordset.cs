using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class VDbmsSqlRecordset
{
    public int CursorId { get; set; }

    public int Key { get; set; }

    public int Position { get; set; }

    public object? VValue { get; set; }

    public string? CValue { get; set; }

    public string? NcValue { get; set; }

    public byte[]? BValue { get; set; }
}
