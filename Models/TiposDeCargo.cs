using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class TiposDeCargo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();
}
