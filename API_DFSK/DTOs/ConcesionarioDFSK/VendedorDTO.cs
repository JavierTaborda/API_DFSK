using System;
using System.Collections.Generic;

namespace API_DFSK.DTOs.ConcesionarioDFSK;

public partial class VendedorDTO
{
    public int IdVendedor { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public bool Estatus { get; set; }

    //public virtual ICollection<Solicitude> Solicitudes { get; set; } = new List<Solicitude>();
}
