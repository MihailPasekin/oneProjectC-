using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingpolicyvehicleallocation
{
    public string? Runid { get; set; }

    public string Strategyid { get; set; } = null!;

    public int Priority { get; set; }

    public string Vehicletype { get; set; } = null!;

    public int Totalvehicles { get; set; }

    public int? Allocatedvehicles { get; set; }

    public int? Numvehicles { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
