using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Tpprod
{
    public string Codprod { get; set; } = null!;

    public string? Descrip { get; set; }

    public int CodInst { get; set; }

    public int Activo { get; set; }

    public int CantEmpaq { get; set; }

    public decimal? Precio1 { get; set; }

    public decimal? Precio2 { get; set; }

    public decimal? PrecioU2 { get; set; }

    public decimal? Precio3 { get; set; }

    public decimal? PrecioU3 { get; set; }

    public decimal? PrecioU { get; set; }

    public decimal CostAct { get; set; }

    public decimal Costprod { get; set; }

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

    public int EsLote { get; set; }

    public int DesVence { get; set; }

    public int EsImport { get; set; }

    public int EsExento { get; set; }

    public int EsEnser { get; set; }

    public int EsOferta { get; set; }

    public int EsPesa { get; set; }

    public int EsEmpaque { get; set; }

    public int ExDecimal { get; set; }

    public int DiasEntr { get; set; }

    public int DiasTole { get; set; }

    public int Peso { get; set; }

    public int Volumen { get; set; }
}
