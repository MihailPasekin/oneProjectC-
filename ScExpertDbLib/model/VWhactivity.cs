using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWhactivity
{
    public string? Activity { get; set; }

    public DateTime? Activitytime { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public string? Hetype { get; set; }

    public string? Location { get; set; }

    public string Userid { get; set; } = null!;
}
