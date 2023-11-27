using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class LoadingPlanVehicleLocation
{
    public string Shipment { get; set; } = null!;

    public string? Trailer { get; set; }

    public string Vehicletypename { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Totalvolume { get; set; }

    public decimal? Totalweight { get; set; }

    public string Location { get; set; } = null!;

    public string Side { get; set; } = null!;

    public int? Bay { get; set; }

    public string? Level { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Depth { get; set; }

    public double? Weightlimit { get; set; }

    public string? Status { get; set; }
}
