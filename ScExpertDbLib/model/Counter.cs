using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Counter
{
    public string Counter1 { get; set; } = null!;

    public long Counterval { get; set; }

    public int Length { get; set; }

    public string? Prefix { get; set; }

    public string Fillchar { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
