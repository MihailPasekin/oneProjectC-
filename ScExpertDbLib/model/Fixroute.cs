using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Fixroute
{
    public string Routename { get; set; } = null!;

    public string? Routeshcedid { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
