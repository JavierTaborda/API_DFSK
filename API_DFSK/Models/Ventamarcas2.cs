using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Ventamarcas2
{
    public string Compañia { get; set; } = null!;

    public string Vendedor { get; set; } = null!;

    public string? Sede { get; set; }

    public DateTime Flarga { get; set; }

    public decimal? Transporte { get; set; }

    public string? Periodo { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Dia { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string Cliente { get; set; } = null!;

    public string? Estado { get; set; }

    public string Codigo { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string? Grupo { get; set; }

    public string Producto { get; set; } = null!;

    public decimal Qty { get; set; }

    public string Marca { get; set; } = null!;

    public decimal? Venta { get; set; }

    public decimal? Ventad { get; set; }

    public decimal Costod { get; set; }

    public decimal Costo { get; set; }

    public decimal? Tasaf { get; set; }

    public decimal? Tasa { get; set; }

    public decimal? Tasar { get; set; }

    public decimal Preciol { get; set; }

    public decimal Preciolt { get; set; }

    public decimal? Bodega { get; set; }

    public string? SerialVin { get; set; }

    public string? Placa { get; set; }
}
