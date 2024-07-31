using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Despacho
{
    public string TipoDoc { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Numero { get; set; }

    public string Docasoc { get; set; } = null!;

    public DateTime Fechaasoc { get; set; }

    public decimal Numeroasoc { get; set; }

    public string Cliente { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public decimal? Bultos { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Camara { get; set; }

    public decimal? NroArticulos { get; set; }

    public int Nrounico { get; set; }

    public virtual Documento TipoDocNavigation { get; set; } = null!;
}
