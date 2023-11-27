using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VContainerLoadsPlanner
{
    public string Container { get; set; } = null!;

    public string? Hutype { get; set; }

    public int? Numloads { get; set; }
}
