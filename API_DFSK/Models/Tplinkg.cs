using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Tplinkg
{
    public int? Year { get; set; }

    public string? Q { get; set; }

    public string? Month { get; set; }

    public int? Month1 { get; set; }

    public DateOnly? Date { get; set; }

    public string Account { get; set; } = null!;

    public string CustomerCountry { get; set; } = null!;

    public string SalesPerson { get; set; } = null!;

    public string Channel { get; set; } = null!;

    public string Customer { get; set; } = null!;

    public string? Nmaster { get; set; }

    public string Rif { get; set; } = null!;

    public string? Estate { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string Mqcode { get; set; } = null!;

    public string? Category { get; set; }

    public string? Model { get; set; }

    public decimal Qty { get; set; }

    public decimal? Price { get; set; }

    public decimal? TotalValue { get; set; }
}
