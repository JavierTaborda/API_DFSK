using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_DFSK.DTOs.ConcesionarioDFSK;

public partial class VendedorDTO
{
    [Required(ErrorMessage = "Campo  Vendedor Requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El valor de IdVendedor debe ser mayor que 0.")]
    public int IdVendedor { get; set; }

    public string? Codigo { get; set; }

    [Required(ErrorMessage = "Campo  {0} Requerido.")]
    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    [Required(ErrorMessage = "Campo  {0} Requerido.")]
    public bool Estatus { get; set; }

}
