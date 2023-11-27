using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Mapnetworkdistance
{
    public string Source { get; set; } = null!;

    public string Destination { get; set; } = null!;

    public double? Distance { get; set; }

    public double? Drivingtime { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
