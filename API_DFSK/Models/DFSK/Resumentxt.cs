using System;
using System.Collections.Generic;

namespace API_DFSK.Models.DFSK;

public partial class Resumentxt
{
    public int Idresumentxt { get; set; }

    /// <summary>
    /// fijo alfanumerico de txt
    /// </summary>
    public string Re { get; set; } = null!;

    /// <summary>
    /// INICIALES DE LA EMPRESA (IM)
    /// </summary>
    public string Inicialempresa { get; set; } = null!;

    /// <summary>
    /// NUMERO DE ENVIO
    /// </summary>
    public string Numenvio { get; set; } = null!;

    /// <summary>
    /// FECHA DEL ENVIO
    /// </summary>
    public string Fechaenvio { get; set; } = null!;

    /// <summary>
    /// HORA DEL ENVIO
    /// </summary>
    public string Horaenvio { get; set; } = null!;

    /// <summary>
    /// NOMBRE DE EMPRESA
    /// </summary>
    public string Nombreempresa { get; set; } = null!;

    /// <summary>
    /// NUMERO DE REFECIV
    /// </summary>
    public string Refeciv { get; set; } = null!;

    /// <summary>
    /// FECHA FIN DEL CONVENIO
    /// </summary>
    public string Fechafin { get; set; } = null!;

    /// <summary>
    /// RESTO DE LA LINEA INICIAL
    /// </summary>
    public string Restolinea { get; set; } = null!;

    /// <summary>
    /// FIJO ALFANUMERICO DE LINEA FINAL
    /// </summary>
    public string Rc { get; set; } = null!;

    /// <summary>
    /// REGISTROS AGREGAR
    /// </summary>
    public string Ma { get; set; } = null!;

    /// <summary>
    /// REGISTROS MODIF
    /// </summary>
    public string Mm { get; set; } = null!;

    /// <summary>
    /// REGISTROS ELIMINAR
    /// </summary>
    public string Me { get; set; } = null!;

    public virtual ICollection<Lineatxt> Lineatxts { get; set; } = new List<Lineatxt>();
}
