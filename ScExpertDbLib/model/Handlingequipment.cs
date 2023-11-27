using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Handlingequipment
{
    public string Handlingequipment1 { get; set; } = null!;

    public string Mobilitycode { get; set; } = null!;

    public double Weightcapacity { get; set; }

    public bool? Allowshareaisle { get; set; }

    public double? Walkthreshold { get; set; }

    public double? Slowthreshold { get; set; }

    public double? Fastthreshold { get; set; }

    public double? Mhehorizontalconst { get; set; }

    public double? Mhehorizontalvariable { get; set; }

    public double? Mhecongestionfactor { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
