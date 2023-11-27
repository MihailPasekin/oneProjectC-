using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VVehiclePositionSearch
{
    public string Vehicleid { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    public DateTime Timestamp { get; set; }

    public int Runid { get; set; }

    public string? Activitytime { get; set; }
}
