using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Articulo
{
    public string Articulo1 { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Marca { get; set; }

    public string? Unidad { get; set; }

    public string? Categoria { get; set; }

    public decimal? Stockminimo { get; set; }

    public decimal? Reposicion { get; set; }

    public decimal? Iva { get; set; }

    public DateTime? Fechacif { get; set; }

    public decimal? Cif { get; set; }

    public string? Tipo { get; set; }

    public decimal? Garantia { get; set; }

    public decimal? Descuento { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? Fechaactual { get; set; }

    public decimal? Empaque { get; set; }

    public string? Ean { get; set; }

    public decimal? Grupo { get; set; }

    public decimal? Cbm { get; set; }

    public decimal? Venta { get; set; }

    public decimal? Cifm { get; set; }

    public string? Modelo { get; set; }

    public decimal? Puntos { get; set; }

    public DateTime? Modificacion { get; set; }

    public int Nrounico { get; set; }

    public string? Ubicacion { get; set; }

    public string? Color { get; set; }

    public string? Exento { get; set; }

    public string? Uso { get; set; }

    public string? Ano { get; set; }

    public string? Tipoc { get; set; }

    public string? Transmision { get; set; }

    public int? Puertas { get; set; }

    public string? Modeloi { get; set; }

    public string? Color1 { get; set; }

    public string? Color2 { get; set; }

    public string? Color1t { get; set; }

    public string? Color2t { get; set; }

    public string? Rin { get; set; }

    public string? Ejesi { get; set; }

    public string? Puestos { get; set; }

    public string? Peso { get; set; }

    public string? Capcarga { get; set; }

    public string? Clasei { get; set; }

    public string? Claset { get; set; }

    public string? Tipoi { get; set; }

    public string? Tipot { get; set; }

    public string? Usoi { get; set; }

    public string? Usot { get; set; }

    public string? Serie { get; set; }

    public string? Marcai { get; set; }

    public string? Servicio { get; set; }

    public string? Combustible { get; set; }

    public string? Anof { get; set; }

    public string? Anom { get; set; }

    public string? Activo { get; set; }

    public string? Grupoa { get; set; }

    public virtual ICollection<Bodega> Bodegas { get; set; } = new List<Bodega>();

    public virtual ICollection<Ensamble> Ensambles { get; set; } = new List<Ensamble>();

    public virtual ICollection<Logisticamovart> Logisticamovarts { get; set; } = new List<Logisticamovart>();

    public virtual ICollection<Logisticaseriale> Logisticaseriales { get; set; } = new List<Logisticaseriale>();
}
