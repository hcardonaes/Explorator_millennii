using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class Personaje
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public string? Mote { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public DateOnly? FechaMuerte { get; set; }

    public int? Importancia { get; set; }

    public string? Biografia { get; set; }

    public virtual ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();

    public virtual ICollection<LazosFamiliare> LazosFamiliarePersonajeId1Navigations { get; set; } = new List<LazosFamiliare>();

    public virtual ICollection<LazosFamiliare> LazosFamiliarePersonajeId2Navigations { get; set; } = new List<LazosFamiliare>();

    public virtual ICollection<ProtagonismosDeEvento> ProtagonismosDeEventos { get; set; } = new List<ProtagonismosDeEvento>();

    public virtual ICollection<RelacionesPersonale> RelacionesPersonalePersonajeId1Navigations { get; set; } = new List<RelacionesPersonale>();

    public virtual ICollection<RelacionesPersonale> RelacionesPersonalePersonajeId2Navigations { get; set; } = new List<RelacionesPersonale>();

    public virtual ICollection<RolPersonaje> RolPersonajes { get; set; } = new List<RolPersonaje>();
}
