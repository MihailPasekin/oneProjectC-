using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Yardequipment
{
    public string Equipmentid { get; set; } = null!;

    public string? Vehicle { get; set; }

    public string? Trailer { get; set; }

    public string? Yardlocation { get; set; }

    public string Status { get; set; } = null!;

    public string? Tagnumber { get; set; }

    public DateTime Statusdate { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
