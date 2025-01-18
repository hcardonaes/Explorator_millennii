using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class Lugare
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public double? Latitud { get; set; }

    public double? Longitud { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
}
