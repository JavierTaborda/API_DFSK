using System;
using System.Collections.Generic;

namespace API_DFSK.Models.ConcesionarioDFSK;

public partial class Rol
{
    public int IdRol { get; set; }

    public string? RolName { get; set; }

    public string? Descripcion { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Vendedore> Vendedores { get; set; } = new List<Vendedore>();
}
