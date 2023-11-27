using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehicleposition
{
    public string Vehicleid { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    public DateTime Timestamp { get; set; }

    public int Runid { get; set; }
}
