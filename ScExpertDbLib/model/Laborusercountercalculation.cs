using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Laborusercountercalculation
{
    public string Laborcounterid { get; set; } = null!;

    public string? Laborcounterdescription { get; set; }

    public string? Laborcounterscope { get; set; }

    public string? Countercalculation { get; set; }
}
