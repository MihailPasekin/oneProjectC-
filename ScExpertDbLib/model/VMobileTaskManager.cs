using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileTaskManager
{
    public string Assigned { get; set; } = null!;

    public string TaskId { get; set; } = null!;

    public string TaskType { get; set; } = null!;

    public string? TaskSubType { get; set; }

    public int Priority { get; set; }

    public string? FromLocation { get; set; }

    public DateTime? AssignedTime { get; set; }

    public decimal? Stdtime { get; set; }

    public string Spacer { get; set; } = null!;
}
