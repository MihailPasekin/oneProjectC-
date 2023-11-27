using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VVehicleLastPo
{
    public string Vehicleid { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    public DateTime Timestamp { get; set; }

    public int Runid { get; set; }

    public string Vehicletypename { get; set; } = null!;

    public string? Driverid { get; set; }

    public string? Vehicletype { get; set; }

    public string? Name { get; set; }

    public string? Lastname { get; set; }

    public string? Fullname { get; set; }
}
