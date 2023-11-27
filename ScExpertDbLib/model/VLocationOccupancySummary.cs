using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLocationOccupancySummary
{
    public string Location { get; set; } = null!;

    public string? Warehousearea { get; set; }

    public string Locationoccupancy { get; set; } = null!;
}
