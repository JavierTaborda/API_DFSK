using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Repuesto
{
    public int IdRepuesto { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public double? Precio { get; set; }

    public int IdVehiculo { get; set; }

    public bool Estatus { get; set; }

    public string? Marca { get; set; }
    public bool EnInventario { get; set; }

    public virtual Vehiculo IdVehiculoNavigation { get; set; } = null!;

    public virtual ICollection<Solicitude> Solicitudes { get; set; } = new List<Solicitude>();
}
