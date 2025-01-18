using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<ProtagonismosDeEvento> ProtagonismosDeEventos { get; set; } = new List<ProtagonismosDeEvento>();

    public virtual ICollection<RolPersonaje> RolPersonajes { get; set; } = new List<RolPersonaje>();
}
