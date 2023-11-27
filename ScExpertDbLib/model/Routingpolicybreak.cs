using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routingpolicybreak
{
    public string Strategyid { get; set; } = null!;

    public string Breaktype { get; set; } = null!;

    public string Timecountertype { get; set; } = null!;

    public int Earlieststarttime { get; set; }

    public int Lateststarttime { get; set; }

    public string? Timecounterfrom { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
