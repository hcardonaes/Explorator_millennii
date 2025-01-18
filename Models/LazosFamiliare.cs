using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class LazosFamiliare
{
    public int Id { get; set; }

    public int PersonajeId1 { get; set; }

    public int TipoRelacionId { get; set; }

    public int PersonajeId2 { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public virtual Personaje PersonajeId1Navigation { get; set; } = null!;

    public virtual Personaje PersonajeId2Navigation { get; set; } = null!;

    public virtual TipoParentesco TipoRelacion { get; set; } = null!;
}
