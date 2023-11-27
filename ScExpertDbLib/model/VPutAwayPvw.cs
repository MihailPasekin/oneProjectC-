using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPutAwayPvw
{
    public string? Destinationlocation { get; set; }

    public double Pendingvolume { get; set; }

    public double Pendingweight { get; set; }

    public int Numloads { get; set; }
}
