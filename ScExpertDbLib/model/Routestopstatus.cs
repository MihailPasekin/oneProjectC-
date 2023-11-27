using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routestopstatus
{
    public string Bol { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime Statusdate { get; set; }

    public string Customerkey { get; set; } = null!;

    public string? Adduser { get; set; }

    public DateTime Adddate { get; set; }

    public string? Edituser { get; set; }

    public DateTime Editdate { get; set; }
}
