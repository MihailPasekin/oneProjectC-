using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Yardmovement
{
    public string Movementid { get; set; } = null!;

    public string Fromyardlocation { get; set; } = null!;

    public string Toyardlocation { get; set; } = null!;

    public string? Yardequipmentid { get; set; }

    public string Status { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
