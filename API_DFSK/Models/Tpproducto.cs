using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Tpproducto
{
    public string? CodProd { get; set; }

    public string? Descrip { get; set; }

    public int CodInst { get; set; }

    public int Activo { get; set; }

    public string Descrip2 { get; set; } = null!;

    public string Descrip3 { get; set; } = null!;

    public string Refere { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Unidad { get; set; } = null!;

    public string UndEmpaq { get; set; } = null!;

    public decimal CantEmpaq { get; set; }

    public decimal? Precio1 { get; set; }

    public decimal? Precio2 { get; set; }

    public decimal? PrecioU2 { get; set; }

    public decimal? Precio3 { get; set; }

    public decimal? PrecioU3 { get; set; }

    public decimal? PrecioU { get; set; }

    public decimal CostAct { get; set; }

    public decimal CostPro { get; set; }

    public decimal CostAnt { get; set; }

    public int Existen { get; set; }

    public int ExUnidad { get; set; }

    public int Compro { get; set; }

    public int Pedido { get; set; }

    public int Minimo { get; set; }

    public int Maximo { get; set; }

    public int Tara { get; set; }

    public int DesComp { get; set; }

    public int DesComi { get; set; }

    public int DesSeri { get; set; }

    public int EsReten { get; set; }

    public int DesLote { get; set; }

    public int DesVence { get; set; }

    public int EsImport { get; set; }

    public int EsExento { get; set; }

    public int EsEnser { get; set; }

    public int EsOferta { get; set; }

    public int EsPesa { get; set; }

    public int EsEmpaque { get; set; }

    public int ExDecimal { get; set; }

    public int DiasEntr { get; set; }

    public int? FechaUv { get; set; }

    public int? FechaUc { get; set; }

    public int DiasTole { get; set; }

    public int Peso { get; set; }

    public int Volumen { get; set; }

    public int UndVol { get; set; }

    public int Costant2 { get; set; }

    public decimal? Descuento { get; set; }
}
