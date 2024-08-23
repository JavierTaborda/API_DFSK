using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Vehiculo
{
    public int IdVehiculo { get; set; }


    public string? Codigo { get; set; }
    public string? Descripcion { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? Anho { get; set; }


    public bool Estatus { get; set; }

    public virtual ICollection<Repuesto> Repuestos { get; set; } = new List<Repuesto>();
}
