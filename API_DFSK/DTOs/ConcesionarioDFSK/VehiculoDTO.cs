using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_DFSK.DTOs.ConcesionarioDFSK;

public partial class VehiculoDTO
{
    public int IdVehiculo { get; set; }

    public string? Codigo { get; set; }
    public string? Descripcion { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? Anho { get; set; }


    public bool Estatus { get; set; }

  
}
