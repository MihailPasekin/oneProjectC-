using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Carrier
{
    public string Carrier1 { get; set; } = null!;

    public string? Carriername { get; set; }

    public string? Notes { get; set; }

    public string Contactid { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
