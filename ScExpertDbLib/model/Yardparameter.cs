using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Yardparameter
{
    public string Paramcode { get; set; } = null!;

    public string? Paramdesc { get; set; }

    public string Paramvalue { get; set; } = null!;
}
