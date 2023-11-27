using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShowRouteStatistic
{
    public string Routeset { get; set; } = null!;

    public string Runid { get; set; } = null!;

    public DateTime? Distributiondate { get; set; }

    public DateTime? Plandate { get; set; }

    public string IsActive { get; set; } = null!;

    public int NumRoutes { get; set; }

    public int NumStops { get; set; }

    public int NumTasks { get; set; }

    public double? Totaldistance { get; set; }

    public double? Routecost { get; set; }

    public double? Totalvolume { get; set; }

    public double? Totalweight { get; set; }

    public string RouteSetStatus { get; set; } = null!;

    public int? NumReqs { get; set; }

    public int? Unrouted { get; set; }
}
