using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VDashBoardTruck
{
    public string Routeid { get; set; } = null!;

    public string Vehicleid { get; set; } = null!;

    public double Lon { get; set; }

    public double Lat { get; set; }

    public DateTime Timestamp { get; set; }

    public int Runid { get; set; }

    public string? Drivername { get; set; }

    public string Image { get; set; } = null!;

    public string Shadowimage { get; set; } = null!;

    public string Infowindow { get; set; } = null!;

    public string Tooltip { get; set; } = null!;
}
