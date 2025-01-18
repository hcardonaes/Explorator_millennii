using System;
using System.Collections.Generic;

namespace Explorator_millennii.Models;

public partial class TipoParentesco
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Reciproca { get; set; } = null!;

    public virtual ICollection<LazosFamiliare> LazosFamiliares { get; set; } = new List<LazosFamiliare>();
}
