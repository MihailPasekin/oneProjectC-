using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPutAwayVw
{
    public string Location { get; set; } = null!;

    public double Volume { get; set; }

    public double Weight { get; set; }

    public int Numloads { get; set; }
}
