using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_DFSK.DTOs.ConcesionarioDFSK;

public partial class VehiculoDTO
{
 
    [Range(0, int.MaxValue, ErrorMessage = "El valor de IdVehiculo debe ser mayor que 0.")]
    public int IdVehiculo { get; set; }

    public string? Codigo { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? Anho { get; set; }

    public string? Vin { get; set; }
    [Required(ErrorMessage = "Campo  {0} Requerido.")]
    public bool Estatus { get; set; }

  
}
