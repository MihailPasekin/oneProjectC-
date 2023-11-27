using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWavePicksSummary
{
    public string Wave { get; set; } = null!;

    public string? Status { get; set; }

    public string PickType { get; set; } = null!;

    public int? Total { get; set; }

    public int? Completed { get; set; }

    public int? Assigned { get; set; }

    public decimal? CompletedPct { get; set; }

    public string? PickLinesOpenTotal { get; set; }

    public string? EstimatedTimeOpenTotal { get; set; }
}
