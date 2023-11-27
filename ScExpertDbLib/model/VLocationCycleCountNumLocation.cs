using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLocationCycleCountNumLocation
{
    public string Warehousearea { get; set; } = null!;

    public int? Cyclesdayint { get; set; }

    public int? TotalNumLocation { get; set; }

    public decimal NumLocationPerRun { get; set; }
}
