using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Whactivity
{
    public string Activityid { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string? Hetype { get; set; }

    public string? Activity { get; set; }

    public string? Location { get; set; }

    public DateTime? Activitytime { get; set; }

    public string? Mheid { get; set; }

    public string? Terminaltype { get; set; }

    public string? Shift { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
