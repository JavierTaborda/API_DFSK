using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_DFSK.DTOs.ConcesionarioDFSK;

public partial class RepuestoDTO
{
    [Required(ErrorMessage = "Campo  Repuesto Requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El valor de IdRepuesto debe ser mayor que 0.")]
    public int IdRepuesto { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public double? Precio { get; set; }

    public int? IdVehiculo { get; set; }

    [Required(ErrorMessage = "Campo  Estatus Requerido.")]
    public bool Estatus { get; set; }
    public string? Marca { get; set; }

    public string? Modelo { get; set; }


}
