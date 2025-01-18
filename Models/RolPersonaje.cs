using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class RolPersonaje
{
    public int Id { get; set; }

    public int PersonajeId { get; set; }

    public int RolId { get; set; }

    public int? EventoId { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public virtual Evento? Evento { get; set; }

    public virtual Personaje Personaje { get; set; } = null!;

    public virtual Role Rol { get; set; } = null!;
}
