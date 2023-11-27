using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingResource
{
    public string Strategyid { get; set; } = null!;

    public int Priority { get; set; }

    public string Vehicletype { get; set; } = null!;

    public int Numvehicles { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
