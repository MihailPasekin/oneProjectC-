using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShowVehiclePosition
{
    public string Tooltip { get; set; } = null!;

    public string Infowindow { get; set; } = null!;

    public string Vehicleid { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    public DateTime Timestamp { get; set; }

    public int Runid { get; set; }
}
