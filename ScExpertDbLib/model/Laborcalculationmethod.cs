using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Laborcalculationmethod
{
    public string Calculationid { get; set; } = null!;

    public string? Calculationdesc { get; set; }

    public string? Calculationequation { get; set; }
}
