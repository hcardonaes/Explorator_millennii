using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class Institucione
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();
}
