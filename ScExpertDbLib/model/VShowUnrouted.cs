using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShowUnrouted
{
    public string Routingset { get; set; } = null!;

    public string Runid { get; set; } = null!;

    public string Pointid { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public double? Lat { get; set; }

    public double? Lon { get; set; }

    public string Company { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Address { get; set; }

    public double Orderweight { get; set; }

    public double Ordervolume { get; set; }

    public string OpenHour { get; set; } = null!;

    public string CloseHour { get; set; } = null!;

    public string Infowindow { get; set; } = null!;

    public string Tooltip { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string ShadowImage { get; set; } = null!;
}
