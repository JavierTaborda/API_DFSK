using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ClientesAct
{
    public string Cliente { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public decimal? Estado { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public decimal? Categoria { get; set; }

    public string? Vendedor { get; set; }

    public decimal? Cupo { get; set; }

    public decimal? Plazo { get; set; }

    public string Iva { get; set; } = null!;

    public string? Retencion { get; set; }

    public decimal? Lista { get; set; }

    public string? Cedula { get; set; }

    public string? Contacto { get; set; }

    public string? Email { get; set; }

    public string? Celular { get; set; }

    public DateTime? Cumpleano { get; set; }

    public string? Dirres { get; set; }

    public string? Telres { get; set; }

    public decimal? Zona { get; set; }

    public string? Usuario { get; set; }

    public string Tipocliente { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public DateTime Fechaactual { get; set; }

    public string? Comentario { get; set; }

    public string? Estado1 { get; set; }

    public string? Dirdespacho { get; set; }

    public string? Referencia { get; set; }

    public string? Parroquia { get; set; }

    public decimal? Cdescuento { get; set; }

    public decimal? Categoria1 { get; set; }

    public string? Clase { get; set; }

    public string? Master { get; set; }

    public DateTime? Fecha1 { get; set; }

    public DateTime? Fecha2 { get; set; }

    public DateTime? Fecha3 { get; set; }

    public DateTime? Modificacion { get; set; }

    public int Nrounico { get; set; }

    public string? S1 { get; set; }

    public string? S2 { get; set; }

    public string? S3 { get; set; }

    public string? S4 { get; set; }

    public string? S5 { get; set; }

    public string? S6 { get; set; }

    public decimal? E1 { get; set; }

    public decimal? E2 { get; set; }

    public decimal? E3 { get; set; }

    public decimal? E4 { get; set; }

    public decimal? E5 { get; set; }

    public decimal? E6 { get; set; }

    public string? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public string? C4 { get; set; }

    public string? C5 { get; set; }

    public string? C6 { get; set; }

    public string? T1 { get; set; }

    public string? T2 { get; set; }

    public string? T3 { get; set; }

    public string? T4 { get; set; }

    public string? T5 { get; set; }

    public string? T6 { get; set; }

    public string? Celular2 { get; set; }

    public string? Celular3 { get; set; }

    public string? Ncelular { get; set; }

    public string? Ncelular2 { get; set; }

    public string? Ncelular3 { get; set; }
}
