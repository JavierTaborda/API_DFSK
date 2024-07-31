using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class ZohoContacto
{
    public string? PropietarioDeContacto { get; set; }

    public string? Nombre { get; set; }

    public string? NombreCuenta { get; set; }

    public string RifCodigo { get; set; } = null!;

    public string? TelefonoCelular { get; set; }

    public string? Correo { get; set; }

    public string? CorreoSecundario { get; set; }

    public string? Ciudad { get; set; }

    public string Estado { get; set; } = null!;
}
