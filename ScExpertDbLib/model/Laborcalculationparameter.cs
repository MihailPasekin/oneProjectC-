using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Laborcalculationparameter
{
    public string Parameterid { get; set; } = null!;

    public string? Parameterdesc { get; set; }

    public string? Parametervalue { get; set; }
}
