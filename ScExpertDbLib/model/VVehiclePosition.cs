using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VVehiclePosition
{
    public string Vehicleid { get; set; } = null!;

    public string Vehicletypename { get; set; } = null!;

    public double Lat { get; set; }

    public double Lon { get; set; }

    public DateTime Timestamp { get; set; }

    public string Infowindow { get; set; } = null!;

    public string Tooltip { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string ShadowImage { get; set; } = null!;
}
