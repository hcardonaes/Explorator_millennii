using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class Evento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public int? LugarId { get; set; }

    public string? Descripcion { get; set; }

    public virtual Lugare? Lugar { get; set; }

    public virtual ICollection<ProtagonismosDeEvento> ProtagonismosDeEventos { get; set; } = new List<ProtagonismosDeEvento>();

    public virtual ICollection<RolPersonaje> RolPersonajes { get; set; } = new List<RolPersonaje>();
}
