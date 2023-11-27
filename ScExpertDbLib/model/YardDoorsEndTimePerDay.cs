using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class YardDoorsEndTimePerDay
{
    public string? DayOfWeek { get; set; }

    public string EndTime { get; set; } = null!;

    public string Paramcode { get; set; } = null!;
}
