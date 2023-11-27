using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMapterritoryboundary
{
    public string Pointid { get; set; } = null!;

    public string Territoryid { get; set; } = null!;

    public string Territorysetid { get; set; } = null!;

    public int Pointnum { get; set; }

    public double? Lon { get; set; }

    public double? Lat { get; set; }

    public string Tooltip { get; set; } = null!;
}
