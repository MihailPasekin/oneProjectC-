using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VVehicleRoute
{
    public DateTime Timestamp { get; set; }

    public string ActivityTime { get; set; } = null!;

    public string? Vehicleid { get; set; }

    public double? MinLong { get; set; }

    public double? MinLat { get; set; }

    public DateTime? MinTimeStamp { get; set; }

    public double? MaxLong { get; set; }

    public double? MaxLat { get; set; }

    public DateTime? MaxTimeStamp { get; set; }
}
