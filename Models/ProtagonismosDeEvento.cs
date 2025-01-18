using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class ProtagonismosDeEvento
{
    public int Id { get; set; }

    public int PersonajeId { get; set; }

    public int RolId { get; set; }

    public int EventoId { get; set; }

    public string? Descripcion { get; set; }

    public virtual Evento Evento { get; set; } = null!;

    public virtual Personaje Personaje { get; set; } = null!;

    public virtual Role Rol { get; set; } = null!;
}
