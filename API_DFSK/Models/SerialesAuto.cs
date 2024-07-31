using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class SerialesAuto
{
    public DateTime Fecha { get; set; }

    public string TipoDoc { get; set; } = null!;

    public decimal Numero { get; set; }

    public string? Serie { get; set; }

    public string? Modeloi { get; set; }

    public string? Anof { get; set; }

    public string? Scarroceria { get; set; }

    public string? Smotor { get; set; }

    public string? Placa { get; set; }

    public string? Color1t { get; set; }

    public string? Peso { get; set; }

    public string? Capcarga { get; set; }

    public string? Ejesi { get; set; }

    public string? Rin { get; set; }

    public string? Clasei { get; set; }

    public string? Tipoi { get; set; }

    public string? Usoi { get; set; }

    public DateOnly? Fechacertificado { get; set; }

    public string? Puertoentradac { get; set; }

    public string? Nimpuestos { get; set; }

    public DateOnly? Fimpuestos { get; set; }

    public string? NumCompra { get; set; }

    public DateOnly? Fcompra { get; set; }

    public string? Ano { get; set; }

    public string? Sniv { get; set; }

    public string? Schasis { get; set; }

    public decimal Expr1 { get; set; }

    public DateOnly? Ffactura { get; set; }

    public string? Servicio { get; set; }

    public string? Puestos { get; set; }

    public string? Refeciv { get; set; }

    public DateOnly? Fechafin { get; set; }

    public string? Combustible { get; set; }
}
