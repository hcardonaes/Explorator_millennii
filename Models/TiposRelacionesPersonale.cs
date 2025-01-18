using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class TiposRelacionesPersonale
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Reciproca { get; set; }

    public virtual ICollection<RelacionesPersonale> RelacionesPersonales { get; set; } = new List<RelacionesPersonale>();
}
