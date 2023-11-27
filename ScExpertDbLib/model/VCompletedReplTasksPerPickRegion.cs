using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCompletedReplTasksPerPickRegion
{
    public string Task { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Executionlocation { get; set; }

    public string Pickregion { get; set; } = null!;

    public DateTime Editdate { get; set; }
}
