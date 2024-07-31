using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class VDbmsSqlDefineColumn
{
    public int CursorId { get; set; }

    public int Position { get; set; }

    public string Type { get; set; } = null!;
}
