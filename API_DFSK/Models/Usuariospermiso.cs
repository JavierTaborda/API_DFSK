using System;
using System.Collections.Generic;

namespace API_DFSK.Models;

public partial class Usuariospermiso
{
    public string Usuario { get; set; } = null!;

    public string Programa { get; set; } = null!;

    public virtual Modusuario UsuarioNavigation { get; set; } = null!;
}
