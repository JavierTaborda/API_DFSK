using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Tpcliente
{
    public string? CodClie { get; set; }

    public string? Descrip { get; set; }

    public string? Id3 { get; set; }

    public int TipoId3 { get; set; }

    public int TipoId { get; set; }

    public int Activo { get; set; }

    public string DescOrder { get; set; } = null!;

    public string Clase { get; set; } = null!;

    public string Represent { get; set; } = null!;

    public string? Direc1 { get; set; }

    public string Direc2 { get; set; } = null!;

    public int Pais { get; set; }

    public int Estado { get; set; }

    public int Ciudad { get; set; }

    public int Municipio { get; set; }

    public string ZipCode { get; set; } = null!;

    public int Telef { get; set; }

    public int Movil { get; set; }

    public string Email { get; set; } = null!;

    public int Fax { get; set; }

    public string FechaE { get; set; } = null!;

    public string CodZona { get; set; } = null!;

    public string? CodVend { get; set; }

    public string CodConv { get; set; } = null!;

    public string CodAlte { get; set; } = null!;

    public int TipoCli { get; set; }

    public int TipoPvp { get; set; }

    public string Observa { get; set; } = null!;

    public int EsMoneda { get; set; }

    public int EsCredito { get; set; }

    public decimal LimiteCred { get; set; }

    public int DiasCred { get; set; }

    public int EsToleran { get; set; }

    public int DiasTole { get; set; }

    public int IntMora { get; set; }

    public decimal Descto { get; set; }

    public decimal Saldo { get; set; }

    public decimal PagosA { get; set; }

    public int? FechaUv { get; set; }

    public decimal MontoUv { get; set; }

    public string NumeroUv { get; set; } = null!;

    public int? FechaUp { get; set; }

    public decimal MontoUp { get; set; }

    public int? NumeroUp { get; set; }

    public decimal MontoMax { get; set; }

    public decimal MtoMaxCred { get; set; }

    public decimal PromPago { get; set; }

    public decimal RetenIva { get; set; }

    public decimal SaldoPtos { get; set; }

    public int? DescripExt { get; set; }

    public int? Nit { get; set; }

    public string CodSucu { get; set; } = null!;
}
