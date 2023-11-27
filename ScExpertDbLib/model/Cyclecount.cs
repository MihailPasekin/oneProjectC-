using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Cyclecount
{
    public string Warehousearea { get; set; } = null!;

    public int? Cyclesdayint { get; set; }

    public bool? Active { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
