using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Certificado
{
    public DateTime Fechae { get; set; }

    public string? Ncontrol { get; set; }

    public string? Consecionario1 { get; set; }

    public string? Consecionario2 { get; set; }

    public string? Rif1 { get; set; }

    public string? Rif2 { get; set; }

    public string? Propiedad1 { get; set; }

    public string? Propiedad2 { get; set; }

    public string? Consignado1 { get; set; }

    public string? Consignado2 { get; set; }

    public string? Cicomprador { get; set; }

    public string? Nombcomprador { get; set; }

    public string? Casa { get; set; }

    public string? Av { get; set; }

    public string? Urb { get; set; }

    public string? Ciudad { get; set; }

    public string? Distrito { get; set; }

    public string? Ent { get; set; }

    public string? Codpostal { get; set; }

    public string? Codarea1 { get; set; }

    public string? Tlfcasa { get; set; }

    public string Serialm { get; set; } = null!;

    public string? Reserva { get; set; }

    public string? Reserva1 { get; set; }

    public string? Ncertificado { get; set; }
}
