using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoCliente
{
    public string? NombreDeCuenta { get; set; }

    public string? PropietarioDeCuenta { get; set; }

    public string? Sector { get; set; }

    public string NumeroDeCuenta { get; set; } = null!;

    public string? Sitio { get; set; }

    public string? Celular { get; set; }

    public string? Correo { get; set; }

    public string RifCodigo { get; set; } = null!;

    public string? DireccionFact { get; set; }

    public string? Ciudad { get; set; }

    public string Estado { get; set; } = null!;

    public string? DirEnvio { get; set; }

    public string? ContactoPrincipal { get; set; }

    public DateTime? Fecha1 { get; set; }

    public DateTime? Fecha2 { get; set; }

    public DateTime? Fecha3 { get; set; }

    public string? Nota1 { get; set; }

    public string? Nota2 { get; set; }

    public string? Nota3 { get; set; }

    public string? Nota4 { get; set; }

    public string? Nota5 { get; set; }

    public string? Nota6 { get; set; }

    public string? Nota7 { get; set; }

    public string? Nota8 { get; set; }

    public string? Nota9 { get; set; }

    public string? Nota10 { get; set; }

    public string? Nota11 { get; set; }

    public string? Nota12 { get; set; }

    public string? Nota13 { get; set; }

    public string? Nota14 { get; set; }

    public string? Nota15 { get; set; }

    public decimal? Total { get; set; }
}
