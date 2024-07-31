using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Compania
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public decimal? Telefono { get; set; }

    public decimal? Fax { get; set; }

    public string? Ciudad { get; set; }

    public string? Rif { get; set; }

    public string? Nit { get; set; }

    public decimal BodCostos { get; set; }

    public decimal BodVentas { get; set; }

    public decimal BodMalas { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal Iva { get; set; }

    public string? Moneda { get; set; }

    public string? Fraccion { get; set; }

    public decimal? Vendedor { get; set; }

    public decimal Tamarticulo { get; set; }

    public decimal Tamcliente { get; set; }

    public decimal Cambio { get; set; }

    public DateTime? Fechadia { get; set; }

    public decimal Tampagina { get; set; }

    public decimal Diaspedidos { get; set; }

    public decimal Lineasfacturas { get; set; }

    public decimal? Pedidos { get; set; }

    public decimal? Porventa { get; set; }

    public decimal? Costoventa { get; set; }

    public decimal Precisionc { get; set; }

    public decimal Precisionv { get; set; }

    public decimal Precisione { get; set; }

    public decimal? Retencion { get; set; }

    public decimal? BodProceso { get; set; }

    public string? Refecif { get; set; }

    public string? Fconvenio { get; set; }
}
