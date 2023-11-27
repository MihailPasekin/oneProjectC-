using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class YardDoorsStartTimePerDay
{
    public string? DayOfWeek { get; set; }

    public string StartTime { get; set; } = null!;

    public string Paramcode { get; set; } = null!;
}
