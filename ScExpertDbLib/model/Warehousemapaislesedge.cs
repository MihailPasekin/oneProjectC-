using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Warehousemapaislesedge
{
    public string Aisle { get; set; } = null!;

    public string Fromnodeid { get; set; } = null!;

    public string Tonodeid { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
