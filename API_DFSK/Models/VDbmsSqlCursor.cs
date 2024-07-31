using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class VDbmsSqlCursor
{
    public int Id { get; set; }

    public int Spid { get; set; }

    public DateTime LoginTime { get; set; }

    public string? Statement { get; set; }

    public int? CurrentRow { get; set; }

    public int? LastRow { get; set; }
}
