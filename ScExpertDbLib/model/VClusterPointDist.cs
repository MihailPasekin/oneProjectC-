using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VClusterPointDist
{
    public string Routingset { get; set; } = null!;

    public string? P1 { get; set; }

    public string? P2 { get; set; }

    public double? Dist { get; set; }
}
