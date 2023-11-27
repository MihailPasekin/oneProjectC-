using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShiftPerformanceSummary
{
    public DateTime? Shiftdate { get; set; }

    public string Shiftid { get; set; } = null!;

    public int? Users { get; set; }

    public int? Duration { get; set; }

    public int? Actualtime { get; set; }

    public int? Standarttime { get; set; }

    public int? Avgstandarttime { get; set; }
}
