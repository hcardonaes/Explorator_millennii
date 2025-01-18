using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class Cargo
{
    public int Id { get; set; }

    public int PersonajeId { get; set; }

    public int TipoCargoId { get; set; }

    public int InstitucionId { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public virtual Institucione Institucion { get; set; } = null!;

    public virtual Personaje Personaje { get; set; } = null!;

    public virtual TiposDeCargo TipoCargo { get; set; } = null!;
}
