using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Vehiculo
{
    public string Placa { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public decimal Ano { get; set; }

    public string Color { get; set; } = null!;

    public string? Clase { get; set; }

    public string? Tipo { get; set; }

    public string? Uso { get; set; }

    public string? Propietario { get; set; }

    public string? Conductor { get; set; }

    public decimal? Capacidad { get; set; }

    public string? Carroceria { get; set; }

    public string? Motor { get; set; }

    public decimal? NumeroRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
