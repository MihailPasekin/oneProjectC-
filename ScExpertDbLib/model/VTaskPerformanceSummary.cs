using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VTaskPerformanceSummary
{
    public string? Shiftdate { get; set; }

    public string Shiftid { get; set; } = null!;

    public string? Tasktype { get; set; }

    public int? Actualtime { get; set; }

    public int? Standarttime { get; set; }

    public int? Performance { get; set; }
}
